//HUDA SAILAM B211200574
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace test22
{

    public partial class game : Form
    {

        bool collected1, collected2, collected3;

        int y;
        Random gizlikutu = new Random();
        //public int stdname { get; set; }

        int toplamwater, toplamcoffee, toplammilk = 0;
        string oku;
        int seconds;
        bool goleft, goright;
        int playerspeed = 12;
        int compspeed;
        int score;
       
        int coffeecuptoplam = 0;

        Random rnd = new Random();
        Random rnd2 = new Random();
        private void score5()
        {
            string dosyaadi = "score.text";
            string dosyayolu = @"C:\Users\Hp\source\repos\test22\test22\bin\Debug";
            string yol = Path.Combine(dosyayolu, dosyaadi);
            int[] skor1 = new int[5];

            int B;

         
            string[] skorsayma = File.ReadAllLines(yol);
            
            for (int i = 0; i < 5; i++)
            {

                skor1[i] = Convert.ToInt32(skor1[i]);

            }
            Array.Sort(skor1);
            Array.Reverse(skor1);
            for (int i = 0; i < 5; i++)
            {
                if (skor1[i] < score)
                {
                    if (i == 4)
                    {
                        skor1[i] = score;


                    }
                    B = skor1[i];
                    skor1[i] = score;
                    skor1[4] = B;
                    break;


                }



            }


            Array.Sort(skor1);
            Array.Reverse(skor1);
            for (int i = 0; i < 5; i++)
            {


                skorsayma[i] = Convert.ToString(skor1[i]);

                File.WriteAllLines(yol, skorsayma);


              oku = File.ReadAllText(yol);

            }
         
            textBox1.Visible = true;
          textBox1.Text = "en iyi 5 skor:  " + oku;
        }


        private void rstbtn_Click(object sender, EventArgs e)
        {
            Form1 re = new Form1();
            re.Show();
            this.Hide();
        }



        public game()
        {
            InitializeComponent();
            resetGame();
        }

        private void game_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            gizli.Top += compspeed;


           
        
            
         


        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            scoretxt.Text = scoretxt.Text + score.ToString();

            coffee.Top += compspeed;
            milk.Top += compspeed;
            water.Top += compspeed;




            y =gizlikutu.Next(0, 2);



            if (goleft == true)
            {
                if (player.Location.X > 12)
                {
                    player.Left -= playerspeed;
                }

            }


            if (goright == true)
            {
                if (player.Location.X < 1123)
                {

                    player.Left += playerspeed;
                }
            }




           



            


            foreach (Control X in this.Controls)
            {
               

                if (X is PictureBox && X.Tag == "kah")
                {


                    while (X.Top + X.Height > this.ClientSize.Height)
                    {
                        X.Left = rnd.Next(250, this.ClientSize.Width - X.Width);

                        X.Top = rnd.Next(0, 670) * -1;

                        X.Top += compspeed;
                    }



                    while (X.Tag == "kah" && player.Bounds.IntersectsWith(water.Bounds))
                    {
                        score += 1;
                        water.Top = -550;


                        water.Left = rnd.Next(300, this.ClientSize.Width - water.Width);


                        water.Top = rnd.Next(0, 670) * -1;

                        water.Top += compspeed;
                        toplamwater++;
                        label1.Text = toplamwater.ToString();
                        if (toplamwater >= 1 && toplamwater != 0)
                        {
                            collected3 = true;


                        }

                    }


                    while (X.Tag == "kah" && player.Bounds.IntersectsWith(milk.Bounds))
                    {

                        milk.Top = -500;


                        milk.Left = rnd2.Next(213, this.ClientSize.Width - milk.Width);
                        milk.Top = rnd2.Next(0, 670) * -1;
                        milk.Top += compspeed;
                        score += 2;
                        toplammilk++;
                        label2.Text = toplammilk.ToString();
                        if (toplammilk % 2 == 0 && toplammilk != 0)
                        {
                            collected2 = true;


                        }
                    }


                    while (X.Tag == "kah" && player.Bounds.IntersectsWith(coffee.Bounds)) {

                        score += 3;

                        coffee.Top = -600;
                        coffee.Left = rnd2.Next(213, this.ClientSize.Width - coffee.Width);
                        coffee.Top = rnd2.Next(0, 670) * -1;
                        coffee.Top += compspeed;
                        toplamcoffee++;
                            label3.Text = toplamcoffee.ToString();
                        if (toplamcoffee % 3 == 0 && toplamcoffee != 0)
                        {
                            collected1 = true;


                        }

                    }

                    while (X.Tag == "kah" && player.Bounds.IntersectsWith(gizli.Bounds))
                    {


                        X.Top = -1000;
                    
                        if (y== 1)
                        {
                            score += 3;
                        }
                        else
                        {

                            score -= 3;
                        }
                  


                    }



                    if (collected1 == true && collected2 == true && collected3 == true)
                    {
                        coffeecuptoplam++;
                        collected3 = false;
                        collected2 = false;
                        collected1 = false;
                        cupcoffee.Text = coffeecuptoplam.ToString() + "  total collected";
                        kalancoffee.Text = (8 - coffeecuptoplam).ToString() + "  total left ";

                    }



                }
                scoretxt.Text = "score: " + score.ToString();

            }

        }

       

        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;


            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;

            }
            if (e.KeyCode == Keys.P)
            {
                timer1.Stop();
                timer2.Stop();
                gametime.Stop();
                pausedtxt.Visible = true;

            }
            if (e.KeyCode == Keys.D)
            {
                timer2.Start();
                timer1.Start();
                gametime.Start();
                pausedtxt.Visible = false;
            }
        }

        private void game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;


            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;

            }



        }
//        private void bitti() {
//            if (won.Visible==true || gameovertxt.Visible==true) {
//                score5();
            
            
//            }
//}



        


        private void resetGame()
        {
            timer1.Start();
            gametime.Start();
            timer2.Start();
            rstbtn.Visible = false;
            gameovertxt.Visible = false;
            won.Visible = false;

           
            coffeecuptoplam = 0;
            kalancoffee.Text = "8 total left";
            compspeed = 6;

            do
            {
                coffee.Left = rnd.Next(23, this.ClientSize.Width - coffee.Width);
                water.Left = rnd.Next(23, this.ClientSize.Width - water.Width);
                milk.Left = rnd.Next(23, this.ClientSize.Width - milk.Width);
                coffee.Top = rnd.Next(0, 670) * -1;
                water.Top = rnd.Next(0, 670) * -1;
                milk.Top = rnd.Next(0, 670) * -1;
                gizli.Left = rnd.Next(23, this.ClientSize.Width - gizli.Width);
                gizli.Top = rnd.Next(0, 670) * -1;
                if (seconds % 10 == 0 && seconds<120)
                {

                    compspeed += 5;

                }


            } while (seconds > 0);
            seconds =120;
            score = 0;
           

          
           

           

        }


        private void gametime_Tick(object sender, EventArgs e)
                {
            
                    secondsleft.Text = seconds-- + "    sec left";
                    if (seconds == 0 && (8 - coffeecuptoplam) > 0)
                    {
                        gametime.Stop();
                        timer1.Stop();
                        gameovertxt.Visible = true;
                        rstbtn.Visible = true;
                score5();
            }


                    if ((8 - coffeecuptoplam) == 0)
                    {

                        kalancoffee.Text = "0 coffee left";

                        timer1.Stop();
                        gametime.Stop();
                        won.Visible = true;
                score5();
                        rstbtn.Visible = true;


                    }

                


            }
        }
    }
    

