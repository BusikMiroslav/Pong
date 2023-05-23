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
        private void onePlayer_Click(object sender, EventArgs e)
        {
            Game game = new Game(false);
            this.Hide();
            game.ShowDialog();
            this.Show();
        }

        private void twoPlayers_Click(object sender, EventArgs e)
        {
            Game game = new Game(true);
            this.Hide();
            game.ShowDialog();
            this.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Show and hide arrows 
        private void show1PArrow(object sender, EventArgs e)
        {
            arrow1.Visible = true;
        }

        private void hide1PArrow(object sender, EventArgs e)
        {
            arrow1.Visible = false;
        }

        private void show2PArrow(object sender, EventArgs e)
        {
            arrow2.Visible = true;
        }

        private void hide2PArrow(object sender, EventArgs e)
        {
            arrow2.Visible = false;
        }

        private void showExitArrow(object sender, EventArgs e)
        {
            arrow3.Visible = true;
        }

        private void hideExitArrow(object sender, EventArgs e)
        {
            arrow3.Visible = false;
        }
        #endregion
    }
}
