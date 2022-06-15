using Game_Center.Games;
using Game_Center.Home;
using Game_Center.Screens;
using Game_Center.Song;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Center
{
    public partial class HomeScreen : Form
    {
        ClassSong Song = new();
        public HomeScreen()
        {
            InitializeComponent();
            //BtnPassLobby.Parent = Me;
 


        }

        private void HomeScreen_Load(object sender, System.EventArgs e)
        {

        }

        private void BtnLogar_Click(object sender, System.EventArgs e)
        {
            LoginScreen f = new();
            this.Hide();
            f.Closed += (s, args) => this.Close();
            f.Show();
            
        }
        private void BtnRegister_Click(object sender, System.EventArgs e)
        {
            RegisterScreen f = new();
            this.Hide();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void BtnStop_Click(object sender, System.EventArgs e)
        {
            Song.StopSong();
        }

        private void HomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Song.StopSong();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            LobbyScreen f = new();
            this.Hide();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
