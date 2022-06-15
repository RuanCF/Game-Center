
namespace Game_Center.Home
{
    partial class LobbyScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LobbyScreen));
            this.BoxPong = new System.Windows.Forms.PictureBox();
            this.carousel1 = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.BoxVelha = new System.Windows.Forms.PictureBox();
            this.BoxFlappy = new System.Windows.Forms.PictureBox();
            this.BoxMemoria = new System.Windows.Forms.PictureBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxPong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxVelha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxFlappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxMemoria)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxPong
            // 
            this.BoxPong.Image = ((System.Drawing.Image)(resources.GetObject("BoxPong.Image")));
            this.BoxPong.Location = new System.Drawing.Point(12, 115);
            this.BoxPong.Name = "BoxPong";
            this.BoxPong.Size = new System.Drawing.Size(166, 97);
            this.BoxPong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxPong.TabIndex = 7;
            this.BoxPong.TabStop = false;
            this.BoxPong.DoubleClick += new System.EventHandler(this.BoxPong_DoubleClick);
            // 
            // carousel1
            // 
            this.carousel1.BackgroundImage = global::Game_Center.Properties.Resources._1454745043738447911;
            this.carousel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carousel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carousel1.HighlightColor = System.Drawing.Color.White;
            this.carousel1.ImageshadeColor = System.Drawing.Color.Black;
            this.carousel1.ImageSlides = false;
            this.carousel1.Location = new System.Drawing.Point(0, 0);
            this.carousel1.Name = "carousel1";
            this.carousel1.PadX = 0;
            this.carousel1.PadY = 0;
            this.carousel1.Perspective = 4F;
            this.carousel1.RotateAlways = false;
            this.carousel1.ShowImagePreview = false;
            this.carousel1.ShowImageShadow = true;
            this.carousel1.Size = new System.Drawing.Size(1264, 681);
            this.carousel1.TabIndex = 5;
            this.carousel1.Text = "carousel2";
            this.carousel1.TouchTransitionSpeed = 1F;
            this.carousel1.UseOriginalImageinPreview = false;
            // 
            // BoxVelha
            // 
            this.BoxVelha.Image = global::Game_Center.Properties.Resources.velha;
            this.BoxVelha.Location = new System.Drawing.Point(12, 12);
            this.BoxVelha.Name = "BoxVelha";
            this.BoxVelha.Size = new System.Drawing.Size(166, 97);
            this.BoxVelha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxVelha.TabIndex = 9;
            this.BoxVelha.TabStop = false;
            this.BoxVelha.DoubleClick += new System.EventHandler(this.BoxVelha_DoubleClick);
            // 
            // BoxFlappy
            // 
            this.BoxFlappy.Image = global::Game_Center.Properties.Resources.flappy_bird;
            this.BoxFlappy.Location = new System.Drawing.Point(12, 218);
            this.BoxFlappy.Name = "BoxFlappy";
            this.BoxFlappy.Size = new System.Drawing.Size(166, 97);
            this.BoxFlappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxFlappy.TabIndex = 10;
            this.BoxFlappy.TabStop = false;
            this.BoxFlappy.DoubleClick += new System.EventHandler(this.BoxFlappy_DoubleClick);
            // 
            // BoxMemoria
            // 
            this.BoxMemoria.Image = global::Game_Center.Properties.Resources.memoria;
            this.BoxMemoria.Location = new System.Drawing.Point(12, 338);
            this.BoxMemoria.Name = "BoxMemoria";
            this.BoxMemoria.Size = new System.Drawing.Size(166, 97);
            this.BoxMemoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxMemoria.TabIndex = 12;
            this.BoxMemoria.TabStop = false;
            this.BoxMemoria.DoubleClick += new System.EventHandler(this.BoxMemoria_DoubleClick);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("Alagard", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnRegister.Location = new System.Drawing.Point(1170, 638);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(82, 31);
            this.BtnRegister.TabIndex = 13;
            this.BtnRegister.Text = "Sair";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Alagard", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(547, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Game Center";
            // 
            // LobbyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BoxMemoria);
            this.Controls.Add(this.BoxFlappy);
            this.Controls.Add(this.BoxVelha);
            this.Controls.Add(this.BoxPong);
            this.Controls.Add(this.carousel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LobbyScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.BoxPong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxVelha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxFlappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxMemoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BoxPong;
        private Syncfusion.Windows.Forms.Tools.Carousel carousel1;
        private System.Windows.Forms.PictureBox BoxVelha;
        private System.Windows.Forms.PictureBox BoxFlappy;
        private System.Windows.Forms.PictureBox BoxMemoria;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label label1;
    }
}