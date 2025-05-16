using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< HEAD
using System.Drawing.Drawing2D;
=======
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class dashboard : Form
    {
<<<<<<< HEAD

        public dashboard()
        {
            InitializeComponent();
           
=======
        public dashboard()
        {
            InitializeComponent();
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
        }

        private void button1_Click(object sender, EventArgs e)
        {
            regjistrimi regjistrimi = new regjistrimi();
            regjistrimi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kyqja kyqja = new kyqja();
            kyqja.Show();
            this.Hide();
        }
    }
}
