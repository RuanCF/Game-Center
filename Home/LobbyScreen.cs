using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Game_Center.Games;
using Game_Center.Games.FlappyBird;
using Game_Center.Properties;
using Game_Center.Games.Jogo_da_velha;
using Game_Center.Games.Pong;
using Game_Center.Games.Memory;

namespace Game_Center.Home
{
    public partial class LobbyScreen : Form
    {
        public LobbyScreen()
        {
            InitializeComponent();
            this.carousel1.TransitionSpeed = 4f;
            this.carousel1.CarouselPath = CarouselPath.Oval;

            //Add the custom controls into carousel
            //carousel1.Controls.Add(BoxPong);
            carousel1.Controls.Add(BoxVelha);
            carousel1.Controls.Add(BoxFlappy);
            carousel1.Controls.Add(BoxMemoria);

            //Add the custom controls into carousel items
            //carousel1.Items.Add(BoxPong);
            carousel1.Items.Add(BoxVelha);
            carousel1.Items.Add(BoxFlappy);
            carousel1.Items.Add(BoxMemoria);

        }

        private void BoxPong_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            Pong2Players f = new Pong2Players();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void BoxFlappy_DoubleClick(object sender, EventArgs e)
        {
            FlappyBird f = new();
            this.Hide();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void BoxVelha_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            JogoDaVelha f = new();
            this.Hide();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BoxMemoria_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            MemoryGame f = new();
            this.Hide();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScoreScreen f = new();
            //this.Hide();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
