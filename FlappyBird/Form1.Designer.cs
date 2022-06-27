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
            this.lblStart = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeTimer = new System.Windows.Forms.Timer(this.components);
            this.pbEndCard = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRestart = new System.Windows.Forms.Label();
            this.pbGameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).BeginInit();
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
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(216, 254);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(495, 49);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Press \"Space\" to start";
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
            // pbEndCard
            // 
            this.pbEndCard.BackColor = System.Drawing.Color.LemonChiffon;
            this.pbEndCard.Location = new System.Drawing.Point(161, 88);
            this.pbEndCard.Name = "pbEndCard";
            this.pbEndCard.Size = new System.Drawing.Size(481, 319);
            this.pbEndCard.TabIndex = 7;
            this.pbEndCard.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblScore.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(271, 270);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(109, 33);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "label1";
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblRestart.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.Location = new System.Drawing.Point(219, 336);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(369, 33);
            this.lblRestart.TabIndex = 9;
            this.lblRestart.Text = "Press \"Enter\" to restart";
            // 
            // pbGameOver
            // 
            this.pbGameOver.BackColor = System.Drawing.Color.LemonChiffon;
            this.pbGameOver.Image = global::FlappyBird.Properties.Resources.GameOver;
            this.pbGameOver.Location = new System.Drawing.Point(253, 151);
            this.pbGameOver.Name = "pbGameOver";
            this.pbGameOver.Size = new System.Drawing.Size(289, 56);
            this.pbGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGameOver.TabIndex = 10;
            this.pbGameOver.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(781, 583);
            this.Controls.Add(this.pbGameOver);
            this.Controls.Add(this.lblRestart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbEndCard);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.lblStart);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onPress);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer pipeTimer;
        private System.Windows.Forms.PictureBox pbEndCard;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRestart;
        private System.Windows.Forms.PictureBox pbGameOver;
    }
}

