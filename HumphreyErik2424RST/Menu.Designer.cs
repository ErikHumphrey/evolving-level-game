namespace HumphreyErik2424RST
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picHeaderImage = new System.Windows.Forms.PictureBox();
            this.pnlMenuButtons = new System.Windows.Forms.Panel();
            this.lblButtonDescription = new System.Windows.Forms.Label();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderImage)).BeginInit();
            this.pnlMenuButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOptions
            // 
            this.btnOptions.Enabled = false;
            this.btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(101)))));
            this.btnOptions.FlatAppearance.BorderSize = 2;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.Location = new System.Drawing.Point(34, 87);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(108, 23);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            this.btnOptions.MouseEnter += new System.EventHandler(this.btnOptions_MouseEnter);
            this.btnOptions.MouseLeave += new System.EventHandler(this.MenuButtons_MouseLeave);
            // 
            // btnResetGame
            // 
            this.btnResetGame.Enabled = false;
            this.btnResetGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(101)))));
            this.btnResetGame.FlatAppearance.BorderSize = 2;
            this.btnResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetGame.ForeColor = System.Drawing.Color.White;
            this.btnResetGame.Image = ((System.Drawing.Image)(resources.GetObject("btnResetGame.Image")));
            this.btnResetGame.Location = new System.Drawing.Point(34, 58);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(108, 23);
            this.btnResetGame.TabIndex = 5;
            this.btnResetGame.Text = "Reset game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            this.btnResetGame.MouseEnter += new System.EventHandler(this.btnResetGame_MouseEnter);
            this.btnResetGame.MouseLeave += new System.EventHandler(this.MenuButtons_MouseLeave);
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(101)))));
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Image = global::HumphreyErik2424RST.Properties.Resources.texGranite;
            this.btnStart.Location = new System.Drawing.Point(34, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Loading save...";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.MenuButtons_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(101)))));
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(34, 116);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.MenuButtons_MouseLeave);
            // 
            // picHeaderImage
            // 
            this.picHeaderImage.BackColor = System.Drawing.Color.Transparent;
            this.picHeaderImage.Image = global::HumphreyErik2424RST.Properties.Resources.imgBannerImproved;
            this.picHeaderImage.Location = new System.Drawing.Point(21, 20);
            this.picHeaderImage.Name = "picHeaderImage";
            this.picHeaderImage.Size = new System.Drawing.Size(308, 64);
            this.picHeaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHeaderImage.TabIndex = 15;
            this.picHeaderImage.TabStop = false;
            // 
            // pnlMenuButtons
            // 
            this.pnlMenuButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(88)))));
            this.pnlMenuButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuButtons.Controls.Add(this.btnOptions);
            this.pnlMenuButtons.Controls.Add(this.btnStart);
            this.pnlMenuButtons.Controls.Add(this.btnResetGame);
            this.pnlMenuButtons.Controls.Add(this.btnExit);
            this.pnlMenuButtons.Location = new System.Drawing.Point(83, 127);
            this.pnlMenuButtons.Name = "pnlMenuButtons";
            this.pnlMenuButtons.Size = new System.Drawing.Size(178, 171);
            this.pnlMenuButtons.TabIndex = 14;
            // 
            // lblButtonDescription
            // 
            this.lblButtonDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(88)))));
            this.lblButtonDescription.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButtonDescription.ForeColor = System.Drawing.Color.Yellow;
            this.lblButtonDescription.Location = new System.Drawing.Point(69, 94);
            this.lblButtonDescription.Name = "lblButtonDescription";
            this.lblButtonDescription.Size = new System.Drawing.Size(206, 25);
            this.lblButtonDescription.TabIndex = 16;
            this.lblButtonDescription.Text = "Main Menu";
            this.lblButtonDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveStatus.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 11.25F);
            this.lblSaveStatus.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaveStatus.Location = new System.Drawing.Point(64, 343);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(275, 19);
            this.lblSaveStatus.TabIndex = 17;
            this.lblSaveStatus.Text = "Loading save...";
            this.lblSaveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HumphreyErik2424RST.Properties.Resources.texGraniteMed;
            this.ClientSize = new System.Drawing.Size(345, 365);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.lblButtonDescription);
            this.Controls.Add(this.picHeaderImage);
            this.Controls.Add(this.pnlMenuButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplashScreen";
            this.Text = "Evolving Level Game - Main Menu";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderImage)).EndInit();
            this.pnlMenuButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picHeaderImage;
        private System.Windows.Forms.Panel pnlMenuButtons;
        private System.Windows.Forms.Label lblButtonDescription;
        private System.Windows.Forms.Label lblSaveStatus;

    }
}

