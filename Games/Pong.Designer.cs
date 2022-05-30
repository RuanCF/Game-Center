namespace Game_Center.Games
{
    partial class Pong
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player1 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.cpuPlayer = new System.Windows.Forms.PictureBox();
            this.scorePlayer = new System.Windows.Forms.Label();
            this.scoreCPU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.White;
            this.player1.Location = new System.Drawing.Point(54, 159);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(26, 146);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(415, 176);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(26, 29);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // cpuPlayer
            // 
            this.cpuPlayer.BackColor = System.Drawing.Color.White;
            this.cpuPlayer.Location = new System.Drawing.Point(786, 159);
            this.cpuPlayer.Name = "cpuPlayer";
            this.cpuPlayer.Size = new System.Drawing.Size(26, 146);
            this.cpuPlayer.TabIndex = 2;
            this.cpuPlayer.TabStop = false;
            // 
            // scorePlayer
            // 
            this.scorePlayer.AutoSize = true;
            this.scorePlayer.Font = new System.Drawing.Font("Russo One", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scorePlayer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.scorePlayer.Location = new System.Drawing.Point(234, 59);
            this.scorePlayer.Name = "scorePlayer";
            this.scorePlayer.Size = new System.Drawing.Size(27, 25);
            this.scorePlayer.TabIndex = 3;
            this.scorePlayer.Text = "0";
            // 
            // scoreCPU
            // 
            this.scoreCPU.AutoSize = true;
            this.scoreCPU.Font = new System.Drawing.Font("Russo One", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreCPU.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.scoreCPU.Location = new System.Drawing.Point(601, 59);
            this.scoreCPU.Name = "scoreCPU";
            this.scoreCPU.Size = new System.Drawing.Size(27, 25);
            this.scoreCPU.TabIndex = 4;
            this.scoreCPU.Text = "0";
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(856, 499);
            this.Controls.Add(this.scoreCPU);
            this.Controls.Add(this.scorePlayer);
            this.Controls.Add(this.cpuPlayer);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player1);
            this.Name = "Pong";
            this.Text = "Pong";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pong_FormClosed);
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox cpuPlayer;
        private System.Windows.Forms.Label scorePlayer;
        private System.Windows.Forms.Label scoreCPU;
    }
}