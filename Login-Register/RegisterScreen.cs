using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin; // <<<< NECESSARIO para a framework

namespace Game_Center.Screens
{
    public partial class RegisterScreen : MaterialSkin.Controls.MaterialForm
    {
        public RegisterScreen()
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

    }
}
