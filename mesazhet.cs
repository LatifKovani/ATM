using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace atm
{
    public partial class mesazhet : Form
    {
        private string connectionString = "Data Source=DESKTOP-6QQTGN8;Initial Catalog=ATM;Integrated Security=True;TrustServerCertificate=True";
        private string currentUserIban;

        public mesazhet(string userIban)
        {
            InitializeComponent();
            currentUserIban = userIban;
            this.Load += Mesazhet_Load;
            requestsDataGridView.CellContentClick += RequestsDataGridView_CellContentClick;
            btnRefresh.Click += BtnRefresh_Click;
            btnReturn.Click += BtnReturn_Click;
        }

        private void Mesazhet_Load(object sender, EventArgs e)
        {
            LoadRequests();
            StyleGridButtons();
        }

        private void LoadRequests()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                            k.Id,
                            k.iban AS 'Nga',
                            k.shuma AS 'Shuma',
                            k.mesazhi AS 'Mesazhi',
                            FORMAT(k.data_kerkeses, 'dd/MM/yyyy HH:mm') AS 'Data',
                            k.statusi AS 'Statusi'
                            FROM kerkesat_para k
                            WHERE k.iban_marresit = @UserIban
                            ORDER BY k.data_kerkeses DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@UserIban", currentUserIban);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    requestsDataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë ngarkimit: {ex.Message}");
            }
        }

        private void StyleGridButtons()
        {
            foreach (DataGridViewRow row in requestsDataGridView.Rows)
            {
                row.Cells["colApprove"].Style.BackColor = Color.FromArgb(76, 175, 80);
                row.Cells["colApprove"].Style.ForeColor = Color.White;
                row.Cells["colDecline"].Style.BackColor = Color.FromArgb(244, 67, 54);
                row.Cells["colDecline"].Style.ForeColor = Color.White;
            }
        }

        private void RequestsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = (DataGridView)sender;
            int requestId = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["colId"].Value);
            string status = grid.Rows[e.RowIndex].Cells["colStatusi"].Value?.ToString() ?? "";

            if (grid.Columns[e.ColumnIndex].Name == "colApprove")
            {
                if (status != "PENDING")
                {
                    MessageBox.Show("Mund të veproni vetëm në kërkesa të papërgjigjura!", "Kujdes");
                    return;
                }

                if (MessageBox.Show("Aprovo kërkesën?", "Konfirmim", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ApproveRequest(requestId);
                }
            }
            else if (grid.Columns[e.ColumnIndex].Name == "colDecline")
            {
                if (status != "PENDING")
                {
                    MessageBox.Show("Mund të veproni vetëm në kërkesa të papërgjigjura!", "Kujdes");
                    return;
                }

                if (MessageBox.Show("Refuzo kërkesën?", "Konfirmim", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeclineRequest(requestId);
                }
            }
        }

        private void ApproveRequest(int requestId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        string getQuery = @"SELECT iban, shuma 
                                          FROM kerkesat_para 
                                          WHERE Id = @Id AND statusi = 'PENDING'";
                        SqlCommand getCmd = new SqlCommand(getQuery, connection, transaction);
                        getCmd.Parameters.AddWithValue("@Id", requestId);

                        using (SqlDataReader reader = getCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string requesterIban = reader["iban"].ToString();
                                decimal amount = Convert.ToDecimal(reader["shuma"]);
                                reader.Close();

                                decimal balance = GetAccountBalance(currentUserIban, connection, transaction);
                                if (balance < amount)
                                {
                                    throw new Exception("Nuk keni fonde të mjaftueshme!");
                                }

                                TransferMoney(currentUserIban, requesterIban, amount, connection, transaction);
                                UpdateRequestStatus(requestId, "APPROVED", connection, transaction);

                                transaction.Commit();
                                MessageBox.Show("Kërkesa u aprovua me sukses!");
                                LoadRequests();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Gabim gjatë aprovimit: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeclineRequest(int requestId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE kerkesat_para 
                                   SET statusi = 'REJECTED' 
                                   WHERE Id = @Id AND statusi = 'PENDING'";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", requestId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kërkesa u refuzua!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRequests();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë refuzimit: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetAccountBalance(string iban, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "SELECT bilanci FROM perdoruesit WHERE iban = @iban";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@iban", iban);
            return Convert.ToDecimal(command.ExecuteScalar());
        }

        private void TransferMoney(string fromIban, string toIban, decimal amount, SqlConnection connection, SqlTransaction transaction)
        {
            string deductQuery = "UPDATE perdoruesit SET bilanci = bilanci - @amount WHERE iban = @iban";
            SqlCommand deductCmd = new SqlCommand(deductQuery, connection, transaction);
            deductCmd.Parameters.AddWithValue("@amount", amount);
            deductCmd.Parameters.AddWithValue("@iban", fromIban);
            deductCmd.ExecuteNonQuery();

            string addQuery = "UPDATE perdoruesit SET bilanci = bilanci + @amount WHERE iban = @iban";
            SqlCommand addCmd = new SqlCommand(addQuery, connection, transaction);
            addCmd.Parameters.AddWithValue("@amount", amount);
            addCmd.Parameters.AddWithValue("@iban", toIban);
            addCmd.ExecuteNonQuery();
        }

        private void UpdateRequestStatus(int requestId, string status, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "UPDATE kerkesat_para SET statusi = @status WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@Id", requestId);
            command.ExecuteNonQuery();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (this.Owner != null && this.Owner is menu)
            {
                this.Owner.Show();
                this.Close();
            }
            else
            {
                menu menuForm = new menu("User", "");
                menuForm.Show();
                this.Close();
            }
        }
    }
}