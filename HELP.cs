
//HUDA SAILAM B211200574
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test22
{
    public partial class HELP : Form
    {
        public HELP()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainpage = new Form1();
            this.Hide();
            mainpage.Show();
         
        }

        private void HELP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HELP gamingwindow2 = new HELP();
                this.Hide();
                gamingwindow2.Show();
            }
        }
    }
}
