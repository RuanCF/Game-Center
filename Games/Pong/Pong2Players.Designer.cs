
namespace Game_Center.Games.Pong
{
    partial class Pong2Players
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.scorePlayer = new System.Windows.Forms.Label();
            this.scorePlayer2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.White;
            this.player1.Location = new System.Drawing.Point(755, 162);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(26, 146);
            this.player1.TabIndex = 1;
            this.player1.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(372, 201);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(26, 29);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.White;
            this.player2.Location = new System.Drawing.Point(60, 162);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(26, 146);
            this.player2.TabIndex = 3;
            this.player2.TabStop = false;
            // 
            // scorePlayer
            // 
            this.scorePlayer.AutoSize = true;
            this.scorePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scorePlayer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.scorePlayer.Location = new System.Drawing.Point(588, 66);
            this.scorePlayer.Name = "scorePlayer";
            this.scorePlayer.Size = new System.Drawing.Size(25, 25);
            this.scorePlayer.TabIndex = 4;
            this.scorePlayer.Text = "0";
            // 
            // scorePlayer2
            // 
            this.scorePlayer2.AutoSize = true;
            this.scorePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scorePlayer2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.scorePlayer2.Location = new System.Drawing.Point(218, 66);
            this.scorePlayer2.Name = "scorePlayer2";
            this.scorePlayer2.Size = new System.Drawing.Size(25, 25);
            this.scorePlayer2.TabIndex = 5;
            this.scorePlayer2.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pong2Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(856, 499);
            this.Controls.Add(this.scorePlayer2);
            this.Controls.Add(this.scorePlayer);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player1);
            this.Name = "Pong2Players";
            this.Text = "Pong2Players";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pong2Players_FormClosed);
            this.Load += new System.EventHandler(this.Pong2Players_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong2Players_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong2Players_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Label scorePlayer;
        private System.Windows.Forms.Label scorePlayer2;
        private System.Windows.Forms.Timer timer1;
    }
}