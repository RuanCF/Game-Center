using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Game_Center.Screens;
using Microsoft.VisualBasic;
using Game_Center.Home;

namespace Game_Center.Games.Memory
{
    public partial class MemoryGame : Form
    {

        List<int> numbers = new() { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 };
        string firstChoice;
        string secondChoice;
        int tries;
        List<PictureBox> pictures = new();
        PictureBox picA;
        PictureBox picB;
        int totalTime = 60;
        int countDownTime;
        bool gameOver = false;


        public MemoryGame()
        {
            InitializeComponent();
            LoadPictures();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            countDownTime--;

            txtCountDown.Text = "Tempo Restante: " + countDownTime;

            if (countDownTime < 1)
            {
                GameOver("Tempo acabou, Voce perdeu");

                foreach (PictureBox x in pictures)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("pics/" + (string)x.Tag + ".png");
                    }
                }
            }

        }

        private void RestartGameEvent(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void LoadPictures()
        {
            int leftPos = 170;
            int topPos = 100;
            int rows = 0;

            for (int i = 0; i < 18; i++)
            {
                PictureBox newPic = new()
                {
                    Height = 70,
                    Width = 70,
                    BackColor = Color.LightGray,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                if (rows < 3)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos += 200; //Espaco entre um quadrado para esquerda e direita
                }

                if (rows == 3)
                {
                    leftPos = 170;
                    topPos += 80; //Espaco entre um quadrado para cima e baixo
                    rows = 0;
                }
            }

            RestartGame();
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }

            if (firstChoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("pics/" + (string)picA.Tag + ".png");
                    firstChoice = (string)picA.Tag;
                }
            }
            else if (secondChoice == null)
            {
                picB = sender as PictureBox;

                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("pics/" + (string)picB.Tag + ".png");
                    secondChoice = (string)picB.Tag;
                }
            }
            else
            {
                CheckPictures(picA, picB);
            }
        }

        private void RestartGame()
        {
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();
            numbers = randomList;

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
            }

            tries = 0;
            statusLabel.Text = "Tentativas: " + tries + " vezes.";
            txtCountDown.Text = "Tempo Restante: " + totalTime;
            gameOver = false;
            GameTImer.Start();
            countDownTime = totalTime;

        }

        private void CheckPictures(PictureBox A, PictureBox B)
        {
            if (firstChoice == secondChoice)
            {
                A.Tag = null;
                B.Tag = null;
            }
            else
            {
                tries++;
                statusLabel.Text = "Tentativas " + tries + " vezes.";
            }

            firstChoice = null;
            secondChoice = null;

            foreach (PictureBox pics in pictures.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }

            if (pictures.All(o => o.Tag == pictures[0].Tag))
            {
                GameOver("Parabens, Voce venceu!");
                try
                {
                    ConnectDB con = new();
                    con.conn.Open();
                    string nick = Interaction.InputBox("Insira seu nome para salvar a pontuacao", "Pontuacao: 50");
                    SQLiteCommand coma = new(con.conn);
                    coma.CommandText = "UPDATE UserData SET Score = Score + '50' WHERE NickName == '" + nick + "' ";
                    coma.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Esse Nickname não existe, Registre um usuário");
                    RegisterScreen RS = new();
                    //this.Hide();
                    RS.Show();
                }
            }

        }

        private void GameOver(string msg)
        {
            GameTImer.Stop();
            gameOver = true;
            MessageBox.Show(msg + " Click em reiniciar para jogar novamente.");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LobbyScreen LS = new();
            this.Hide();
            LS.Show();
        }

        private void MemoryGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            GameTImer.Stop();
        }
    }
}