using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Collections.Generic;

namespace TestMusic
{
    public partial class Form1 : Form
    {
        internal static Form1 form1;
        public Image imagebullet, imagebird;
        string bullet_path;
        int heart = 15;
        SoundPlayer bulletSound, laserUFO;
        bool goUp, goDown, goLeft, goRight, gameOver;
        public bool music = true;
        int birdHealth = 100;
        public int ammo = 10, score;
        int index;
        public int UFOspeed = 10, speed = 10;
        Random rand = new Random();
        List<PictureBox> ufos = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            RestartGame();
            form1 = this;

            MXP.Visible = false;
        }

        public Form1(string bird, string bullet, int speed)
        {
            InitializeComponent();
            RestartGame();
            form1 = this;

            MXP.Visible = false;
            bullet_path = bullet;
            this.bullet_path = bullet;
            this.bird.Load(bird);
            this.speed = speed;
            UFOspeed = speed;
        }

        private void timeGame_Tick(object sender, EventArgs e)
        {
            if (birdHealth > 1)
            {
                healthBar.Value = birdHealth;
            }
            else
            {
                gameOver = true;
                GameOver();
            }
            lbHeart.Text = heart + "/15";
            if (heart == 0)
            {
                gameOver = true;
                GameOver();
            }
            if (goLeft == true && bird.Left > 0)
            {
                bird.Left -= speed;
            }
            if (goRight == true && bird.Right + bird.Width < this.ClientSize.Width)
            {
                bird.Left += speed;
            }
            if (goUp == true && bird.Top > 0)
            {
                bird.Top -= speed;
            }
            if (goDown == true && bird.Top + bird.Height < this.ClientSize.Height)
            {
                bird.Top += speed;
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score;
            
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Left += 25;

                    if (x.Left > 1163)
                    {
                        RemoveBullet(((PictureBox)x));
                    }
                }

                if(x is PictureBox && (string)x.Tag == "bird")
                {
                    x.Top += 3;
                }

                if (x is PictureBox && (string)x.Tag == "ufo")
                {
                    if (bird.Bounds.IntersectsWith(x.Bounds))
                    {
                        birdHealth -= 10;
                        ufos.Remove((PictureBox)x);
                        this.Controls.Remove(x);
                        MakeUFO();
                    }

                    int temp_x = x.Left;
                    int temp_y = x.Top;
                    
                    x.Left -= UFOspeed;

                    if(x.Left + x.Width <= 0)
                    {
                        heart--;
                        ufos.Remove((PictureBox)x);
                        this.Controls.Remove(x);
                        if(ufos.Count < 3)
                        {
                            MakeUFO();
                        }
                    }
                }

                if(x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (bird.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;

                    }
                }

                if (x is PictureBox && (string)x.Tag == "bulletUFO")
                {
                    x.Left -= 15;
                    if (x.Bounds.IntersectsWith(bird.Bounds))
                    {
                        birdHealth -= 5;
                        this.Controls.Remove((PictureBox)x);
                        x.Dispose();
                    }
                    if(x.Left + x.Width < 0)
                    {
                        this.Controls.Remove((PictureBox)x);
                        x.Dispose();
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "ufo")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();

                            ufos.Remove(((PictureBox)x));
                            MakeUFO();
                        }
                    }
                }
            }

            if (score > 10)
            {
                speed = 12;
                UFOspeed = 13;
            }
            if (score > 15)
            {
                speed = 14;
                UFOspeed = 15;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                bulletSound = new SoundPlayer(@"laserSound.wav");
                if(music) bulletSound.Play();
                
                makeBullet();
                if (ammo < 1)
                {
                    DropAmmo();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }

        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }

        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Transparent;
            bullet.BackgroundImageLayout = ImageLayout.Stretch;
            bullet.Left = bird.Left + bird.Width - 20;
            bullet.Top = bird.Top + bird.Height / 2;
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.Tag = "bullet";
            this.Controls.Add(bullet);
            if (bullet_path == "1")
            {
                bullet.Image = TestMusic.Properties.Resources.bullet1;
                bullet.Height = 60;
                bullet.Width = 50;
            }
            if (bullet_path == "2")
            {
                bullet.Image = TestMusic.Properties.Resources.bullet2;
                bullet.Height = 50;
                bullet.Width = 50;
            }
            if (bullet_path == "3")
            {
                bullet.Image = TestMusic.Properties.Resources.bullet3;
                bullet.Height = 48;
                bullet.Width = 58;
            }
        }

        private void TimeUFO_Tick(object sender, EventArgs e)
        {
            if (ufos.Count > 0)
            {
                makeBulletUFO_v2(ufos[1]);
                makeBulletUFO_v2(ufos[2]);
                laserUFO = new SoundPlayer(@"laserBullet.wav");
                laserUFO.Play();
            }
        }

        private void makeBulletUFO_v2(PictureBox ufo)
        {
            PictureBox bulletUFO = new PictureBox();
            bulletUFO.BackColor = Color.White;
            bulletUFO.Left = ufo.Left + ufo.Width - 20;
            bulletUFO.Top = ufo.Top + ufo.Height / 2;
            bulletUFO.Width = 25;
            bulletUFO.Height = 17;
            bulletUFO.BackColor = Color.Transparent;
            bulletUFO.SizeMode = PictureBoxSizeMode.StretchImage;
            bulletUFO.Image = TestMusic.Properties.Resources.bulletUFO;
            bulletUFO.Tag = "bulletUFO";
            this.Controls.Add(bulletUFO);
            
        }

        public void RestartGame()
        {
            foreach (PictureBox i in ufos)
            {
                this.Controls.Remove(i);
            }

            ufos.Clear();

            for (int i = 1; i <= 3; i++)
            {
                MakeUFO();
            }

            bird.Top = 303;

            foreach(Control x in Controls)
            {
                if(x is PictureBox && (string)x.Tag == "bullet")
                {
                    this.Controls.Remove((PictureBox)x);
                    ((PictureBox)x).Dispose();
                }
                if(x is PictureBox && (string)x.Tag == "ammo")
                {
                    this.Controls.Remove((PictureBox)x);
                    ((PictureBox)x).Dispose();
                }
            }

            heart = 15;
            UFOspeed = 10;
            speed = 10;
            ammo = 10;
            score = 0;
            birdHealth = 100;
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;
            
            timeGame.Start();
            TimeUFO.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timeGame.Stop();
            TimeUFO.Stop();
            Pause pauseForm = new Pause(music);
            pauseForm.ShowDialog();
        }

        public void ResumeGame()
        {
            timeGame.Start();
            TimeUFO.Start();
            this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void GameOver()
        {
            timeGame.Stop();
            TimeUFO.Stop();
            gameOver = true;
            Restart form2 = new Restart();
            form2.ShowDialog();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rand.Next(10,350);
            ammo.Top = rand.Next(60, 350);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            bird.BringToFront();
        }

        private void MakeUFO()
        {
            PictureBox ufo = new PictureBox();
            ufo.Tag = "ufo";
            ChangeUFO(ufo);
            ufo.Left = rand.Next(850, 950);
            ufo.Top = rand.Next(100, 500);
            ufo.Height = 50;
            ufo.Width = 52;
            ufo.SizeMode = PictureBoxSizeMode.StretchImage;
            ufo.BackColor = Color.Transparent;
            ufos.Add(ufo);
            this.Controls.Add(ufo);
            ufo.BringToFront();
        }

        private void ChangeUFO(PictureBox ufo)
        {
            index = rand.Next(1, 5);
            switch (index)
            {
                case 1:
                    ufo.Image = Properties.Resources.alien1;
                    break;
                case 2:
                    ufo.Image = Properties.Resources.alien2;
                    break;
                case 3:
                    ufo.Image = Properties.Resources.alien3;
                    break;
                case 4:
                    ufo.Image = Properties.Resources.alien4;
                    break;
            }
           
        }

        public void SetBird(Image birdTmp) => this.bird.Image = birdTmp;

        public void SetSpeed(int speed)
        {
            this.speed = speed;
            this.UFOspeed = speed;
        }

        public void SetBullet(Image bulletTmp) => this.imagebullet = bulletTmp;

        public void SetMusic(bool music_temp) => this.music = music_temp;
    }
}
