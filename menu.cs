using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class menu : Form
    {
        private Label labelWelcome;
        private string userEmri;
        private string userIban; // e ruan IBAN te userit

        public menu(string emri, string iban)
        {
            InitializeComponent();
            userEmri = emri;
            userIban = iban; // ruhet IBANI
            labelWelcome.Text = $"Miresevini, {emri}";
        }

        // public qe me mujt me e mar edhe pi filev tjera
        public string UserIban
        {
            get { return userIban; }
        }

        private void qkyqu_Click(object sender, EventArgs e)
        {
            dashboard qkyqu = new dashboard();
            qkyqu.Show();
            this.Hide();
        }

        private void deponim_Click(object sender, EventArgs e)
        {
            deponim deponim = new deponim();
            deponim.Owner = this; // Set the owner to pass the IBAN
            deponim.Show();
            this.Hide();
        }
    }
}