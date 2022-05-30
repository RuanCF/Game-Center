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
    public partial class Pong : Form
    {
        public Pong()
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
    }
}
