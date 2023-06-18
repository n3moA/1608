namespace TestMusic
{
    partial class Pause
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
            this.btnRestart = new System.Windows.Forms.PictureBox();
            this.btnResume = new System.Windows.Forms.PictureBox();
            this.btnMusic = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.scorePause = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.BackgroundImage = global::TestMusic.Properties.Resources.restartBtn;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.Location = new System.Drawing.Point(191, 168);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(85, 76);
            this.btnRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestart.TabIndex = 0;
            this.btnRestart.TabStop = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.Transparent;
            this.btnResume.BackgroundImage = global::TestMusic.Properties.Resources.restartBtn;
            this.btnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResume.Image = global::TestMusic.Properties.Resources.resumeBtn_removebg_preview;
            this.btnResume.Location = new System.Drawing.Point(65, 168);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 76);
            this.btnResume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnResume.TabIndex = 1;
            this.btnResume.TabStop = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.Color.Transparent;
            this.btnMusic.BackgroundImage = global::TestMusic.Properties.Resources.musicBtn_removebg_preview;
            this.btnMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusic.Location = new System.Drawing.Point(327, 168);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(75, 76);
            this.btnMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMusic.TabIndex = 3;
            this.btnMusic.TabStop = false;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::TestMusic.Properties.Resources.exitBtn;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Image = global::TestMusic.Properties.Resources.exitBtn;
            this.btnExit.Location = new System.Drawing.Point(453, 168);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 76);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // scorePause
            // 
            this.scorePause.AutoSize = true;
            this.scorePause.BackColor = System.Drawing.Color.Transparent;
            this.scorePause.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scorePause.Location = new System.Drawing.Point(230, 45);
            this.scorePause.Name = "scorePause";
            this.scorePause.Size = new System.Drawing.Size(127, 45);
            this.scorePause.TabIndex = 5;
            this.scorePause.Text = "SCORE:";
            // 
            // Pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TestMusic.Properties.Resources.moinuddin_ahmed_forest_tile_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 345);
            this.ControlBox = false;
            this.Controls.Add(this.scorePause);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnRestart);
            this.ForeColor = System.Drawing.Color.SandyBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Pause_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnRestart;
        private System.Windows.Forms.PictureBox btnResume;
        private System.Windows.Forms.PictureBox btnMusic;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label scorePause;
    }
}