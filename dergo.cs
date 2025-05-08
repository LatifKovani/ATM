using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace atm
{
    public partial class dergo : Form
    {
        string connectionString = "Data Source=DESKTOP-6QQTGN8;Initial Catalog = ATM;Integrated Security=True;TrustServerCertificate=True";

        public dergo()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            // Validate recipient IBAN
            if (string.IsNullOrWhiteSpace(marresiIBAN.Text))
            {
                MessageBox.Show("Ju lutem shkruani IBAN-in e marrësit!");
                return;
            }

            // Validate amount
            if (string.IsNullOrWhiteSpace(shuma.Text))
            {
                MessageBox.Show("Ju lutem shkruani një shumë për të transferuar!");
                return;
            }

            // Check if the amount is a valid number
            if (!float.TryParse(shuma.Text, out float transferAmount))
            {
                MessageBox.Show("Ju lutem shkruani një shumë valide!");
                return;
            }

            // Check if the amount is positive
            if (transferAmount <= 0)
            {
                MessageBox.Show("Ju lutem vendosni një shumë pozitive!");
                return;
            }

            // Get the current user's IBAN from the menu form
            menu parentForm = this.Owner as menu;
            string senderIban = parentForm.UserIban;
            string recipientIban = marresiIBAN.Text.Trim();

            // Don't allow transfer to the same account
            if (senderIban == recipientIban)
            {
                MessageBox.Show("Nuk mund të transferoni para në llogarinë tuaj!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if recipient IBAN exists
                    string checkRecipientQuery = "SELECT COUNT(*) FROM perdoruesit WHERE iban = @RecipientIban";
                    SqlCommand checkRecipientCmd = new SqlCommand(checkRecipientQuery, connection);
                    checkRecipientCmd.Parameters.AddWithValue("@RecipientIban", recipientIban);
                    int recipientExists = (int)checkRecipientCmd.ExecuteScalar();

                    if (recipientExists == 0)
                    {
                        MessageBox.Show("IBAN-i i marrësit nuk ekziston!");
                        return;
                    }

                    // Check if sender has sufficient funds
                    string checkBalanceQuery = "SELECT bilanci FROM perdoruesit WHERE iban = @SenderIban";
                    SqlCommand checkBalanceCmd = new SqlCommand(checkBalanceQuery, connection);
                    checkBalanceCmd.Parameters.AddWithValue("@SenderIban", senderIban);
                    float currentBalance = Convert.ToSingle(checkBalanceCmd.ExecuteScalar());

                    if (currentBalance < transferAmount)
                    {
                        MessageBox.Show("Ju nuk keni mjete të mjaftueshme për këtë transferim!");
                        return;
                    }

                    // Get the message from the textbox
                    string userMessage = messagebox.Text.Trim();

                    // Start a transaction to ensure atomicity
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // 1. Deduct amount from sender
                            string deductQuery = "UPDATE perdoruesit SET bilanci = bilanci - @Amount WHERE iban = @SenderIban";
                            SqlCommand deductCmd = new SqlCommand(deductQuery, connection, transaction);
                            deductCmd.Parameters.AddWithValue("@Amount", transferAmount);
                            deductCmd.Parameters.AddWithValue("@SenderIban", senderIban);
                            deductCmd.ExecuteNonQuery();

                            // 2. Add amount to recipient
                            string addQuery = "UPDATE perdoruesit SET bilanci = bilanci + @Amount WHERE iban = @RecipientIban";
                            SqlCommand addCmd = new SqlCommand(addQuery, connection, transaction);
                            addCmd.Parameters.AddWithValue("@Amount", transferAmount);
                            addCmd.Parameters.AddWithValue("@RecipientIban", recipientIban);
                            addCmd.ExecuteNonQuery();

                            // 3. Get sender user ID
                            string getSenderIdQuery = "SELECT Id FROM perdoruesit WHERE iban = @SenderIban";
                            SqlCommand getSenderIdCmd = new SqlCommand(getSenderIdQuery, connection, transaction);
                            getSenderIdCmd.Parameters.AddWithValue("@SenderIban", senderIban);
                            int senderId = (int)getSenderIdCmd.ExecuteScalar();

                            // 4. Insert into transaction log for sender (outgoing transfer)
                            string insertSenderTransactionQuery = "INSERT INTO transaksionet (iban, tipi, shuma, iban_marresit, mesazhi, Tdata, perdoruesiID) " +
                                                   "VALUES (@SenderIban, @Tipi, @Shuma, @RecipientIban, @Mesazhi, GETDATE(), @SenderId)";
                            SqlCommand insertSenderTransactionCmd = new SqlCommand(insertSenderTransactionQuery, connection, transaction);
                            insertSenderTransactionCmd.Parameters.AddWithValue("@SenderIban", senderIban);
                            insertSenderTransactionCmd.Parameters.AddWithValue("@Tipi", "Transferim");
                            insertSenderTransactionCmd.Parameters.AddWithValue("@Shuma", transferAmount);
                            insertSenderTransactionCmd.Parameters.AddWithValue("@RecipientIban", recipientIban);
                            insertSenderTransactionCmd.Parameters.AddWithValue("@Mesazhi", userMessage);
                            insertSenderTransactionCmd.Parameters.AddWithValue("@SenderId", senderId);
                            insertSenderTransactionCmd.ExecuteNonQuery();

                            // Commit the transaction
                            transaction.Commit();

                            // Show success message in a MessageBox
                            MessageBox.Show($"Transferimi u krye me sukses! Ju keni transferuar {transferAmount} tek llogaria me IBAN: {recipientIban}");

                            // Clear the input fields
                            marresiIBAN.Text = "";
                            shuma.Text = "";
                            messagebox.Text = ""; // Clear the message box
                        }
                        catch (Exception ex)
                        {
                            // Roll back the transaction if something goes wrong
                            transaction.Rollback();
                            MessageBox.Show("Ka ndodhur një gabim gjatë transferimit: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ka ndodhur një gabim me lidhjen e databazës: " + ex.Message);
                }
            }
        }

        private void kthehu_Click(object sender, EventArgs e)
        {
            // Check if Owner is set and is a menu form
            if (this.Owner != null && this.Owner is menu)
            {
                // Show the menu form again
                this.Owner.Show();
                // Close the current transfer form
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