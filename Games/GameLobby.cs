
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Center.Song;

namespace Game_Center.Games
{
    public partial class GameLobby : Form
    {
        public int game1 = 100, game2 = 50, game3 = 10, game4 = 5,total = 0;
        public GameLobby()
        {
            InitializeComponent();
            total= game1+ game2 + game3 + game4;
            LblResultado.Text = total.ToString();
            GM1.Text = game1.ToString();
            GM2.Text = game2.ToString();
            GM3.Text = game3.ToString();
            GM4.Text = game4.ToString();
        }

        #region Banco
        private static SQLiteConnection sqliteConnection;
        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source = UserCenter.sdb");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        private void GameLobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassSong song = new();
            song.StopSong();
        }


        public static DataTable GetCliente(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Clientes Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB connect = new();
            connect.Update();
        }

        #endregion
    }
}
