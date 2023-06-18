using System;
using System.Windows.Forms;

namespace TestMusic
{
    public partial class Menu : Form
    {
        internal static Menu menu1;

        public Menu()
        {
            InitializeComponent();
            menu1 = this;
        }

       
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
        private void btn_start_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1("F:\\VisualStudio\\KTPMCPlusPlus\\TestMusic\\TestMusic\\Resources\\ezgif.com-crop (1).gif", "1", 10);
            this.Visible = false;
            f.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            gameSetting setting = new gameSetting();
            this.Visible = false;
            setting.Show();
        }

        public void setVisible(bool visi)
        {
            this.Visible = visi;
        }
    }
}
