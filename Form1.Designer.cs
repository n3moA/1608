namespace TestMusic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bird = new System.Windows.Forms.PictureBox();
            this.timeGame = new System.Windows.Forms.Timer(this.components);
            this.TimeUFO = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.MXP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.lbHeart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(60, 303);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(121, 110);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 5;
            this.bird.TabStop = false;
            this.bird.Tag = "bird";
            // 
            // timeGame
            // 
            this.timeGame.Enabled = true;
            this.timeGame.Interval = 20;
            this.timeGame.Tick += new System.EventHandler(this.timeGame_Tick);
            // 
            // TimeUFO
            // 
            this.TimeUFO.Enabled = true;
            this.TimeUFO.Interval = 3000;
            this.TimeUFO.Tick += new System.EventHandler(this.TimeUFO_Tick);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.DarkGray;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Maroon;
            this.txtScore.Location = new System.Drawing.Point(517, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(79, 29);
            this.txtScore.TabIndex = 7;
            this.txtScore.Text = "Kill: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(781, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(883, 9);
            this.healthBar.Margin = new System.Windows.Forms.Padding(4);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(249, 28);
            this.healthBar.TabIndex = 9;
            this.healthBar.Value = 100;
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.BackColor = System.Drawing.Color.Transparent;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.Maroon;
            this.txtAmmo.Location = new System.Drawing.Point(13, 9);
            this.txtAmmo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(114, 29);
            this.txtAmmo.TabIndex = 10;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // MXP
            // 
            this.MXP.Enabled = true;
            this.MXP.Location = new System.Drawing.Point(147, 673);
            this.MXP.Name = "MXP";
            this.MXP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MXP.OcxState")));
            this.MXP.Size = new System.Drawing.Size(253, 48);
            this.MXP.TabIndex = 4;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = global::TestMusic.Properties.Resources.pauseBtn_removebg_preview;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.Location = new System.Drawing.Point(12, 673);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(55, 52);
            this.btnPause.TabIndex = 11;
            this.btnPause.TabStop = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lbHeart
            // 
            this.lbHeart.AutoSize = true;
            this.lbHeart.BackColor = System.Drawing.Color.DarkGray;
            this.lbHeart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeart.ForeColor = System.Drawing.Color.Maroon;
            this.lbHeart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeart.Location = new System.Drawing.Point(309, 9);
            this.lbHeart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHeart.Name = "lbHeart";
            this.lbHeart.Size = new System.Drawing.Size(77, 29);
            this.lbHeart.TabIndex = 12;
            this.lbHeart.Text = "15/15";
            this.lbHeart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TestMusic.Properties.Resources.heart;
            this.pictureBox1.Location = new System.Drawing.Point(271, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "birdHeart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 733);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbHeart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.MXP);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox bird;
        
        private System.Windows.Forms.Timer timeGame;
        private System.Windows.Forms.Timer TimeUFO;
        //private System.Windows.Forms.Label ammo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.PictureBox btnPause;
        public AxWMPLib.AxWindowsMediaPlayer MXP;
        private System.Windows.Forms.Label lbHeart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

