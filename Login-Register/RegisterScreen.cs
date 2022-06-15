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
using Game_Center.Home;

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

        private void BtnRegister_Click(object sender, EventArgs e)
        {
                        if (txtNick.Text != String.Empty)
                        {
                            try
                            {
                                con.Conectar();
                                string sql = "INSERT INTO UserData(NickName) VALUES('" + txtNick.Text + "')";
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
                        else
                        {
                            MessageBox.Show("Nick não pode estar vazio",
                                            "",
                                                MessageBoxButtons.OK,
                                                    MessageBoxIcon.Exclamation);
                            txtNick.Clear();
                            txtNick.Focus();
                        }
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
