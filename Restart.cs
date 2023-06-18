using System;
using System.Windows.Forms;

namespace TestMusic
{
    public partial class Restart : Form
    {
        //internal static gameSetting form2;

        public Restart()
        {
            InitializeComponent();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form1.form1.Visible = false;
            gameSetting settingForm = new gameSetting();
            settingForm.ShowDialog();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Form1.form1.RestartGame();
            Close();
            Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1.form1.Dispose();
            this.Dispose();
            Application.Exit();
        }

        private void Restart_Load(object sender, EventArgs e)
        {
            Score.Text = "Score: " + Form1.form1.score;
        }
    }
}
