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

namespace Game_Center.Home
{
    public partial class LobbyScreen : Form
    {
        public LobbyScreen()
        {
            InitializeComponent();
            
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            HomeScreen home = new();
            home.ShowDialog();
        }

        private void ButtonAdv1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Carousel carousela = new();
            this.Controls.Add(carousel1);
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
            buttonAdv5.ForeColor = System.Drawing.Color.White;;

            buttonAdv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            buttonAdv6.ForeColor = System.Drawing.Color.White;
;

            //Add the custom controls into carousel
            carousel2.Controls.Add(panel1);
            carousel2.Controls.Add(buttonAdv2);
            carousel2.Controls.Add(buttonAdv3);
            carousel2.Controls.Add(buttonAdv4);
            carousel2.Controls.Add(buttonAdv5);
            carousel2.Controls.Add(buttonAdv6);


            //Add the custom controls into carousel items
            carousel2.Items.Add(panel1);
            carousel2.Items.Add(buttonAdv2);
            carousel2.Items.Add(buttonAdv3);
            carousel2.Items.Add(buttonAdv4);
            carousel2.Items.Add(buttonAdv5);
            carousel2.Items.Add(buttonAdv6);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void carousel1_Click(object sender, EventArgs e)
        {

        }

        private void LobbyScreen_Load(object sender, EventArgs e)
        {
          
        }
    }
}
