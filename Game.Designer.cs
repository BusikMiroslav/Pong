namespace Pong
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.scoreShow = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.PictureBox();
            this.winright = new System.Windows.Forms.PictureBox();
            this.winleft = new System.Windows.Forms.PictureBox();
            this.score1left = new System.Windows.Forms.PictureBox();
            this.score2right = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.paddleRight = new System.Windows.Forms.PictureBox();
            this.paddleLeft = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.enter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score1left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score2right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 1000;
            this.gameTime.Tick += new System.EventHandler(this.GameTime_Tick);
            // 
            // scoreShow
            // 
            this.scoreShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreShow.Location = new System.Drawing.Point(430, 179);
            this.scoreShow.Name = "scoreShow";
            this.scoreShow.ReadOnly = true;
            this.scoreShow.Size = new System.Drawing.Size(148, 15);
            this.scoreShow.TabIndex = 11;
            this.scoreShow.Text = "gameTime";
            this.scoreShow.Visible = false;
            // 
            // enter
            // 
            this.enter.Image = global::Pong.Properties.Resources.Enter;
            this.enter.Location = new System.Drawing.Point(354, 487);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(197, 41);
            this.enter.TabIndex = 10;
            this.enter.TabStop = false;
            this.enter.Visible = false;
            // 
            // winright
            // 
            this.winright.InitialImage = null;
            this.winright.Location = new System.Drawing.Point(545, 209);
            this.winright.Name = "winright";
            this.winright.Size = new System.Drawing.Size(320, 205);
            this.winright.TabIndex = 9;
            this.winright.TabStop = false;
            this.winright.Visible = false;
            // 
            // winleft
            // 
            this.winleft.Location = new System.Drawing.Point(60, 209);
            this.winleft.Name = "winleft";
            this.winleft.Size = new System.Drawing.Size(320, 205);
            this.winleft.TabIndex = 8;
            this.winleft.TabStop = false;
            this.winleft.Visible = false;
            // 
            // score1left
            // 
            this.score1left.BackColor = System.Drawing.Color.Transparent;
            this.score1left.Image = global::Pong.Properties.Resources._0;
            this.score1left.Location = new System.Drawing.Point(255, 12);
            this.score1left.Name = "score1left";
            this.score1left.Size = new System.Drawing.Size(85, 100);
            this.score1left.TabIndex = 7;
            this.score1left.TabStop = false;
            // 
            // score2right
            // 
            this.score2right.BackColor = System.Drawing.Color.Transparent;
            this.score2right.Image = global::Pong.Properties.Resources._0;
            this.score2right.Location = new System.Drawing.Point(590, 12);
            this.score2right.Name = "score2right";
            this.score2right.Size = new System.Drawing.Size(85, 100);
            this.score2right.TabIndex = 6;
            this.score2right.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(453, 233);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(39, 36);
            this.ball.TabIndex = 3;
            this.ball.TabStop = false;
            // 
            // paddleRight
            // 
            this.paddleRight.Image = ((System.Drawing.Image)(resources.GetObject("paddleRight.Image")));
            this.paddleRight.Location = new System.Drawing.Point(904, 200);
            this.paddleRight.Name = "paddleRight";
            this.paddleRight.Size = new System.Drawing.Size(20, 100);
            this.paddleRight.TabIndex = 2;
            this.paddleRight.TabStop = false;
            // 
            // paddleLeft
            // 
            this.paddleLeft.Image = ((System.Drawing.Image)(resources.GetObject("paddleLeft.Image")));
            this.paddleLeft.Location = new System.Drawing.Point(3, 200);
            this.paddleLeft.Name = "paddleLeft";
            this.paddleLeft.Size = new System.Drawing.Size(20, 100);
            this.paddleLeft.TabIndex = 0;
            this.paddleLeft.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameBox.Location = new System.Drawing.Point(317, 130);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(308, 15);
            this.nameBox.TabIndex = 12;
            this.nameBox.Text = "playerName";
            this.nameBox.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(926, 566);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.scoreShow);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.winright);
            this.Controls.Add(this.winleft);
            this.Controls.Add(this.score1left);
            this.Controls.Add(this.score2right);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddleRight);
            this.Controls.Add(this.paddleLeft);
            this.MaximumSize = new System.Drawing.Size(944, 613);
            this.MinimumSize = new System.Drawing.Size(944, 613);
            this.Name = "Game";
            this.Text = "Pong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseGameViaX);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyispressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisnotpressed);
            ((System.ComponentModel.ISupportInitialize)(this.enter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score1left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score2right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paddleLeft;
        private System.Windows.Forms.PictureBox paddleRight;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox score2right;
        private System.Windows.Forms.PictureBox score1left;
        private System.Windows.Forms.PictureBox winleft;
        private System.Windows.Forms.PictureBox winright;
        private System.Windows.Forms.PictureBox enter;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.TextBox scoreShow;
        private System.Windows.Forms.TextBox nameBox;
    }
}

