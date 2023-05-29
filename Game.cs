using System;
using System.Drawing;
using System.IO;
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

        int time = 0;
        string onePlayerName;


        public Game(bool gameForTwoPlayer, string playerName = null)
        {
            InitializeComponent();
            twoPlayers = gameForTwoPlayer;
            onePlayerName = playerName;
        }

        #region Timer
        // timer is in milliseconds
        // 1000 milliseconds = 1 second
        private void TimerTick(object sender, EventArgs e)
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
                ChangeImageScore(scoreRight, true);
            }

            // Right paddle missed the ball
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = (this.ClientSize.Width / 2) - (ball.Width / 2);  
                ball.Top = random.Next(ball.Height + 1, this.ClientSize.Height - ball.Height);
                ballX = -ballX; 
                scoreLeft++; 
                ChangeImageScore(scoreLeft, false);
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
                gameTime.Stop();
                winleft.Visible = true;
                winleft.Image = Properties.Resources.You_win;
                winright.Visible = true;
                winright.Image = Properties.Resources.You_lose;
                enter.Visible = true;
                end = true;

                if (!twoPlayers)
                {
                    scoreShow.Visible = true;
                    nameBox.Visible = true;
                    nameBox.TextAlign = HorizontalAlignment.Center;
                    scoreShow.Text = string.Format("{0} s", time.ToString());
                    nameBox.Text = onePlayerName;
                    nameBox.Font = new Font("Arial", 24, FontStyle.Bold);
                    scoreShow.Font = new Font("Arial", 24, FontStyle.Bold);
                    SaveScoreIntoCSV(string.Format("{0};{1};{2}", onePlayerName, time.ToString(), string.Format("{0}.{1}.{2}", DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year)));
                }
            }

            if (scoreRight > 9)
            {
                timer.Stop();
                gameTime.Stop();
                winright.Visible = true;    
                winright.Image = Properties.Resources.You_win;
                winleft.Visible = true;
                winleft.Image = Properties.Resources.You_lose;
                enter.Visible = true;
                end = true;
            }
            #endregion
        }

        private void GameTime_Tick(object sender, EventArgs e)
        {
            time++; 
        }
        #endregion

        #region Key control
        private void Keyispressed(object sender, KeyEventArgs e)
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

        private void Keyisnotpressed(object sender, KeyEventArgs e)
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

        private void CloseGameViaX(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region Score image
        private void ChangeImageScore(int score, bool paddleRightScore)
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

        private void SaveScoreIntoCSV(string data)
        {
            //path from .exe file to Resources
            string filePath = "..\\..\\Resources\\Score.csv";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                string row = string.Join(";", data);
                writer.WriteLine(row);
            }
        }
    }
}
