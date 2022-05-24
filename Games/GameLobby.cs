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

namespace Game_Center.Games
{
    public partial class GameLobby : Form
    {
        Double game1 = 100, game2 = 50, game3 = 10, game4 = 5, total = 0;
        public GameLobby()
        {
            InitializeComponent();
            total = game1 + game2 + game3 + game4;
            LblResultado.Text = total.ToString();
        }
        private static SQLiteConnection sqliteConnection;
        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source = UserCenter.sdb");
            sqliteConnection.Open();
            return sqliteConnection;
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
        Double Res=0;

        private void textBox2_Leave(object sender, EventArgs e)
        {
            double Valor1 = Convert.ToDouble(textBox1.Text);
            double Valor2 = Convert.ToDouble(textBox2.Text);
            Res = Valor1 + Valor2;
            resultado.Text = Res.ToString();
        }
    }
}
