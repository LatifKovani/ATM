using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
<<<<<<< HEAD
=======
using static System.Runtime.InteropServices.JavaScript.JSType;
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7

namespace atm
{
    public partial class kyqja : Form
    {
        public kyqja()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-6QQTGN8;Initial Catalog = ATM;Integrated Security=True;TrustServerCertificate=True";


        private void Kyqu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
<<<<<<< HEAD
                connection.Open();
                try
                {
=======
                try
                {
                    connection.Open();
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
                    string query = "SELECT emri, iban FROM perdoruesit WHERE iban = @Iban AND pin = @Pin";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Iban", textBox1.Text);
                        command.Parameters.AddWithValue("@Pin", textBox2.Text);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string emri = reader["emri"].ToString();
                                string iban = reader["iban"].ToString();

                                // Pass both name and IBAN to the menu form
                                menu menuForm = new menu(emri, iban);
                                menuForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Iban ose PIN i gabuar.");
<<<<<<< HEAD
                                textBox1.Clear();
                                textBox2.Clear();
=======
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
<<<<<<< HEAD
                    MessageBox.Show("Ndodhi nje gabim: " + ex.Message);
=======
                    MessageBox.Show("Ndodhi nje gabim: " + ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
<<<<<<< HEAD
        {   
            
=======
        {
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
            regjistrimi regjistrimi = new regjistrimi();
            regjistrimi.Show();
            this.Hide();
        }
    }
}