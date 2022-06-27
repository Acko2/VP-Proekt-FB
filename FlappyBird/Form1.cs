using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int g = 8;
        int force;
        int speed = 4;
        int score = 0;
        static Random tmp = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStart.Visible = true;
            Score.Visible = false;
            pbEndCard.Visible = false;
            pbGameOver.Visible = false;
            lblScore.Visible = false;
            lblRestart.Visible = false;
            firstPipes();
        }
        //timer za sozdavanje na cevki
        private void pipe_tick(object sender, EventArgs e)
        {
            mPipes();
        }
        //timer za igrata
        private void game_tick(object sender, EventArgs e)
        {
            //dvizenje na cevkite vo levo
            foreach(Control i in this.Controls)
            {
                if(i is PictureBox && i.Tag == "topP")
                {
                    i.Left -= speed;
                    //brisenje na cevki
                    if(((PictureBox)i).Left < this.Width - 950)
                    {
                        this.Controls.Remove(i);
                    }
                    
                    //proveruva dali pticata ja udira vo gornata cevka
                    if (i.Bounds.IntersectsWith(flappyBird.Bounds))
                    {
                        gameEnd();
                    }
                }
            }
            //dvizenje na cevkite vo levo
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "botP")
                {
                    j.Left -= speed;
                    //brisenje na cevki
                    if (((PictureBox)j).Left < this.Width - 950)
                    {
                        this.Controls.Remove(j);
                    }
                    //proveruva dali pticata udira vo dolnata cevka
                    if (j.Bounds.IntersectsWith(flappyBird.Bounds))
                    {
                        gameEnd();
                    }

                }
            }
            //dvizenje na transparenten picturebox za poeni
            foreach(Control k in this.Controls)
            {
                if(k is PictureBox && k.Tag == "pointP")
                {
                    k.Left -= speed;
                    if (k.Bounds.IntersectsWith(flappyBird.Bounds))
                    {
                        score++;
                        this.Controls.Remove(k);
                        Speed_Increase(score);
                    }

                }
            }
            //proveruva dali pticata udira vo zemjata
            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                gameEnd();
            }
            //ogranicuvanje na preletuvanje nad formata
            if(flappyBird.Top < this.Height - 615)
            {
                flappyBird.Location = new Point(143, 8);
            }

            //skokanje na pticata
            flappyBird.Top -= force;
            if(force > -8)
            {
                force -= 1;
            }
            else
            {
                force = -8;
            }
            Score.Text = score.ToString();
        }
        //pravenje cevki
        public void mPipes()
        {
            PictureBox pipeTop = new PictureBox();
            PictureBox pipeBottom = new PictureBox();
            PictureBox points = new PictureBox();
            pipeTop.Image = Properties.Resources.pipedown;
            pipeBottom.Image = Properties.Resources.pipe;
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.Size = new Size(100, 450);
            pipeBottom.Size = new Size(100, 450);
            points.Size = new Size(2, 622);
            int value = tmp.Next(-380, -200);
            pipeTop.Location = new Point(800, value);
            pipeBottom.Location = new Point(800, 600 + value);
            points.Location = new Point(885, 0);
            pipeTop.Tag = "topP";
            pipeBottom.Tag = "botP";
            points.Tag = "pointP";
            this.Controls.Add(pipeTop);
            this.Controls.Add(pipeBottom);
            this.Controls.Add(points);
        }
        //funkcija za prvite cevki za da se gledaat na formata
        public void firstPipes()
        {
            PictureBox pipeTop = new PictureBox();
            PictureBox pipeBottom = new PictureBox();
            PictureBox points = new PictureBox();
            pipeTop.Image = Properties.Resources.pipedown;
            pipeBottom.Image = Properties.Resources.pipe;
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.Size = new Size(100, 450);
            pipeBottom.Size = new Size(100, 450);
            points.Size = new Size(2, 622);
            int value = tmp.Next(-380, -200);
            pipeTop.Location = new Point(750, value);
            pipeBottom.Location = new Point(750, 600 + value);
            points.Location = new Point(835, 0);
            pipeTop.Tag = "topP";
            pipeBottom.Tag = "botP";
            points.Tag = "pointP";
            this.Controls.Add(pipeTop);
            this.Controls.Add(pipeBottom);
            this.Controls.Add(points);
        }

        
        private void onPress(object sender, KeyEventArgs e)
        {
            //skokanje i pocetok na igrata
            if(e.KeyCode == Keys.Space)
            {
                if (!gameTimer.Enabled && pbEndCard.Visible == false)
                {
                    gameTimer.Start();
                    pipeTimer.Start();
                    force = g;
                    lblStart.Visible = false;
                    Score.Visible = true;
                }

                force = g;
            }
            
            if(e.KeyCode == Keys.Enter)
            {
                if(!gameTimer.Enabled && pbEndCard.Visible == true)
                {
                    Restart();
                }
            }

           
        }
        //zgolemuvanje na brzinata na dvizenje na cevkite za pogolema tezina na igrata
        private void Speed_Increase(int score)
        {
            if (score == 10)
            {
                speed += 1;
                pipeTimer.Interval = 2500;
            }
            if (score == 25)
            {
                speed += 2;
                pipeTimer.Interval = 1800;
            }
            if (score == 50)
            {
                speed += 4;
                pipeTimer.Interval = 1300;
            }
            if (score == 100)
            {
                speed += 6;
                pipeTimer.Interval = 800;
            }

        }
        //funkcija za restartiranje na igrata
        private void Restart()
        {
            gameTimer.Stop();
            pipeTimer.Stop();

            //brisenje na cevkite posle restart
            for(int b = this.Controls.Count -1; b >= 0; b--)
            {
                if(this.Controls[b] is PictureBox && this.Controls[b].Tag == "topP")
                {
                    this.Controls[b].Dispose();
                }
                else if(this.Controls[b] is PictureBox && this.Controls[b].Tag == "botP")
                {
                    this.Controls[b].Dispose();
                }
                else if(this.Controls[b] is PictureBox && this.Controls[b].Tag == "pointP")
                {
                    this.Controls[b].Dispose();
                }
            }

            flappyBird.Location = new Point(143, 263);
            score = 0;
            speed = 4;
            force = g;
            pbEndCard.Visible = false;
            pbGameOver.Visible = false;
            lblRestart.Visible = false;
            lblScore.Visible = false;
            lblStart.Visible = true;
            pipeTimer.Interval = 3500;
            firstPipes();
            
        }
        //funkcija za kraj na igrata
        private void gameEnd()
        {
            gameTimer.Stop();
            pipeTimer.Stop();
            Score.Visible = false;
            pbEndCard.Visible = true;
            pbGameOver.Visible = true;
            lblScore.Text = "Your score is: " + score;
            lblScore.Visible = true;
            lblRestart.Visible = true;
        }
    }
}
