
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
using System.IO;

namespace test22
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        

           
        }
      
        private void startgame_Click(object sender, EventArgs e)
        {
            game gamewindow = new game();
            this.Hide();
            gamewindow.Show();
            //game texttime = new game();
            
            //texttime.stdname =int.Parse(tb1.Text);
            //texttime.ShowDialog();
        }
     
       
       

        private void help_Click(object sender, EventArgs e)
        {
            HELP helpwindow = new HELP();
            this.Hide();
            helpwindow.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && string.IsNullOrEmpty(textBox1.Text) == false)
            {
                textBox1.Enabled = false;
                game gamingwindow = new game();
                this.Hide();
                gamingwindow.Show();
               
                
            }
          

        }



    }
}
