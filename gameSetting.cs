using System;
using System.Windows.Forms;

namespace TestMusic
{
    public partial class gameSetting : Form
    {
        public gameSetting()
        {
            InitializeComponent();
        }

        private void gameSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string bird, bullet = "";
            int speed;
            if (bird1.Checked)
            {
                bird = "F:\\VisualStudio\\KTPMCPlusPlus\\TestMusic\\TestMusic\\Resources\\ezgif.com-crop (1).gif";
                bullet += 1;
            }
            else if (bird2.Checked)
            {
                bird = "F:\\VisualStudio\\KTPMCPlusPlus\\TestMusic\\TestMusic\\Resources\\ezgif.com-gif-maker.gif";
                bullet += 2;
            }
            else
            {
                bird = "F:\\VisualStudio\\KTPMCPlusPlus\\TestMusic\\TestMusic\\Resources\\phoenix-pixel-art-19x0p0sly95iicb4.gif";
                bullet += 3;
            }

            if (EASY.Checked)
            {
                speed = 10;
            }
            else if (MIDDLE.Checked)
            {
                speed = 13;
            }
            else
            {
                speed = 17;
            }

            this.Visible = false;

            Form1 form1 = new Form1(bird, bullet, speed);
            form1.ShowDialog();
        }

    }
}
