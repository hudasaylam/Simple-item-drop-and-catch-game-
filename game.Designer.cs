//HUDA SAILAM B211200574
namespace test22
{
    partial class game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoretxt = new System.Windows.Forms.Label();
            this.gametime = new System.Windows.Forms.Timer(this.components);
            this.secondsleft = new System.Windows.Forms.Label();
            this.cupcoffee = new System.Windows.Forms.Label();
            this.kalancoffee = new System.Windows.Forms.Label();
            this.gameovertxt = new System.Windows.Forms.Label();
            this.rstbtn = new System.Windows.Forms.Button();
            this.won = new System.Windows.Forms.Label();
            this.pausedtxt = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gizli = new System.Windows.Forms.PictureBox();
            this.coffee = new System.Windows.Forms.PictureBox();
            this.milk = new System.Windows.Forms.PictureBox();
            this.water = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gizli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoretxt
            // 
            this.scoretxt.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.scoretxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoretxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scoretxt.Font = new System.Drawing.Font("Rockwell Nova", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretxt.ForeColor = System.Drawing.Color.Black;
            this.scoretxt.Location = new System.Drawing.Point(21, 13);
            this.scoretxt.Name = "scoretxt";
            this.scoretxt.Size = new System.Drawing.Size(199, 49);
            this.scoretxt.TabIndex = 1;
            this.scoretxt.Text = "score :  0";
            // 
            // gametime
            // 
            this.gametime.Interval = 1000;
            this.gametime.Tick += new System.EventHandler(this.gametime_Tick);
            // 
            // secondsleft
            // 
            this.secondsleft.BackColor = System.Drawing.Color.SlateBlue;
            this.secondsleft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondsleft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondsleft.Font = new System.Drawing.Font("Rockwell Nova", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsleft.Location = new System.Drawing.Point(21, 62);
            this.secondsleft.Name = "secondsleft";
            this.secondsleft.Size = new System.Drawing.Size(199, 31);
            this.secondsleft.TabIndex = 5;
            this.secondsleft.Text = "      sec  left";
            // 
            // cupcoffee
            // 
            this.cupcoffee.BackColor = System.Drawing.Color.MediumPurple;
            this.cupcoffee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cupcoffee.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cupcoffee.Location = new System.Drawing.Point(21, 93);
            this.cupcoffee.Name = "cupcoffee";
            this.cupcoffee.Size = new System.Drawing.Size(199, 60);
            this.cupcoffee.TabIndex = 8;
            this.cupcoffee.Text = "0  total done";
            // 
            // kalancoffee
            // 
            this.kalancoffee.BackColor = System.Drawing.Color.MediumOrchid;
            this.kalancoffee.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kalancoffee.Location = new System.Drawing.Point(21, 153);
            this.kalancoffee.Name = "kalancoffee";
            this.kalancoffee.Size = new System.Drawing.Size(199, 58);
            this.kalancoffee.TabIndex = 9;
            this.kalancoffee.Text = "8 total left";
            // 
            // gameovertxt
            // 
            this.gameovertxt.BackColor = System.Drawing.Color.Transparent;
            this.gameovertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameovertxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gameovertxt.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameovertxt.ForeColor = System.Drawing.Color.Red;
            this.gameovertxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gameovertxt.Location = new System.Drawing.Point(5, 229);
            this.gameovertxt.Name = "gameovertxt";
            this.gameovertxt.Size = new System.Drawing.Size(1335, 395);
            this.gameovertxt.TabIndex = 10;
            this.gameovertxt.Text = "GAME OVER\r\n\r\n\r\n";
            this.gameovertxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameovertxt.Visible = false;
            // 
            // rstbtn
            // 
            this.rstbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rstbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rstbtn.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rstbtn.ForeColor = System.Drawing.Color.Red;
            this.rstbtn.Location = new System.Drawing.Point(1073, 613);
            this.rstbtn.Name = "rstbtn";
            this.rstbtn.Size = new System.Drawing.Size(219, 58);
            this.rstbtn.TabIndex = 11;
            this.rstbtn.Text = "restart";
            this.rstbtn.UseVisualStyleBackColor = false;
            this.rstbtn.Visible = false;
            this.rstbtn.Click += new System.EventHandler(this.rstbtn_Click);
            // 
            // won
            // 
            this.won.BackColor = System.Drawing.Color.Silver;
            this.won.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.won.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.won.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.won.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.won.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.won.Location = new System.Drawing.Point(5, 184);
            this.won.Name = "won";
            this.won.Size = new System.Drawing.Size(1366, 395);
            this.won.TabIndex = 15;
            this.won.Text = "kazandın";
            this.won.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.won.Visible = false;
            // 
            // pausedtxt
            // 
            this.pausedtxt.BackColor = System.Drawing.Color.LightGray;
            this.pausedtxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pausedtxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pausedtxt.Font = new System.Drawing.Font("Cambria Math", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausedtxt.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.pausedtxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pausedtxt.Location = new System.Drawing.Point(236, 182);
            this.pausedtxt.Name = "pausedtxt";
            this.pausedtxt.Size = new System.Drawing.Size(909, 442);
            this.pausedtxt.TabIndex = 16;
            this.pausedtxt.Text = "oyuna devam etmek için D\r\ntuşuna basınız";
            this.pausedtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pausedtxt.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 40;
            this.timer2.Tag = "10000";
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // gizli
            // 
            this.gizli.BackColor = System.Drawing.Color.Transparent;
            this.gizli.Image = global::test22.Properties.Resources.icons8_chest_24;
            this.gizli.Location = new System.Drawing.Point(1035, 11);
            this.gizli.Name = "gizli";
            this.gizli.Size = new System.Drawing.Size(79, 59);
            this.gizli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gizli.TabIndex = 17;
            this.gizli.TabStop = false;
            this.gizli.Tag = "kah";
            // 
            // coffee
            // 
            this.coffee.BackColor = System.Drawing.Color.Transparent;
            this.coffee.Image = global::test22.Properties.Resources.Coffee_bean_removebg_preview;
            this.coffee.Location = new System.Drawing.Point(617, 13);
            this.coffee.Name = "coffee";
            this.coffee.Size = new System.Drawing.Size(66, 58);
            this.coffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coffee.TabIndex = 4;
            this.coffee.TabStop = false;
            this.coffee.Tag = "kah";
            // 
            // milk
            // 
            this.milk.BackColor = System.Drawing.Color.Transparent;
            this.milk.Image = global::test22.Properties.Resources.Milk_Bottle_removebg_preview;
            this.milk.Location = new System.Drawing.Point(327, 13);
            this.milk.Name = "milk";
            this.milk.Size = new System.Drawing.Size(101, 68);
            this.milk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.milk.TabIndex = 3;
            this.milk.TabStop = false;
            this.milk.Tag = "kah";
            // 
            // water
            // 
            this.water.BackColor = System.Drawing.Color.Transparent;
            this.water.Image = global::test22.Properties.Resources._15_Water_and_Droplet_Icons_removebg_preview;
            this.water.Location = new System.Drawing.Point(909, 12);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(72, 58);
            this.water.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.water.TabIndex = 2;
            this.water.TabStop = false;
            this.water.Tag = "kah";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::test22.Properties.Resources.R;
            this.player.Image = global::test22.Properties.Resources.Free_Image_on_Pixabay___Silhouette__Waitress__Waiter;
            this.player.Location = new System.Drawing.Point(592, 552);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(131, 151);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::test22.Properties.Resources.Coffee_bean_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(1298, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::test22.Properties.Resources.Milk_Bottle_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(1298, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::test22.Properties.Resources._15_Water_and_Droplet_Icons_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(1298, 87);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1261, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1261, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1261, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(226, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 123);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "en yüksek 5 skorlar :";
            this.textBox1.Visible = false;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 702);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gizli);
            this.Controls.Add(this.pausedtxt);
            this.Controls.Add(this.won);
            this.Controls.Add(this.rstbtn);
            this.Controls.Add(this.kalancoffee);
            this.Controls.Add(this.cupcoffee);
            this.Controls.Add(this.secondsleft);
            this.Controls.Add(this.coffee);
            this.Controls.Add(this.milk);
            this.Controls.Add(this.water);
            this.Controls.Add(this.player);
            this.Controls.Add(this.scoretxt);
            this.Controls.Add(this.gameovertxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gizli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoretxt;
        private System.Windows.Forms.PictureBox water;
        private System.Windows.Forms.PictureBox milk;
        private System.Windows.Forms.PictureBox coffee;
        private System.Windows.Forms.Timer gametime;
        private System.Windows.Forms.Label secondsleft;
        private System.Windows.Forms.Label cupcoffee;
        private System.Windows.Forms.Label kalancoffee;
        private System.Windows.Forms.Label gameovertxt;
        private System.Windows.Forms.Button rstbtn;
        private System.Windows.Forms.Label won;
        private System.Windows.Forms.Label pausedtxt;
        private System.Windows.Forms.PictureBox gizli;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}