using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Center.Games
{
    public partial class Pong1Player : Form
    {
        bool cima;
        bool baixo;
        int velocidade = 8;
        double bolax = 5;
        double bolay = 5;
        int score = 0;
        int scorePong;
        int cpuPoint = 0;
        public Pong1Player()
        {
            InitializeComponent();
        }

        private void Pong_Load(object sender, EventArgs e)
        {

        }

        private void Pong_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPong menu = new();
            this.Hide();
            menu.ShowDialog();
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                cima = true;
            }
            if (e.KeyCode == Keys.Down)
            {

                baixo = true;
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                cima = false;
            }
            if (e.KeyCode == Keys.Down)
            {

                baixo = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            ball.Top -= (int)bolay;
            ball.Left -= (int)bolax;

            cpuPlayer.Top += velocidade;


            if (score < 6)
            {

                if (cpuPlayer.Top < 0 || cpuPlayer.Top > 455)
                {

                    velocidade = -velocidade;
                }
            }
            else
            {

                cpuPlayer.Top = ball.Top + 30;
            }



            if (ball.Left < 0)
            {

                ball.Left = 434;
                bolax = -bolax;
                bolax -= 1.5;
                cpuPoint++;
                scoreCPU.Text = cpuPoint.ToString();
            }



            if (ball.Left + ball.Width > ClientSize.Width)
            {

                ball.Left = 434;
                bolax = -bolax;
                bolax += 1.5;
                score++;
                scorePlayer.Text = score.ToString();
            }



            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {

                bolay = -bolay;
            }



            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(cpuPlayer.Bounds))
            {

                bolax = -bolax;
            }


            if (cima == true && player1.Top > 0)
            {

                player1.Top -= 8;
            }


            if (baixo == true && player1.Top < 455)
            {

                player1.Top += 8;
            }


            if (score > 6)
            {
                timer1.Stop();

                DialogResult dr = MessageBox.Show("Você venceu! Deseja salvar o placar?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }

            if (cpuPoint > 6)
            {
              timer1.Stop();
                MessageBox.Show("CPU wins, you lose");
            }
        }
    }
}
    

