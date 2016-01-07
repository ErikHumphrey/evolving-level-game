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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.btnCheats = new System.Windows.Forms.Button();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBattle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblButtonDescription = new System.Windows.Forms.Label();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.tmrSaveLoader = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheats
            // 
            this.btnCheats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(101)))));
            this.btnCheats.FlatAppearance.BorderSize = 2;
            this.btnCheats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheats.ForeColor = System.Drawing.Color.White;
            this.btnCheats.Image = ((System.Drawing.Image)(resources.GetObject("btnCheats.Image")));
            this.btnCheats.Location = new System.Drawing.Point(34, 87);
            this.btnCheats.Name = "btnCheats";
            this.btnCheats.Size = new System.Drawing.Size(108, 23);
            this.btnCheats.TabIndex = 2;
            this.btnCheats.Text = "Cheats";
            this.btnCheats.UseVisualStyleBackColor = true;
            this.btnCheats.Click += new System.EventHandler(this.btnExit_Click);
            this.btnCheats.MouseEnter += new System.EventHandler(this.btnCheats_MouseEnter);
            this.btnCheats.MouseLeave += new System.EventHandler(this.MenuButtons_MouseLeave);
            // 
            // btnResetGame
            // 
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
            this.btnStart.Text = "New game";
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HumphreyErik2424RST.Properties.Resources.imgBannerImproved;
            this.pictureBox1.Location = new System.Drawing.Point(21, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnBattle
            // 
            this.btnBattle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBattle.ForeColor = System.Drawing.Color.White;
            this.btnBattle.Image = ((System.Drawing.Image)(resources.GetObject("btnBattle.Image")));
            this.btnBattle.Location = new System.Drawing.Point(21, 181);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(78, 69);
            this.btnBattle.TabIndex = 6;
            this.btnBattle.Text = "Battle";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(88)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCheats);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnResetGame);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(105, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 171);
            this.panel1.TabIndex = 14;
            // 
            // lblButtonDescription
            // 
            this.lblButtonDescription.AutoSize = true;
            this.lblButtonDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblButtonDescription.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButtonDescription.ForeColor = System.Drawing.Color.Yellow;
            this.lblButtonDescription.Location = new System.Drawing.Point(109, 98);
            this.lblButtonDescription.Name = "lblButtonDescription";
            this.lblButtonDescription.Size = new System.Drawing.Size(41, 16);
            this.lblButtonDescription.TabIndex = 16;
            this.lblButtonDescription.Text = "label1";
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveStatus.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaveStatus.Location = new System.Drawing.Point(188, 343);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(72, 13);
            this.lblSaveStatus.TabIndex = 17;
            this.lblSaveStatus.Text = "Loaded save:";
            // 
            // tmrSaveLoader
            // 
            this.tmrSaveLoader.Tick += new System.EventHandler(this.tmrSaveLoader_Tick);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(140, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "literally crash the program";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HumphreyErik2424RST.Properties.Resources.texGraniteMed;
            this.ClientSize = new System.Drawing.Size(345, 365);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.lblButtonDescription);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheats;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblButtonDescription;
        private System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.Timer tmrSaveLoader;
        private System.Windows.Forms.Button button2;

    }
}

