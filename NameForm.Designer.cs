namespace Pong
{
    partial class NameForm
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
            this.playBtn = new System.Windows.Forms.PictureBox();
            this.yourNameImg = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourNameImg)).BeginInit();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Image = global::Pong.Properties.Resources.playButton;
            this.playBtn.Location = new System.Drawing.Point(784, 440);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(142, 124);
            this.playBtn.TabIndex = 1;
            this.playBtn.TabStop = false;
            this.playBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // yourNameImg
            // 
            this.yourNameImg.Image = global::Pong.Properties.Resources.your_name;
            this.yourNameImg.Location = new System.Drawing.Point(96, 74);
            this.yourNameImg.Name = "yourNameImg";
            this.yourNameImg.Size = new System.Drawing.Size(713, 113);
            this.yourNameImg.TabIndex = 0;
            this.yourNameImg.TabStop = false;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.name.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.ForeColor = System.Drawing.SystemColors.Window;
            this.name.Location = new System.Drawing.Point(230, 234);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(432, 78);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            this.name.MaxLength = 10;
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(926, 566);
            this.Controls.Add(this.name);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.yourNameImg);
            this.MaximumSize = new System.Drawing.Size(944, 613);
            this.MinimumSize = new System.Drawing.Size(944, 613);
            this.Name = "NameForm";
            this.Text = "NameForm";
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourNameImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox yourNameImg;
        private System.Windows.Forms.PictureBox playBtn;
        private System.Windows.Forms.TextBox name;
    }
}