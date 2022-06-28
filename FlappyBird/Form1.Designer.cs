namespace FlappyBird
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.LStart = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeTimer = new System.Windows.Forms.Timer(this.components);
            this.pbBg = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.lReset = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-12, 544);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(810, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flappyBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(143, 263);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(43, 24);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 4;
            this.flappyBird.TabStop = false;
            // 
            // LStart
            // 
            this.LStart.AutoSize = true;
            this.LStart.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStart.Location = new System.Drawing.Point(216, 254);
            this.LStart.Name = "LStart";
            this.LStart.Size = new System.Drawing.Size(495, 49);
            this.LStart.TabIndex = 5;
            this.LStart.Text = "Press \"Space\" to start";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(379, 13);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(47, 44);
            this.Score.TabIndex = 6;
            this.Score.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.game_tick);
            // 
            // pipeTimer
            // 
            this.pipeTimer.Interval = 3500;
            this.pipeTimer.Tick += new System.EventHandler(this.pipe_tick);
            // 
            // pbBg
            // 
            this.pbBg.BackColor = System.Drawing.Color.LemonChiffon;
            this.pbBg.Location = new System.Drawing.Point(161, 88);
            this.pbBg.Name = "pbBg";
            this.pbBg.Size = new System.Drawing.Size(481, 319);
            this.pbBg.TabIndex = 7;
            this.pbBg.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.LemonChiffon;
            this.ScoreText.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(271, 270);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(109, 33);
            this.ScoreText.TabIndex = 8;
            this.ScoreText.Text = "label1";
            // 
            // lReset
            // 
            this.lReset.AutoSize = true;
            this.lReset.BackColor = System.Drawing.Color.LemonChiffon;
            this.lReset.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReset.Location = new System.Drawing.Point(219, 336);
            this.lReset.Name = "lReset";
            this.lReset.Size = new System.Drawing.Size(369, 33);
            this.lReset.TabIndex = 9;
            this.lReset.Text = "Press \"Enter\" to restart";
            // 
            // GameOver
            // 
            this.GameOver.BackColor = System.Drawing.Color.LemonChiffon;
            this.GameOver.Image = global::FlappyBird.Properties.Resources.GameOver;
            this.GameOver.Location = new System.Drawing.Point(253, 151);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(289, 56);
            this.GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameOver.TabIndex = 10;
            this.GameOver.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(781, 583);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.lReset);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.pbBg);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.LStart);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onPress);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Label LStart;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer pipeTimer;
        private System.Windows.Forms.PictureBox pbBg;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label lReset;
        private System.Windows.Forms.PictureBox GameOver;
    }
}

