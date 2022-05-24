
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.carousel1 = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.ButtonAdv = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.carousel2 = new Syncfusion.Windows.Forms.Tools.Carousel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_Center.Properties.Resources.titanfall_imc_soldiers_bluepoint_games_wallpaper;
            this.pictureBox1.Location = new System.Drawing.Point(767, 431);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // carousel1
            // 
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
            this.carousel1.Size = new System.Drawing.Size(0, 0);
            this.carousel1.TabIndex = 4;
            this.carousel1.TouchTransitionSpeed = 1F;
            this.carousel1.UseOriginalImageinPreview = false;
            // 
            // ButtonAdv
            // 
            this.ButtonAdv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAdv.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonAdv.Depth = 0;
            this.ButtonAdv.HighEmphasis = true;
            this.ButtonAdv.Icon = null;
            this.ButtonAdv.Location = new System.Drawing.Point(20, 433);
            this.ButtonAdv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAdv.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAdv.Name = "ButtonAdv";
            this.ButtonAdv.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonAdv.Size = new System.Drawing.Size(158, 36);
            this.ButtonAdv.TabIndex = 2;
            this.ButtonAdv.Text = "materialButton1";
            this.ButtonAdv.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAdv.UseAccentColor = false;
            this.ButtonAdv.UseVisualStyleBackColor = true;
            this.ButtonAdv.Click += new System.EventHandler(this.ButtonAdv1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // carousel2
            // 
            this.carousel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carousel2.BackgroundImage")));
            this.carousel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carousel2.HighlightColor = System.Drawing.Color.White;
            this.carousel2.ImageshadeColor = System.Drawing.Color.Black;
            this.carousel2.ImageSlides = false;
            this.carousel2.Location = new System.Drawing.Point(0, 0);
            this.carousel2.Name = "carousel2";
            this.carousel2.PadX = 0;
            this.carousel2.PadY = 0;
            this.carousel2.Perspective = 4F;
            this.carousel2.RotateAlways = false;
            this.carousel2.ShowImagePreview = false;
            this.carousel2.ShowImageShadow = true;
            this.carousel2.Size = new System.Drawing.Size(883, 537);
            this.carousel2.TabIndex = 5;
            this.carousel2.Text = "carousel2";
            this.carousel2.TouchTransitionSpeed = 1F;
            this.carousel2.UseOriginalImageinPreview = false;
            // 
            // LobbyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonAdv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.carousel1);
            this.Controls.Add(this.carousel2);
            this.DoubleBuffered = true;
            this.Name = "LobbyScreen";
            this.Text = "LobbyScreen";
            this.Load += new System.EventHandler(this.LobbyScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.Carousel carousel1;
        private MaterialSkin.Controls.MaterialButton ButtonAdv;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.Carousel carousel2;
    }
}