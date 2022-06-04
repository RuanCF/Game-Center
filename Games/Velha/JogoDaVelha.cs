using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Game_Center.Games.Jogo_da_velha
{
    public partial class JogoDaVelha : Form
    {
        public enum Player
        {
            X, O
        }

        Player currentPlayer;

        List<Button> buttons;
        Random rand = new Random();
        int playerWins = 0;
        int computerWins = 0;

        public JogoDaVelha()
        {
            InitializeComponent();
            resetGame();
        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = System.Drawing.Color.Cyan;
            buttons.Remove(button);
            Check();
            AImoves.Start();
        }

        private void AImove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count); 
                buttons[index].Enabled = false; 
                currentPlayer = Player.O; 
                buttons[index].Text = currentPlayer.ToString(); 
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon; 
                buttons.RemoveAt(index);
                Check();
                AImoves.Stop();
            }
        }

        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void loadbuttons()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button9, button8 };
        }

        private void resetGame()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button button && X.Tag == "play")
                {
                    button.Enabled = true;
                    button.Text = "?";
                    button.BackColor = default;
                }
            }
            AImoves.Stop();
            loadbuttons();
        }

        private void Check()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                AImoves.Stop();
                MessageBox.Show("Player Wins"); 
                playerWins++; 
                label1.Text = "Player Wins- " + playerWins; 
                resetGame(); 
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
            || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {

                AImoves.Stop();
                MessageBox.Show("Computer Wins"); 
                computerWins++; 
                label2.Text = "AI Wins- " + computerWins; 
                resetGame(); 
            }
        }
    }
}
