using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Center.Home;
using Game_Center.Games;
using Game_Center.Screens;
using MaterialSkin;             // <<<< NECESSARIO para a framework(MateriaSkin)
using MaterialSkin.Controls;        // <<<< NECESSARIO para a framework(MateriaSkin)

namespace Game_Center.Screens
{
    public partial class LoginScreen : MaterialForm
    {
        public LoginScreen()
        {
            InitializeComponent();
 
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LobbyScreen Lobby = new();
            this.Hide();
            Lobby.ShowDialog();
            //this.Close();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void LoginScreen_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(127, 03, 22), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(127, 03, 22), Color.FromArgb(41, 56, 73), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}
