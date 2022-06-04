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

namespace Game_Center.Home
{
    public partial class LobbyScreen : Form
    {
        public LobbyScreen()
        {
            InitializeComponent();
            BoxPong.Visible = true;
            BoxVelha.Visible = true;
            BoxFlappy.Visible = true;

            ButtonAdv buttonAdv4 = new();
            ButtonAdv buttonAdv5 = new();
            ButtonAdv buttonAdv6 = new();

            buttonAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            buttonAdv4.ForeColor = System.Drawing.Color.White;

            buttonAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            buttonAdv5.ForeColor = System.Drawing.Color.White;

            buttonAdv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            buttonAdv6.ForeColor = System.Drawing.Color.White;


            //Add the custom controls into carousel
            carousel1.Controls.Add(BoxPong);
            carousel1.Controls.Add(BoxVelha);
            carousel1.Controls.Add(BoxFlappy);
            carousel1.Controls.Add(buttonAdv4);
            carousel1.Controls.Add(buttonAdv5);
            carousel1.Controls.Add(buttonAdv6);


            //Add the custom controls into carousel items
            carousel1.Items.Add(BoxPong);
            carousel1.Items.Add(BoxVelha);
            carousel1.Items.Add(BoxFlappy);
            carousel1.Items.Add(buttonAdv4);
            carousel1.Items.Add(buttonAdv5);
            carousel1.Items.Add(buttonAdv6);
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            HomeScreen home = new();
            home.ShowDialog();
        }

        private void ButtonAdv1_DoubleClick(object sender, EventArgs e)
        {
            BoxPong.Visible = true;
            //Initialization
            ButtonAdv buttonAdv1 = new();
            ButtonAdv buttonAdv2 = new();
            ButtonAdv buttonAdv3 = new();
            ButtonAdv buttonAdv4 = new();
            ButtonAdv buttonAdv5 = new();
            ButtonAdv buttonAdv6 = new();

            //Set the properties for all buttonadv control
            buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            buttonAdv1.ForeColor = System.Drawing.Color.White;

            buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            buttonAdv2.ForeColor = System.Drawing.Color.White;

            buttonAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            buttonAdv3.ForeColor = System.Drawing.Color.White;

            buttonAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            buttonAdv4.ForeColor = System.Drawing.Color.White;

            buttonAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            buttonAdv5.ForeColor = System.Drawing.Color.White;

            buttonAdv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            buttonAdv6.ForeColor = System.Drawing.Color.White;


            //Add the custom controls into carousel
            carousel1.Controls.Add(buttonAdv1);
            carousel1.Controls.Add(buttonAdv2);
            carousel1.Controls.Add(buttonAdv3);
            carousel1.Controls.Add(buttonAdv4);
            carousel1.Controls.Add(buttonAdv5);
            carousel1.Controls.Add(buttonAdv6);


            //Add the custom controls into carousel items
            carousel1.Items.Add(buttonAdv1);
            carousel1.Items.Add(buttonAdv2);
            carousel1.Items.Add(buttonAdv3);
            carousel1.Items.Add(buttonAdv4);
            carousel1.Items.Add(buttonAdv5);
            carousel1.Items.Add(buttonAdv6);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            GameLobby Game = new();
            this.Hide();
            Game.ShowDialog();
        }

        private void BoxPong_DoubleClick(object sender, EventArgs e)
        {
            MenuPong menuPong = new();
            this.Hide();
            menuPong.ShowDialog();
        }

        private void BoxFlappy_DoubleClick(object sender, EventArgs e)
        {
            FlappyBird form = new();
            this.Hide();
            form.ShowDialog();
        }

        private void BoxVelha_DoubleClick(object sender, EventArgs e)
        {
            JogoDaVelha velha = new();
            this.Hide();
            velha.ShowDialog();
        }
    }
}
