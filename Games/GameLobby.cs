
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Center.Song;
using Game_Center.Games.Pong;
using Game_Center.Screens;

namespace Game_Center.Games
{
    public partial class GameLobby : Form
    {
        public int game1 = 100, game2 = 50, game3 = 10, game4 = 5;
        //public int total = 0; 
        public string txtNome;
        public GameLobby()
        {
            InitializeComponent();
            LoginScreen ls = new();
            lbname.Text = txtNome;
            Pong2Players pong2 = new();
            //total = game1 + game2 + game3;
            //LblResultado.Text = total.ToString();
            GM2.Text = game2.ToString();
            GM3.Text = game3.ToString();
            GM4.Text = game4.ToString();
        }

        private void GameLobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassSong song = new();
            song.StopSong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //total = game1 + game2 + game3;
            ConnectDB connect = new();
            connect.Update();
        }

        //#endregion
    }
}
