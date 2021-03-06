using Game_Center.Home;
using Game_Center.Screens;
using Microsoft.VisualBasic;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Center.Games.FlappyBird
{
    public partial class FlappyBird : Form
    {
        #region Declaração
        int cloudSpeed = 2;
        int pipeSpeed = 6;
        int gravity = 1;
        int score = 0;
        int count = 0;
        int cloudCount = 0;
        #endregion

        public FlappyBird()
        {
            InitializeComponent();
        }

        #region Timer
        private void GameTimerEvent(object sender, EventArgs e)
        {
            var randomNum = new Random();
            bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            clouds1.Left -= cloudSpeed;
            scoreText.Text = "Score: " + score;

            if (clouds1.Left < -200)
            {
                cloudCount++;
                clouds1.Left = 950;
                if (cloudCount % 2 == 0)
                {
                    clouds1.Top = randomNum.Next(158, 386);
                }
                else if (cloudCount % 2 == 1)
                {
                    clouds1.Top = randomNum.Next(237, 368);
                }
            }

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = randomNum.Next(650, 950);
                score++;
            }

            if (pipeTop.Left < -150)
            {
                pipeTop.Left = randomNum.Next(650, 950);
                score++;
                count++;
                // Set random vertical spawn of Top pipe
                //if (count % 2 == 0)
                //{
                //    pipeTop.Top = randomNum.Next(-94, -31);
                //}
                //else if (count % 2 == 1)
                //{
                //    pipeTop.Top = randomNum.Next(-31, -10);
                //}

            }
            if (score > 5 && score <= 10)
            {
                pipeSpeed = 8;
            }

            if (score > 10 && score <= 15)
            {
                pipeSpeed = 10;
            }

            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Top < -25)

            {
                //bird.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                EndGame();
            }

        }

        #endregion

        #region Keys
        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -20;
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void GameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        #endregion

         #region EndGame
        private void EndGame()
        {
            GameTimer.Stop();
            scoreText.Text += " Fim de jogo!";
            restartButton.Visible = true;
            restartButton.Enabled = true;
            try
            {
                ConnectDB con = new();
                con.conn.Open();
                string nick = Interaction.InputBox("Insira seu nome para salvar a pontuacao.", "Pontuacao: 50");
                SQLiteCommand coma = new(con.conn);
                coma.CommandText = "UPDATE UserData SET Score = Score + '50' WHERE NickName == '" + nick + "' ";
                coma.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Esse Nickname não existe, Registre um usuário");
                RegisterScreen RS = new();
                //this.Hide();
                RS.Show();
            }
            GameTimer.Stop();
        }
        #endregion

        #region Restart
        private void RestartButton_Click(object sender, EventArgs e)
        {
            pipeSpeed = 6;
            gravity = 5;
            score = 0;
            scoreText.Text = "Score: " + score;
            count = 0;
            bird.Location = new Point(53, 175);
            pipeTop.Location = new Point(423, -94);
            pipeBottom.Location = new Point(320, 401);
            clouds1.Location = new Point(198, 115);
            restartButton.Visible = false;
            restartButton.Enabled = false;
            GameTimer.Start();
        }
        #endregion

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            LobbyScreen lb = new();
            this.Hide();
            lb.ShowDialog();
        }

        private void FlappyBird_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameTimer.Stop();
        }

        private void FlappyBird_FormClosed(object sender, FormClosedEventArgs e)
        {
            GameTimer.Stop();
        }
    }
}
