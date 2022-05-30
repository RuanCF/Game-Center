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
        #region Declarações
        ConnectDB con = new();
        DataTable dt = new();
        //SQLiteDataAdapter da = null;
        #endregion
        public RegisterScreen()
        {
            InitializeComponent();
        }
        #region Eventos
        private void RegisterScreen_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if ((txtConfirmPassword.Text != string.Empty && txtPassword.Text != string.Empty && txtNick.Text != string.Empty)
                    || (txtConfirmPassword.Text != string.Empty || txtPassword.Text != string.Empty || txtNick.Text != string.Empty)) //Diferente de vazio //Senha confirm ou senha ou nick
            {
                if (txtPassword.Text != String.Empty && txtConfirmPassword.Text != String.Empty)///senha e senha confirmada iguais e diferentes de vazios
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        if (txtNick.Text != String.Empty)
                        {
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
                            catch (Exception)
                            {
                                MessageBox.Show("Esse nickname já está registrado", 
                                                "",
                                                    MessageBoxButtons.OK,
                                                        MessageBoxIcon.Error);
                                con.Desconectar();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nick não pode estar vazio",
                                        "",
                                            MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                        txtPassword.Clear();
                        txtConfirmPassword.Clear();
                        txtNick.Clear();
                        txtNick.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Senhas não estão correspondentes",
                                    "",
                                        MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
                    txtPassword.Clear();
                    txtConfirmPassword.Clear();
                    txtNick.Clear();
                    txtNick.Focus();
                }

            }
            else
            {
                MessageBox.Show("Senhas não podem estar vazias",
                            "",
                                MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                txtNick.Clear();
                txtNick.Focus();
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

        private void lblname_MouseEnter(object sender, EventArgs e)
        {
            lblname.Text = txtNick.Text;
        }
        #endregion
    }
}
