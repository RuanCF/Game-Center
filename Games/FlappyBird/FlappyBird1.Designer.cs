namespace Game_Center.Games.FlappyBird
{
    partial class FlappyBird1
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
            this.restartButton = new System.Windows.Forms.Button();
            this.scoreText = new System.Windows.Forms.Label();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.clouds1 = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds1)).BeginInit();
            this.SuspendLayout();
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Gold;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restartButton.Location = new System.Drawing.Point(328, 179);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(214, 63);
            this.restartButton.TabIndex = 13;
            this.restartButton.Text = "Play Again";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreText.ForeColor = System.Drawing.Color.White;
            this.scoreText.Location = new System.Drawing.Point(32, 5);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(211, 55);
            this.scoreText.TabIndex = 12;
            this.scoreText.Text = "Score: 0";
            this.scoreText.UseWaitCursor = true;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Game_Center.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(412, -132);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 246);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 9;
            this.pipeTop.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::Game_Center.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(42, 137);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(86, 72);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 8;
            this.bird.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Game_Center.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-35, 486);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(924, 177);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 11;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Game_Center.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(412, 321);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(113, 224);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 10;
            this.pipeBottom.TabStop = false;
            // 
            // clouds1
            // 
            this.clouds1.Image = global::Game_Center.Properties.Resources.clouds;
            this.clouds1.Location = new System.Drawing.Point(548, 199);
            this.clouds1.Name = "clouds1";
            this.clouds1.Size = new System.Drawing.Size(198, 115);
            this.clouds1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clouds1.TabIndex = 14;
            this.clouds1.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(854, 530);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.clouds1);
            this.Name = "FlappyBird";
            this.Text = "FlappyBird";
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox clouds1;
        private System.Windows.Forms.Timer GameTimer;
    }
}