using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.DeepPurple900, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Purple400, TextShade.WHITE
            );
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
    }
}
