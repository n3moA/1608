using System.Windows.Forms;

namespace TestMusic
{
    partial class gameSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameSetting));
            this.chooseBird = new System.Windows.Forms.Label();
            this.bird1 = new System.Windows.Forms.RadioButton();
            this.bird2 = new System.Windows.Forms.RadioButton();
            this.bird3 = new System.Windows.Forms.RadioButton();
            this.chooseLevel = new System.Windows.Forms.Label();
            this.HARD = new System.Windows.Forms.RadioButton();
            this.MIDDLE = new System.Windows.Forms.RadioButton();
            this.EASY = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseBird
            // 
            this.chooseBird.AutoSize = true;
            this.chooseBird.BackColor = System.Drawing.Color.Transparent;
            this.chooseBird.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseBird.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chooseBird.Location = new System.Drawing.Point(3, 42);
            this.chooseBird.Name = "chooseBird";
            this.chooseBird.Size = new System.Drawing.Size(230, 40);
            this.chooseBird.TabIndex = 3;
            this.chooseBird.Text = "CHOOSE BIRD";
            // 
            // bird1
            // 
            this.bird1.Appearance = System.Windows.Forms.Appearance.Button;
            this.bird1.BackColor = System.Drawing.Color.Transparent;
            this.bird1.BackgroundImage = global::TestMusic.Properties.Resources.bird1;
            this.bird1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bird1.Checked = true;
            this.bird1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bird1.Location = new System.Drawing.Point(300, 7);
            this.bird1.Name = "bird1";
            this.bird1.Size = new System.Drawing.Size(140, 125);
            this.bird1.TabIndex = 9;
            this.bird1.TabStop = true;
            this.bird1.UseVisualStyleBackColor = false;
            // 
            // bird2
            // 
            this.bird2.Appearance = System.Windows.Forms.Appearance.Button;
            this.bird2.BackColor = System.Drawing.Color.Transparent;
            this.bird2.BackgroundImage = global::TestMusic.Properties.Resources.bird2;
            this.bird2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bird2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bird2.Location = new System.Drawing.Point(481, 7);
            this.bird2.Name = "bird2";
            this.bird2.Size = new System.Drawing.Size(151, 125);
            this.bird2.TabIndex = 10;
            this.bird2.UseVisualStyleBackColor = false;
            // 
            // bird3
            // 
            this.bird3.Appearance = System.Windows.Forms.Appearance.Button;
            this.bird3.BackColor = System.Drawing.Color.Transparent;
            this.bird3.BackgroundImage = global::TestMusic.Properties.Resources.bird3;
            this.bird3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bird3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bird3.Location = new System.Drawing.Point(662, 7);
            this.bird3.Name = "bird3";
            this.bird3.Size = new System.Drawing.Size(141, 125);
            this.bird3.TabIndex = 11;
            this.bird3.UseVisualStyleBackColor = false;
            // 
            // chooseLevel
            // 
            this.chooseLevel.AutoSize = true;
            this.chooseLevel.BackColor = System.Drawing.Color.Transparent;
            this.chooseLevel.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLevel.ForeColor = System.Drawing.Color.Maroon;
            this.chooseLevel.Location = new System.Drawing.Point(3, 40);
            this.chooseLevel.Name = "chooseLevel";
            this.chooseLevel.Size = new System.Drawing.Size(254, 40);
            this.chooseLevel.TabIndex = 12;
            this.chooseLevel.Text = "CHOOSE LEVEL";
            // 
            // HARD
            // 
            this.HARD.Appearance = System.Windows.Forms.Appearance.Button;
            this.HARD.BackColor = System.Drawing.Color.Teal;
            this.HARD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HARD.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HARD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HARD.Location = new System.Drawing.Point(637, 18);
            this.HARD.Name = "HARD";
            this.HARD.Size = new System.Drawing.Size(156, 91);
            this.HARD.TabIndex = 15;
            this.HARD.Text = "HARD";
            this.HARD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HARD.UseVisualStyleBackColor = false;
            // 
            // MIDDLE
            // 
            this.MIDDLE.Appearance = System.Windows.Forms.Appearance.Button;
            this.MIDDLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MIDDLE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MIDDLE.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MIDDLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MIDDLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIDDLE.Location = new System.Drawing.Point(463, 18);
            this.MIDDLE.Name = "MIDDLE";
            this.MIDDLE.Size = new System.Drawing.Size(150, 91);
            this.MIDDLE.TabIndex = 14;
            this.MIDDLE.Text = "MIDDLE";
            this.MIDDLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MIDDLE.UseVisualStyleBackColor = false;
            // 
            // EASY
            // 
            this.EASY.Appearance = System.Windows.Forms.Appearance.Button;
            this.EASY.BackColor = System.Drawing.Color.LightSeaGreen;
            this.EASY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EASY.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EASY.Checked = true;
            this.EASY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EASY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EASY.Location = new System.Drawing.Point(299, 18);
            this.EASY.Name = "EASY";
            this.EASY.Size = new System.Drawing.Size(140, 91);
            this.EASY.TabIndex = 13;
            this.EASY.TabStop = true;
            this.EASY.Text = "EASY";
            this.EASY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EASY.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.chooseLevel);
            this.panel1.Controls.Add(this.HARD);
            this.panel1.Controls.Add(this.EASY);
            this.panel1.Controls.Add(this.MIDDLE);
            this.panel1.Location = new System.Drawing.Point(164, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 128);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.chooseBird);
            this.panel2.Controls.Add(this.bird1);
            this.panel2.Controls.Add(this.bird3);
            this.panel2.Controls.Add(this.bird2);
            this.panel2.Location = new System.Drawing.Point(164, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 135);
            this.panel2.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::TestMusic.Properties.Resources.btn_back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(1102, 625);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 70);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 18;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Image = global::TestMusic.Properties.Resources.btn_play;
            this.btnPlay.Location = new System.Drawing.Point(970, 625);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(117, 70);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 19;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // gameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 698);
            this.ControlBox = false;
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "gameSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gameSetting_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label chooseBird;
        private RadioButton bird1;
        private RadioButton bird2;
        private RadioButton bird3;
        private Label chooseLevel;
        private RadioButton HARD;
        private RadioButton MIDDLE;
        private RadioButton EASY;
        private Panel panel1;
        private Panel panel2;
        private PictureBox btnBack;
        private PictureBox btnPlay;
    }
}