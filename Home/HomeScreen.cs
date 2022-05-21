using Game_Center.Screens;
using Game_Center.Song;
using System.Windows.Forms;

namespace Game_Center
{
    public partial class HomeScreen : Form
    {
        ClassSong Song = new();
        public HomeScreen()
        {
            InitializeComponent();

        }

        private void HomeScreen_Load(object sender, System.EventArgs e)
        {

        }

        private void BtnLogar_Click(object sender, System.EventArgs e)
        {
            LoginScreen Login = new();
            this.Hide();
            Login.ShowDialog();
        }
        private void BtnRegister_Click(object sender, System.EventArgs e)
        {
            RegisterScreen Register = new();
            this.Hide();
            Register.ShowDialog();
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void BtnStop_Click(object sender, System.EventArgs e)
        {
            Song.StopSong();
        }
    }
}
