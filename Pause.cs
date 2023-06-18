using System;
using System.Windows.Forms;

namespace TestMusic
{
    public partial class Pause : Form
    {
        bool music;
        public Pause()
        {
            InitializeComponent();
        }

        public Pause(bool musicTmp)
        {
            InitializeComponent();
            music = musicTmp;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Form1.form1.Visible = false;
            Menu menu = new Menu(); 
            this.Visible = false;
            menu.Show();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            Form1.form1.ResumeGame();
            this.Close();
            this.Dispose();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1.form1.Dispose();
            this.Close();
            this.Dispose();
            System.Windows.Forms.Application.Exit();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            if (music) {
                btnMusic.BackgroundImage = TestMusic.Properties.Resources.Stop_musicBtn_removebg_preview;
                music = false;
            }
            else
            {
                btnMusic.BackgroundImage = TestMusic.Properties.Resources.musicBtn_removebg_preview;
                music = true;
            }
            Form1.form1.SetMusic(music);
        }

        private void Pause_Load(object sender, EventArgs e)
        {
            scorePause.Text = "Score: " + Form1.form1.score;
            if (Form1.form1.music)
            {
                btnMusic.BackgroundImage = TestMusic.Properties.Resources.musicBtn_removebg_preview;
            }
            else
            {
                btnMusic.BackgroundImage = TestMusic.Properties.Resources.Stop_musicBtn_removebg_preview;
            }
        }

    }
}
