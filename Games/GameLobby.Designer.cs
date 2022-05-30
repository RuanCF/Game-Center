
namespace Game_Center.Games
{
    partial class GameLobby
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
            this.LblResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GM1 = new System.Windows.Forms.Label();
            this.GM2 = new System.Windows.Forms.Label();
            this.GM3 = new System.Windows.Forms.Label();
            this.GM4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(454, 221);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(32, 15);
            this.LblResultado.TabIndex = 5;
            this.LblResultado.Text = "Total";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GM1
            // 
            this.GM1.AutoSize = true;
            this.GM1.Location = new System.Drawing.Point(454, 73);
            this.GM1.Name = "GM1";
            this.GM1.Size = new System.Drawing.Size(44, 15);
            this.GM1.TabIndex = 8;
            this.GM1.Text = "Game1";
            // 
            // GM2
            // 
            this.GM2.AutoSize = true;
            this.GM2.Location = new System.Drawing.Point(454, 110);
            this.GM2.Name = "GM2";
            this.GM2.Size = new System.Drawing.Size(44, 15);
            this.GM2.TabIndex = 9;
            this.GM2.Text = "Game2";
            // 
            // GM3
            // 
            this.GM3.AutoSize = true;
            this.GM3.Location = new System.Drawing.Point(454, 145);
            this.GM3.Name = "GM3";
            this.GM3.Size = new System.Drawing.Size(44, 15);
            this.GM3.TabIndex = 10;
            this.GM3.Text = "Game3";
            // 
            // GM4
            // 
            this.GM4.AutoSize = true;
            this.GM4.Location = new System.Drawing.Point(454, 183);
            this.GM4.Name = "GM4";
            this.GM4.Size = new System.Drawing.Size(44, 15);
            this.GM4.TabIndex = 11;
            this.GM4.Text = "Game4";
            // 
            // GameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GM4);
            this.Controls.Add(this.GM3);
            this.Controls.Add(this.GM2);
            this.Controls.Add(this.GM1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblResultado);
            this.Name = "GameLobby";
            this.Text = "GameLobby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameLobby_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GM1;
        private System.Windows.Forms.Label GM2;
        private System.Windows.Forms.Label GM3;
        private System.Windows.Forms.Label GM4;
    }
}