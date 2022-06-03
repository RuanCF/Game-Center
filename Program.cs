using Game_Center.Games;
using Game_Center.Games.FlappyBird;
using Game_Center.Games.Jogo_da_velha;
using Game_Center.Home;
using Game_Center.Screens;
using Game_Center.Song;
using System;
using System.Windows.Forms;

namespace Game_Center
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ClassSong Song = new();
            Song.PlaySong();
            Application.Run(new JogoDaVelha()); //Tela q inicia o projeto!!!
        }
    }
}
