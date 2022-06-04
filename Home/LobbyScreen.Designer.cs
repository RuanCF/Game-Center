
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.BoxPong = new System.Windows.Forms.PictureBox();
            this.carousel1 = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.BoxVelha = new System.Windows.Forms.PictureBox();
            this.BoxFlappy = new System.Windows.Forms.PictureBox();
            this.LblLista = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxPong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxVelha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxFlappy)).BeginInit();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(27, 602);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(112, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "Game Lobby";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
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
            // LblLista
            // 
            this.LblLista.AutoSize = true;
            this.LblLista.BackColor = System.Drawing.Color.Transparent;
            this.LblLista.Location = new System.Drawing.Point(411, 78);
            this.LblLista.Name = "LblLista";
            this.LblLista.Size = new System.Drawing.Size(38, 15);
            this.LblLista.TabIndex = 11;
            this.LblLista.Text = "label1";
            // 
            // LobbyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.LblLista);
            this.Controls.Add(this.BoxFlappy);
            this.Controls.Add(this.BoxVelha);
            this.Controls.Add(this.BoxPong);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.carousel1);
            this.DoubleBuffered = true;
            this.Name = "LobbyScreen";
            this.Text = "LobbyScreen";
            ((System.ComponentModel.ISupportInitialize)(this.BoxPong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxVelha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxFlappy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.PictureBox BoxPong;
        private Syncfusion.Windows.Forms.Tools.Carousel carousel1;
        private System.Windows.Forms.PictureBox BoxVelha;
        private System.Windows.Forms.PictureBox BoxFlappy;
        private System.Windows.Forms.Label LblLista;
    }
}