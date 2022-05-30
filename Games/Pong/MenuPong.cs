using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Center.Song;

namespace Game_Center.Games
{
    public partial class MenuPong : Form
    {
        public MenuPong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pong1Player pongame = new();
            this.Hide();
            pongame.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeScreen home = new();
            this.Hide();
            home.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassSong song = new();
            song.StopSong();
        }

        private void MenuPong_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeScreen home = new();
            this.Hide();
            home.ShowDialog();
            
        }

        private void MenuPong_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pong.Pong2Players pongame = new();
            this.Hide();
            pongame.ShowDialog();
        }
    }
}
