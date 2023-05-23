using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class MainPage : Form
    { 
        public MainPage()
        {
            InitializeComponent();
        }

        #region Click action
        private void OnePlayer_Click(object sender, EventArgs e)
        {
            NameForm nmfrm = new NameForm();
            this.Hide();
            nmfrm.ShowDialog();
            this.Show();
        }

        private void TwoPlayers_Click(object sender, EventArgs e)
        {
            Game game = new Game(true);
            this.Hide();
            game.ShowDialog();
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StatisticsImage_Click(object sender, EventArgs e)
        {
            Statistics stat = new Statistics();
            this.Hide();
            stat.ShowDialog();
            this.Show();
        }
        #endregion

        #region Show and hide arrows 
        private void Show1PArrow(object sender, EventArgs e)
        {
            arrow1.Visible = true;
        }

        private void Hide1PArrow(object sender, EventArgs e)
        {
            arrow1.Visible = false;
        }

        private void Show2PArrow(object sender, EventArgs e)
        {
            arrow2.Visible = true;
        }

        private void Hide2PArrow(object sender, EventArgs e)
        {
            arrow2.Visible = false;
        }

        private void ShowExitArrow(object sender, EventArgs e)
        {
            arrow3.Visible = true;
        }

        private void HideExitArrow(object sender, EventArgs e)
        {
            arrow3.Visible = false;
        }
        #endregion
    }
}
