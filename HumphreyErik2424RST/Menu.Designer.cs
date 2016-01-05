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
            this.grpMainMenu = new System.Windows.Forms.GroupBox();
            this.btnBattle = new System.Windows.Forms.Button();
            this.btnCheats = new System.Windows.Forms.Button();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameEntry = new System.Windows.Forms.TextBox();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoginHeader = new System.Windows.Forms.Label();
            this.grpMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMainMenu
            // 
            this.grpMainMenu.Controls.Add(this.btnBattle);
            this.grpMainMenu.Controls.Add(this.btnCheats);
            this.grpMainMenu.Controls.Add(this.btnResetGame);
            this.grpMainMenu.Controls.Add(this.btnStart);
            this.grpMainMenu.Controls.Add(this.btnExit);
            this.grpMainMenu.Location = new System.Drawing.Point(99, 273);
            this.grpMainMenu.Name = "grpMainMenu";
            this.grpMainMenu.Size = new System.Drawing.Size(547, 203);
            this.grpMainMenu.TabIndex = 10;
            this.grpMainMenu.TabStop = false;
            this.grpMainMenu.Text = "Main Menu";
            // 
            // btnBattle
            // 
            this.btnBattle.Location = new System.Drawing.Point(206, 38);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(78, 69);
            this.btnBattle.TabIndex = 6;
            this.btnBattle.Text = "Battle";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // btnCheats
            // 
            this.btnCheats.Location = new System.Drawing.Point(60, 96);
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
            this.btnResetGame.Location = new System.Drawing.Point(60, 67);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(108, 23);
            this.btnResetGame.TabIndex = 5;
            this.btnResetGame.Text = "Reset game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnExit_Click);
            this.btnResetGame.MouseEnter += new System.EventHandler(this.btnResetGame_MouseEnter);
            this.btnResetGame.MouseLeave += new System.EventHandler(this.MenuButtons_MouseLeave);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(60, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.MenuButtons_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(60, 125);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.MenuButtons_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Evolving Level Game";
            // 
            // txtNameEntry
            // 
            this.txtNameEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(100)))));
            this.txtNameEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEntry.ForeColor = System.Drawing.Color.White;
            this.txtNameEntry.Location = new System.Drawing.Point(113, 42);
            this.txtNameEntry.Name = "txtNameEntry";
            this.txtNameEntry.Size = new System.Drawing.Size(137, 17);
            this.txtNameEntry.TabIndex = 12;
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNameTitle.ForeColor = System.Drawing.Color.White;
            this.lblNameTitle.Location = new System.Drawing.Point(71, 42);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(38, 13);
            this.lblNameTitle.TabIndex = 13;
            this.lblNameTitle.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lblLoginHeader);
            this.panel1.Controls.Add(this.txtNameEntry);
            this.panel1.Controls.Add(this.lblNameTitle);
            this.panel1.Location = new System.Drawing.Point(174, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 133);
            this.panel1.TabIndex = 14;
            // 
            // lblLoginHeader
            // 
            this.lblLoginHeader.AutoSize = true;
            this.lblLoginHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginHeader.ForeColor = System.Drawing.Color.Yellow;
            this.lblLoginHeader.Location = new System.Drawing.Point(68, 14);
            this.lblLoginHeader.Name = "lblLoginHeader";
            this.lblLoginHeader.Size = new System.Drawing.Size(176, 13);
            this.lblLoginHeader.TabIndex = 14;
            this.lblLoginHeader.Text = "Enter your username and password.";
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.grpMainMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMainMenu;
        private System.Windows.Forms.Button btnCheats;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.TextBox txtNameEntry;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoginHeader;

    }
}

