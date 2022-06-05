
namespace Game_Center
{
    partial class HomeScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPassLobby = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Game_Center.Properties.Resources.Wellcome;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.BtnStop, "BtnStop");
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPassLobby
            // 
            this.BtnPassLobby.BackColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.BtnPassLobby, "BtnPassLobby");
            this.BtnPassLobby.Name = "BtnPassLobby";
            this.BtnPassLobby.UseVisualStyleBackColor = false;
            this.BtnPassLobby.Click += new System.EventHandler(this.BtnPassLobby_Click);
            // 
            // HomeScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnPassLobby);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "HomeScreen";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeScreen_FormClosed);
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPassLobby;
    }
}

