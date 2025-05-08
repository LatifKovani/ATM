using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace atm
{
    public partial class terheqje : Form
    {
        string connectionString = "Data Source=DESKTOP-6QQTGN8;Initial Catalog = ATM;Integrated Security=True;TrustServerCertificate=True";

        public terheqje()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ju lutem shkruani një shumë për të tërhequr!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(textBox1.Text, out float withdrawAmount))
            {
                MessageBox.Show("Ju lutem shkruani një shumë valide!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (withdrawAmount <= 0)
            {
                MessageBox.Show("Shuma e tërheqjes duhet të jetë pozitive!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the current user's IBAN from the parent (menu) form
            menu parentForm = this.Owner as menu;
            string userIban = parentForm.UserIban;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 1. Check current balance
                string getBalanceQuery = "SELECT bilanci FROM perdoruesit WHERE iban = @Iban";
                SqlCommand getBalanceCmd = new SqlCommand(getBalanceQuery, connection);
                getBalanceCmd.Parameters.AddWithValue("@Iban", userIban);
                float currentBalance = Convert.ToSingle(getBalanceCmd.ExecuteScalar());

                // 2. Validate sufficient balance
                if (withdrawAmount > currentBalance)
                {
                    MessageBox.Show("Fonde të pamjaftueshme!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Update balance
                string updateBalanceQuery = "UPDATE perdoruesit SET bilanci = bilanci - @Amount WHERE iban = @Iban";
                SqlCommand updateBalanceCmd = new SqlCommand(updateBalanceQuery, connection);
                updateBalanceCmd.Parameters.AddWithValue("@Amount", withdrawAmount);
                updateBalanceCmd.Parameters.AddWithValue("@Iban", userIban);
                updateBalanceCmd.ExecuteNonQuery();

                // 4. Get user ID for transaction log
                string getUserIdQuery = "SELECT Id FROM perdoruesit WHERE iban = @Iban";
                SqlCommand getUserIdCmd = new SqlCommand(getUserIdQuery, connection);
                getUserIdCmd.Parameters.AddWithValue("@Iban", userIban);
                int userId = (int)getUserIdCmd.ExecuteScalar();

                // 5. Record transaction
                string insertTransactionQuery = "INSERT INTO transaksionet (iban, tipi, shuma, Tdata, perdoruesiID) " +
                                              "VALUES (@Iban, @Tipi, @Shuma, GETDATE(), @UserId)";
                SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionQuery, connection);
                insertTransactionCmd.Parameters.AddWithValue("@Iban", userIban);
                insertTransactionCmd.Parameters.AddWithValue("@Tipi", "Tërheqje");
                insertTransactionCmd.Parameters.AddWithValue("@Shuma", withdrawAmount);
                insertTransactionCmd.Parameters.AddWithValue("@UserId", userId);
                insertTransactionCmd.ExecuteNonQuery();

                MessageBox.Show("Tërheqja u krye me sukses!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.Owner != null && this.Owner is menu)
            {
                this.Owner.Show();
                this.Close();
            }
            else
            {
                menu menuForm = new menu("User", ""); // Fallback
                menuForm.Show();
                this.Close();
            }
        }
    }
}