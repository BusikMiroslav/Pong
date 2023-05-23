using System;
using System.Windows.Forms;

namespace Pong
{ 
    public partial class Game : Form
    {
        Random random = new Random();

        //speed
        int ballX = 6; 
        int ballY = 6;
        const int playerSpeed = 6;
        const int computerPaddleSpeed = 5;

        int scoreLeft = 0; 
        int scoreRight = 0; 

        bool pressedUpLeft; 
        bool pressedDownLeft;
        bool pressedUpRight;
        bool pressedDownRight;
        bool twoPlayers;
        bool end = false;
        

        public Game(bool gameForTwoPlayer)
        {
            InitializeComponent();
            twoPlayers = gameForTwoPlayer;
        }

        #region Timer
        // timer is in milliseconds
        private void timerTick(object sender, EventArgs e)
        {
            // ball movement
            ball.Top -= ballY; 
            ball.Left -= ballX;

            #region Missed ball
            // Resetting the ball to the middle on random position and updating score

            // Left paddle missed the ball
            if (ball.Left < 0)
            {
                ball.Left = (this.ClientSize.Width / 2) - (ball.Width / 2); 
                ball.Top = random.Next(ball.Height + 1, this.ClientSize.Height - ball.Height);
                ballX = -ballX;
                scoreRight++; 
                changeImageScore(scoreRight, true);
            }

            // Right paddle missed the ball
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = (this.ClientSize.Width / 2) - (ball.Width / 2);  
                ball.Top = random.Next(ball.Height + 1, this.ClientSize.Height - ball.Height);
                ballX = -ballX; 
                scoreLeft++; 
                changeImageScore(scoreLeft, false);
            }
            #endregion

            #region Ball control
            // Changing the direction of the ball 

            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                ballY = -ballY;
            }

            if (ball.Bounds.IntersectsWith(paddleLeft.Bounds) || ball.Bounds.IntersectsWith(paddleRight.Bounds))
            {
                ballX = -ballX;
            }
            #endregion

            #region Player control

            if (pressedUpLeft == true && paddleLeft.Top > 0)
            {
                paddleLeft.Top -= playerSpeed;
            }
            
            if (pressedDownLeft == true && paddleLeft.Bottom < 455)
            {
                paddleLeft.Top += playerSpeed;
            }

            if (twoPlayers)
            {
                if (pressedUpRight == true && paddleRight.Top > 0)
                {
                    paddleRight.Top -= playerSpeed;
                }

                if (pressedDownRight == true && paddleRight.Bottom < 455)
                {
                    paddleRight.Top += playerSpeed;
                }
            }
            else
            {
                if (ball.Top / 2 < paddleRight.Top / 2)
                    paddleRight.Top -= computerPaddleSpeed;
                else if (ball.Top / 2 > paddleRight.Top / 2)
                    if (paddleRight.Bottom < 455)
                        paddleRight.Top += computerPaddleSpeed;
            }
            #endregion

            #region Score/Endgame control

            if (scoreLeft > 9)
            {
                timer.Stop();
                winleft.Visible = true;
                winleft.Image = Properties.Resources.You_win;
                winright.Visible = true;
                winright.Image = Properties.Resources.You_lose;
                enter.Visible = true;
                end = true;
            }

            if (scoreRight > 9)
            {
                timer.Stop();
                winright.Visible = true;    
                winright.Image = Properties.Resources.You_win;
                winleft.Visible = true;
                winleft.Image = Properties.Resources.You_lose;
                enter.Visible = true;
                end = true;
            }
            #endregion
        }
        #endregion

        #region Key control
        private void keyispressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pressedUpLeft = true;
            }
            if (e.KeyCode == Keys.S)
            {
                pressedDownLeft = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                pressedUpRight = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                pressedDownRight = true;
            }
            if (e.KeyCode == Keys.Enter && end)
            {
                this.Close();
            }
        }

        private void keyisnotpressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pressedUpLeft = false;
            }
            if (e.KeyCode == Keys.S)
            {
                pressedDownLeft = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                pressedUpRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                pressedDownRight = false;
            }
        }

        private void closeGameViaX(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region Score image
        private void changeImageScore(int score, bool paddleRightScore)
        {
            switch (score)
            {
                case 0:
                    if (paddleRightScore)
                        score2right.Image = Properties.Resources._0;
                    else
                        score1left.Image = Properties.Resources._0;

                    break;
                case 1:
                    if (paddleRightScore)
                        score2right.Image = Properties.Resources._1;
                    else
                        score1left.Image = Properties.Resources._1;
                    
                    break;
                case 2:
                    if (paddleRightScore)
                        score2right.Image = Properties.Resources._2;
                    else
                        score1left.Image = Properties.Resources._2;

                    break;
                case 3:
                    if (paddleRightScore)
                        score2right.Image = Properties.Resources._3;
                    else
                        score1left.Image = Properties.Resources._3;

                    break;
                case 4:
                    if (paddleRightScore)
                        score2right.Image = Properties.Resources._4;
                    else
                        score1left.Image = Properties.Resources._4;

                    break;
                case 5:
                    if (paddleRightScore)
                        score2right.Image = Properties.Resources._5;
                    else
                        score1left.Image = Properties.Resources._5;

                    break;
                case 6:
                    if (paddleRightScore)
                        score2right.Image = Properties.Resources._6;
                    else
                        score1left.Image = Properties.Resources._6;

                    break;
                case 7:
                    if (paddleRightScore)
                        score2right.Image = Properties.Resources._7;
                    else
                        score1left.Image = Properties.Resources._7;

                    break;
                case 8:
                    if (paddleRightScore)
                        score2right.Image = Properties.Resources._8;
                    else
                        score1left.Image = Properties.Resources._8;

                    break;
                case 9:
                    if (paddleRightScore)
                        score2right.Image = Properties.Resources._9;
                    else
                        score1left.Image = Properties.Resources._9;

                    break;
                default:
                    score2right.Visible = false;
                    score1left.Visible = false;
                    break;
            }
        }
        #endregion
    }
}
