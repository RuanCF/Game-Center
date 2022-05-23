using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Game_Center.Screens
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();

        }

        private void RegisterScreen_Load(object sender, EventArgs e)
        {

        }
        //private readonly string dbcon = @"Data Source=UserCenter.sdb";
        private void BtnRegister_Click(object sender, EventArgs e)
        {


            if (txtConfirmPassword.Text != string.Empty || txtPassword.Text != string.Empty || txtNick.Text != string.Empty)
            {
                if (
                    (txtConfirmPassword.Text == string.Empty && txtPassword.Text == string.Empty && txtNick.Text == string.Empty)
                    || (txtConfirmPassword.Text == string.Empty || txtPassword.Text == string.Empty || txtNick.Text == string.Empty)
                    )
                {
                    MessageBox.Show("Nick e(ou) Senha(s) vazios",
                                    "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtPassword.Clear();
                    txtConfirmPassword.Clear();
                    txtNick.Clear();
                    txtNick.Focus();
                }
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    ConnectDB con = new();
                    try
                    {
                        con.Conectar();
                        string sql = "INSERT INTO UserData(NickName, Password) VALUES('" + txtNick.Text + "','" + txtPassword.Text + "')";
                        SQLiteCommand coma = new(sql, con.conn);
                        coma.ExecuteNonQuery();

                        MessageBox.Show("Seu resgistro foi efetuado com sucesso!");
                        
                        LoginScreen Login = new();

                        this.Hide();
                        Login.ShowDialog();
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message.ToString(),
                                        "Error",
                                            MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                    }

                }


            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginScreen Login = new();
            this.Hide();
            Login.ShowDialog();

        }

        private void RegisterScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeScreen home = new();
            home.Show();
        }
    }
}
