using System.Windows.Forms;

namespace Pong
{
    partial class MainPage
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
            this.statisticsImage = new System.Windows.Forms.PictureBox();
            this.arrow3 = new System.Windows.Forms.PictureBox();
            this.arrow2 = new System.Windows.Forms.PictureBox();
            this.arrow1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.twoPlayers = new System.Windows.Forms.PictureBox();
            this.onePlayer = new System.Windows.Forms.PictureBox();
            this.pongLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticsImage
            // 
            this.statisticsImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statisticsImage.Image = global::Pong.Properties.Resources.statistics;
            this.statisticsImage.Location = new System.Drawing.Point(837, 480);
            this.statisticsImage.Name = "statisticsImage";
            this.statisticsImage.Size = new System.Drawing.Size(77, 102);
            this.statisticsImage.TabIndex = 7;
            this.statisticsImage.TabStop = false;
            this.statisticsImage.Click += new System.EventHandler(this.StatisticsImage_Click);
            // 
            // arrow3
            // 
            this.arrow3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrow3.Image = global::Pong.Properties.Resources.arrow;
            this.arrow3.Location = new System.Drawing.Point(132, 480);
            this.arrow3.Name = "arrow3";
            this.arrow3.Size = new System.Drawing.Size(52, 52);
            this.arrow3.TabIndex = 6;
            this.arrow3.TabStop = false;
            this.arrow3.Visible = false;
            // 
            // arrow2
            // 
            this.arrow2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrow2.Image = global::Pong.Properties.Resources.arrow;
            this.arrow2.Location = new System.Drawing.Point(132, 391);
            this.arrow2.Name = "arrow2";
            this.arrow2.Size = new System.Drawing.Size(52, 52);
            this.arrow2.TabIndex = 5;
            this.arrow2.TabStop = false;
            this.arrow2.Visible = false;
            // 
            // arrow1
            // 
            this.arrow1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrow1.Image = global::Pong.Properties.Resources.arrow;
            this.arrow1.Location = new System.Drawing.Point(132, 306);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(52, 52);
            this.arrow1.TabIndex = 4;
            this.arrow1.TabStop = false;
            this.arrow1.Visible = false;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = global::Pong.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(356, 475);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(247, 57);
            this.exit.TabIndex = 3;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.ShowExitArrow);
            this.exit.MouseLeave += new System.EventHandler(this.HideExitArrow);
            // 
            // twoPlayers
            // 
            this.twoPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoPlayers.Image = global::Pong.Properties.Resources._2_players;
            this.twoPlayers.Location = new System.Drawing.Point(209, 382);
            this.twoPlayers.Name = "twoPlayers";
            this.twoPlayers.Size = new System.Drawing.Size(552, 73);
            this.twoPlayers.TabIndex = 2;
            this.twoPlayers.TabStop = false;
            this.twoPlayers.Click += new System.EventHandler(this.TwoPlayers_Click);
            this.twoPlayers.MouseEnter += new System.EventHandler(this.Show2PArrow);
            this.twoPlayers.MouseLeave += new System.EventHandler(this.Hide2PArrow);
            // 
            // onePlayer
            // 
            this.onePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onePlayer.Image = global::Pong.Properties.Resources._1_player;
            this.onePlayer.Location = new System.Drawing.Point(229, 292);
            this.onePlayer.Name = "onePlayer";
            this.onePlayer.Size = new System.Drawing.Size(492, 66);
            this.onePlayer.TabIndex = 1;
            this.onePlayer.TabStop = false;
            this.onePlayer.Click += new System.EventHandler(this.OnePlayer_Click);
            this.onePlayer.MouseEnter += new System.EventHandler(this.Show1PArrow);
            this.onePlayer.MouseLeave += new System.EventHandler(this.Hide1PArrow);
            // 
            // pongLogo
            // 
            this.pongLogo.Image = global::Pong.Properties.Resources.Pong;
            this.pongLogo.Location = new System.Drawing.Point(54, 28);
            this.pongLogo.Name = "pongLogo";
            this.pongLogo.Size = new System.Drawing.Size(804, 216);
            this.pongLogo.TabIndex = 0;
            this.pongLogo.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(926, 566);
            this.Controls.Add(this.statisticsImage);
            this.Controls.Add(this.arrow3);
            this.Controls.Add(this.arrow2);
            this.Controls.Add(this.arrow1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.twoPlayers);
            this.Controls.Add(this.onePlayer);
            this.Controls.Add(this.pongLogo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(944, 613);
            this.MinimumSize = new System.Drawing.Size(944, 613);
            this.Name = "MainPage";
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.statisticsImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pongLogo;
        private System.Windows.Forms.PictureBox onePlayer;
        private System.Windows.Forms.PictureBox twoPlayers;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox arrow1;
        private System.Windows.Forms.PictureBox arrow2;
        private System.Windows.Forms.PictureBox arrow3;
        private System.Windows.Forms.PictureBox statisticsImage;
    }
}