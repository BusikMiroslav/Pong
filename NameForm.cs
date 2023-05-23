using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (name.Text.Length > 0)
            {
                Game game = new Game(false, name.Text.ToString());
                this.Hide();
                game.ShowDialog();
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            if (name.Text.Length > 0)
                playBtn.Cursor = Cursors.Hand;
        }
    }
}
