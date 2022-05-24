
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
            this.resultado = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.carousel1 = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.SuspendLayout();
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(305, 269);
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.Size = new System.Drawing.Size(100, 23);
            this.resultado.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(305, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(323, 251);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(59, 15);
            this.LblResultado.TabIndex = 5;
            this.LblResultado.Text = "Resultado";
            // 
            // carousel1
            // 
            this.carousel1.HighlightColor = System.Drawing.Color.White;
            this.carousel1.ImageshadeColor = System.Drawing.Color.Black;
            this.carousel1.ImageSlides = false;
            this.carousel1.Location = new System.Drawing.Point(396, 73);
            this.carousel1.Name = "carousel1";
            this.carousel1.PadX = 0;
            this.carousel1.PadY = 0;
            this.carousel1.Perspective = 4F;
            this.carousel1.RotateAlways = false;
            this.carousel1.ShowImagePreview = false;
            this.carousel1.ShowImageShadow = true;
            this.carousel1.Size = new System.Drawing.Size(8, 8);
            this.carousel1.TabIndex = 6;
            this.carousel1.Text = "carousel1";
            this.carousel1.TouchTransitionSpeed = 1F;
            this.carousel1.UseOriginalImageinPreview = false;
            // 
            // GameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carousel1);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resultado);
            this.Name = "GameLobby";
            this.Text = "GameLobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblResultado;
        private Syncfusion.Windows.Forms.Tools.Carousel carousel1;
    }
}