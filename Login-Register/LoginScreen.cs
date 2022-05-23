using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Game_Center.Home;
using Game_Center.Song;
//using MaterialSkin;             // <<<< NECESSARIO para a framework(MateriaSkin)
//using MaterialSkin.Controls;        // <<<< NECESSARIO para a framework(MateriaSkin)
using System.Data.SQLite;

namespace Game_Center.Screens
{
    public partial class LoginScreen : Form
    {
        #region Attributes

        #endregion
        public LoginScreen()
        {
            InitializeComponent();

        }
        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private readonly string dbcon = @"Data Source=UserCenter.sdb";
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlcon = new(dbcon);

            if (((txtNick.Text == "") && (txtPassword.Text == "")) || (txtNick.Text == "") || (txtPassword.Text == ""))
            {
                MessageBox.Show("Nick e(ou) Senha vazios",
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                txtPassword.Clear();
                txtNick.Clear();
                txtNick.Focus();
            }
            else
            {
                ConnectDB con = new();
                try
                {
                    con.Conectar();
                    sqlcon.Open();

                    string query = "SELECT * FROM UserData where NickName = '"
                                 + txtNick.Text
                                    + "' AND Password = '"
                                        + txtPassword.Text
                                            + "'";

                    SQLiteCommand com = new(query, sqlcon);
                    com.ExecuteNonQuery();
                    SQLiteDataReader dr = com.ExecuteReader();

                    int count = 0;

                    while (dr.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Bem vindo ao Game Center",
                                        "",
                                            MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                        LobbyScreen Lobby = new();
                        this.Hide();
                        Lobby.ShowDialog();
                    }
                    if (count < 1)
                    {
                        MessageBox.Show("Registro nao encontrado",
                                        "",
                                            MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                        txtPassword.Clear();
                        txtNick.Clear();
                        txtNick.Focus();
                    }

                    SQLiteDataAdapter dados = new(query, con.conn);
                    DataTable UserData = new();

                }catch (Exception E)
                {
                    MessageBox.Show(E.Message.ToString(),
                                    "Error",
                                        MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                }
            }

        }



        private void LoginScreen_Paint_1(object sender, PaintEventArgs e)
        {
           //Graphics mgraphics = e.Graphics;
           // Pen pen = new Pen(Color.FromArgb(127, 03, 22), 1);

           // Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
           // LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(127, 03, 22), Color.FromArgb(41, 56, 73), LinearGradientMode.Vertical);
           // mgraphics.FillRectangle(lgb, area);
           // mgraphics.DrawRectangle(pen, area);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterScreen Register = new();
            this.Hide();
            Register.ShowDialog();
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
            HomeScreen home = new();
            home.Show();
        }
    }
}
