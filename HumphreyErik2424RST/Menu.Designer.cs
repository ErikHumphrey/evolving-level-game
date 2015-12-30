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
            this.btnCheats = new System.Windows.Forms.Button();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBattle = new System.Windows.Forms.Button();
            this.grpMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMainMenu
            // 
            this.grpMainMenu.Controls.Add(this.btnBattle);
            this.grpMainMenu.Controls.Add(this.btnCheats);
            this.grpMainMenu.Controls.Add(this.btnResetGame);
            this.grpMainMenu.Controls.Add(this.btnStart);
            this.grpMainMenu.Controls.Add(this.btnExit);
            this.grpMainMenu.Location = new System.Drawing.Point(23, 51);
            this.grpMainMenu.Name = "grpMainMenu";
            this.grpMainMenu.Size = new System.Drawing.Size(344, 243);
            this.grpMainMenu.TabIndex = 10;
            this.grpMainMenu.TabStop = false;
            this.grpMainMenu.Text = "Main Menu";
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
            this.label1.Location = new System.Drawing.Point(58, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "RST Title";
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
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.Text = "Splash Screen";
            this.grpMainMenu.ResumeLayout(false);
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

    }
}

