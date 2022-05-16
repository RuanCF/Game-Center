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
using MaterialSkin;             // <<<< NECESSARIO para a framework(MateriaSkin)
using MaterialSkin.Controls;        // <<<< NECESSARIO para a framework(MateriaSkin)

namespace Game_Center.Games
{
    public partial class GameLobby : MaterialSkin.Controls.MaterialForm
    {


        public GameLobby()
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
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, btnTeste.Width, btnTeste.Height);
            btnTeste.Region = new Region(forma);
        }

        private void GameLobby_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer
            {
                Interval = (1 * 1000)
            };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

        }



        private void Timer_Tick(object sender, EventArgs e)
        { 
            materialLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
        }


    }

       

}
