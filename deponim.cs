using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace atm
{
    public partial class deponim : Form
    {
        string connectionString = "Data Source=DESKTOP-6QQTGN8;Initial Catalog=atmdb;Integrated Security=True;TrustServerCertificate=True";

        public deponim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ju lutem shkruani një shumë për të depozituar!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the input is a valid number
            if (!float.TryParse(textBox1.Text, out float depositAmount))
            {
                MessageBox.Show("Ju lutem shkruani një shumë valide!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the amount is positive
            if (depositAmount <= 0)
            {
                MessageBox.Show("Ju lutem vendosni një shumë pozitive!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                // Get the current user's IBAN from the menu form
                menu parentForm = this.Owner as menu;
            string userIban = parentForm.UserIban;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // 1. Update user balance
                string updateBalanceQuery = "UPDATE perdoruesit SET bilanci = bilanci + @Amount WHERE iban = @Iban";
                SqlCommand updateBalanceCmd = new SqlCommand(updateBalanceQuery, connection);
                updateBalanceCmd.Parameters.AddWithValue("@Amount", depositAmount);
                updateBalanceCmd.Parameters.AddWithValue("@Iban", userIban);
                updateBalanceCmd.ExecuteNonQuery();

                // 2. Get user ID
                string getUserIdQuery = "SELECT Id FROM perdoruesit WHERE iban = @Iban";
                SqlCommand getUserIdCmd = new SqlCommand(getUserIdQuery, connection);
                getUserIdCmd.Parameters.AddWithValue("@Iban", userIban);
                int userId = (int)getUserIdCmd.ExecuteScalar();

                // 3. Insert into transaction log
                string insertTransactionQuery = "INSERT INTO transaksionet (iban, tipi, shuma, Tdata, perdoruesiID) " +
                                               "VALUES (@Iban, @Tipi, @Shuma, GETDATE(), @UserId)";
                SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionQuery, connection);
                insertTransactionCmd.Parameters.AddWithValue("@Iban", userIban);
                insertTransactionCmd.Parameters.AddWithValue("@Tipi", "Depozitim");
                insertTransactionCmd.Parameters.AddWithValue("@Shuma", depositAmount);
                insertTransactionCmd.Parameters.AddWithValue("@UserId", userId);
                insertTransactionCmd.ExecuteNonQuery();

                MessageBox.Show("Depozitimi u krye me sukses!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if Owner is set and is a menu form
            if (this.Owner != null && this.Owner is menu)
            {
                // Show the menu form again
                this.Owner.Show();

                // Close the current deposit form
                this.Close();
            }
            else
            {
                // Fallback in case Owner isn't set correctly
                menu menuForm = new menu("User", ""); // This is not ideal, but a fallback
                menuForm.Show();
                this.Close();
            }
        }
    }
}