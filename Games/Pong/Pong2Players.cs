using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Center.Games.Pong
{
    public partial class Pong2Players : Form
    {
        bool p1cima, p1baixo, p2cima, p2baixo;
        int velocidade = 8;
        double bolax = 5;
        double bolay = 5;
        
        int scoreP1 = 0;
        int scoreP2 = 0;
        public int gamePongScore = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            ball.Top -= (int)bolay;
            ball.Left -= (int)bolax;

            if (ball.Left < 0)
            {

                ball.Left = 434;
                bolax = -bolax;
                bolax -= 1.5;
                scoreP2++;
                scorePlayer2.Text = scoreP2.ToString();
            }
            if (ball.Left + ball.Width > ClientSize.Width)
            {

                ball.Left = 434;
                bolax = -bolax;
                bolax += 1.5;
                scoreP1++;
                scorePlayer.Text = scoreP1.ToString();
            }
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {

                bolay = -bolay;
            }



            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(player2.Bounds))
            {

                bolax = -bolax;
            }
            if (p1cima == true && player1.Top > 0)
            {

                player1.Top -= 8;
            }


            if (p1baixo == true && player1.Top < 455)
            {

                player1.Top += 8;
            }
            if (p2cima == true && player2.Top > 0)
            {

                player2.Top -= 8;
            }


            if (p2baixo == true && player2.Top < 455)
            {

                player2.Top += 8;
            }
            if (scoreP1> 6)
            {
                timer1.Stop();

                DialogResult dr = MessageBox.Show("Jogador 1 Venceu,Deseja Repetir ?", "" , MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    timer1.Start();
                    scoreP1 = 0;
                    scoreP2 = 0;
                    scorePlayer.Text = scoreP1.ToString();
                    scorePlayer2.Text = scoreP2.ToString();
                    bolax = 5;
                     bolay = 5;
                    gamePongScore = gamePongScore + 50;
                }
               
            }

            if (scoreP2 > 6)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("Jogador 2 Venceu,Deseja Repetir ?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    timer1.Start();
                    scoreP1 = 0;
                    scoreP2 = 0;
                    scorePlayer.Text = scoreP1.ToString();
                    scorePlayer2.Text = scoreP2.ToString();
                    bolax = 5;
                    bolay = 5;
                    gamePongScore = gamePongScore + 50;
                }

            }

        }

        private void Pong2Players_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                p1cima = false;
            }
            if (e.KeyCode == Keys.Down)
            {

                p1baixo = false;
            }
            if(e.KeyCode == Keys.W)
            {
                p2cima = false;

            }
            if(e.KeyCode == Keys.S)
            {
                p2baixo = false;
            }
        }

        
        public Pong2Players()
        {
            InitializeComponent();
        }

        private void Pong2Players_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                p1cima = true;
            }
            if (e.KeyCode == Keys.Down)
            {

                p1baixo = true;
            }
            if(e.KeyCode == Keys.W)
            {
                p2cima = true;
            }
            if(e.KeyCode == Keys.S)
            {
                p2baixo = true;
            }
        }
    }
}
