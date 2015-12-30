namespace HumphreyErik2424RST
{
    partial class frmBattle
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
            this.btnTL = new System.Windows.Forms.Button();
            this.btnBR = new System.Windows.Forms.Button();
            this.btnTR = new System.Windows.Forms.Button();
            this.btnBL = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlStuff = new System.Windows.Forms.Panel();
            this.pnlYellow = new System.Windows.Forms.Panel();
            this.pnlWhite = new System.Windows.Forms.Panel();
            this.pnlTurquoise = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblObjective = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlBlack = new System.Windows.Forms.Panel();
            this.tmrFistFlurry = new System.Windows.Forms.Timer(this.components);
            this.tmrGameTicker = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.picSwipe = new System.Windows.Forms.PictureBox();
            this.picPunch = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.pnlGreenPlayer = new System.Windows.Forms.Panel();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.lblHealthPlayer = new System.Windows.Forms.Label();
            this.prgHealthPlayer = new System.Windows.Forms.ProgressBar();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.picPortraitEnemy = new System.Windows.Forms.PictureBox();
            this.pnlGreenEnemy = new System.Windows.Forms.Panel();
            this.pnlEnemy = new System.Windows.Forms.Panel();
            this.prgHealthEnemy = new System.Windows.Forms.ProgressBar();
            this.lblNameEnemy = new System.Windows.Forms.Label();
            this.picPortraitPlayer = new System.Windows.Forms.PictureBox();
            this.tmrAnimationTicker = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pnlActions.SuspendLayout();
            this.pnlStuff.SuspendLayout();
            this.pnlYellow.SuspendLayout();
            this.pnlWhite.SuspendLayout();
            this.pnlTurquoise.SuspendLayout();
            this.pnlBlack.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSwipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPunch)).BeginInit();
            this.pnlGreenPlayer.SuspendLayout();
            this.pnlPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortraitEnemy)).BeginInit();
            this.pnlGreenEnemy.SuspendLayout();
            this.pnlEnemy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortraitPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTL
            // 
            this.btnTL.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTL.Location = new System.Drawing.Point(2, 2);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(178, 40);
            this.btnTL.TabIndex = 9;
            this.btnTL.Text = "FIGHT";
            this.btnTL.UseVisualStyleBackColor = true;
            this.btnTL.Click += new System.EventHandler(this.btnTL_Click);
            this.btnTL.MouseLeave += new System.EventHandler(this.MouseLeavesButton);
            // 
            // btnBR
            // 
            this.btnBR.Enabled = false;
            this.btnBR.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBR.Location = new System.Drawing.Point(180, 42);
            this.btnBR.Name = "btnBR";
            this.btnBR.Size = new System.Drawing.Size(178, 40);
            this.btnBR.TabIndex = 678;
            this.btnBR.UseVisualStyleBackColor = true;
            this.btnBR.Click += new System.EventHandler(this.btnBR_Click);
            this.btnBR.MouseLeave += new System.EventHandler(this.MouseLeavesButton);
            // 
            // btnTR
            // 
            this.btnTR.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTR.Location = new System.Drawing.Point(180, 2);
            this.btnTR.Name = "btnTR";
            this.btnTR.Size = new System.Drawing.Size(178, 40);
            this.btnTR.TabIndex = 78;
            this.btnTR.Text = "FLEE";
            this.btnTR.UseVisualStyleBackColor = true;
            this.btnTR.Click += new System.EventHandler(this.btnTR_Click);
            this.btnTR.MouseLeave += new System.EventHandler(this.MouseLeavesButton);
            // 
            // btnBL
            // 
            this.btnBL.Enabled = false;
            this.btnBL.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBL.Location = new System.Drawing.Point(2, 42);
            this.btnBL.Name = "btnBL";
            this.btnBL.Size = new System.Drawing.Size(178, 40);
            this.btnBL.TabIndex = 456;
            this.btnBL.UseVisualStyleBackColor = true;
            this.btnBL.Click += new System.EventHandler(this.btnBL_Click);
            this.btnBL.MouseLeave += new System.EventHandler(this.MouseLeavesButton);
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(37)))), ((int)(((byte)(122)))));
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Controls.Add(this.pnlStuff);
            this.pnlActions.Location = new System.Drawing.Point(359, 3);
            this.pnlActions.MaximumSize = new System.Drawing.Size(370, 95);
            this.pnlActions.MinimumSize = new System.Drawing.Size(370, 95);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(370, 95);
            this.pnlActions.TabIndex = 4;
            // 
            // pnlStuff
            // 
            this.pnlStuff.BackColor = System.Drawing.Color.White;
            this.pnlStuff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStuff.Controls.Add(this.btnBL);
            this.pnlStuff.Controls.Add(this.btnTL);
            this.pnlStuff.Controls.Add(this.btnBR);
            this.pnlStuff.Controls.Add(this.btnTR);
            this.pnlStuff.Location = new System.Drawing.Point(3, 3);
            this.pnlStuff.Name = "pnlStuff";
            this.pnlStuff.Size = new System.Drawing.Size(362, 87);
            this.pnlStuff.TabIndex = 5;
            // 
            // pnlYellow
            // 
            this.pnlYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(128)))));
            this.pnlYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlYellow.Controls.Add(this.pnlWhite);
            this.pnlYellow.Location = new System.Drawing.Point(3, 3);
            this.pnlYellow.Name = "pnlYellow";
            this.pnlYellow.Size = new System.Drawing.Size(354, 95);
            this.pnlYellow.TabIndex = 8;
            // 
            // pnlWhite
            // 
            this.pnlWhite.BackColor = System.Drawing.Color.White;
            this.pnlWhite.Controls.Add(this.pnlTurquoise);
            this.pnlWhite.Controls.Add(this.lblStatus);
            this.pnlWhite.Location = new System.Drawing.Point(3, 3);
            this.pnlWhite.Name = "pnlWhite";
            this.pnlWhite.Size = new System.Drawing.Size(346, 87);
            this.pnlWhite.TabIndex = 1;
            // 
            // pnlTurquoise
            // 
            this.pnlTurquoise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.pnlTurquoise.Controls.Add(this.label3);
            this.pnlTurquoise.Controls.Add(this.label2);
            this.pnlTurquoise.Controls.Add(this.label1);
            this.pnlTurquoise.Controls.Add(this.lblObjective);
            this.pnlTurquoise.Location = new System.Drawing.Point(3, 3);
            this.pnlTurquoise.Name = "pnlTurquoise";
            this.pnlTurquoise.Size = new System.Drawing.Size(340, 81);
            this.pnlTurquoise.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(174, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "80 / 100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENEMY HP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Difficulty: 1";
            // 
            // lblObjective
            // 
            this.lblObjective.AutoSize = true;
            this.lblObjective.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblObjective.ForeColor = System.Drawing.Color.White;
            this.lblObjective.Location = new System.Drawing.Point(66, 8);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(208, 22);
            this.lblObjective.TabIndex = 0;
            this.lblObjective.Text = "Defeat your ENEMY.";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(54, 31);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(230, 22);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "What will PLAYER do?";
            // 
            // pnlBlack
            // 
            this.pnlBlack.BackColor = System.Drawing.Color.Black;
            this.pnlBlack.Controls.Add(this.pnlActions);
            this.pnlBlack.Controls.Add(this.pnlYellow);
            this.pnlBlack.Location = new System.Drawing.Point(0, 340);
            this.pnlBlack.Name = "pnlBlack";
            this.pnlBlack.Size = new System.Drawing.Size(732, 101);
            this.pnlBlack.TabIndex = 10;
            // 
            // tmrFistFlurry
            // 
            this.tmrFistFlurry.Interval = 140;
            this.tmrFistFlurry.Tick += new System.EventHandler(this.tmrFistFlurry_Tick);
            // 
            // tmrGameTicker
            // 
            this.tmrGameTicker.Interval = 2000;
            this.tmrGameTicker.Tick += new System.EventHandler(this.tmrGameTicker_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImage = global::HumphreyErik2424RST.Properties.Resources.battlebg;
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Controls.Add(this.picSwipe);
            this.pnlTop.Controls.Add(this.picPunch);
            this.pnlTop.Controls.Add(this.lblDescription);
            this.pnlTop.Controls.Add(this.lblStatusBar);
            this.pnlTop.Controls.Add(this.pnlGreenPlayer);
            this.pnlTop.Controls.Add(this.picPortraitEnemy);
            this.pnlTop.Controls.Add(this.pnlGreenEnemy);
            this.pnlTop.Controls.Add(this.picPortraitPlayer);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(732, 344);
            this.pnlTop.TabIndex = 9;
            // 
            // picSwipe
            // 
            this.picSwipe.BackColor = System.Drawing.Color.Transparent;
            this.picSwipe.Image = global::HumphreyErik2424RST.Properties.Resources.imgSwipe1;
            this.picSwipe.Location = new System.Drawing.Point(621, 92);
            this.picSwipe.Name = "picSwipe";
            this.picSwipe.Size = new System.Drawing.Size(84, 111);
            this.picSwipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSwipe.TabIndex = 12;
            this.picSwipe.TabStop = false;
            this.picSwipe.Visible = false;
            // 
            // picPunch
            // 
            this.picPunch.BackColor = System.Drawing.Color.Transparent;
            this.picPunch.Image = global::HumphreyErik2424RST.Properties.Resources.imgFlurryGraphic;
            this.picPunch.Location = new System.Drawing.Point(644, 36);
            this.picPunch.Name = "picPunch";
            this.picPunch.Size = new System.Drawing.Size(50, 50);
            this.picPunch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPunch.TabIndex = 11;
            this.picPunch.TabStop = false;
            this.picPunch.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(462, 325);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(268, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "This label serves as a description of a button\'s function.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescription.Visible = false;
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatusBar.Location = new System.Drawing.Point(0, 0);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(732, 25);
            this.lblStatusBar.TabIndex = 9;
            this.lblStatusBar.Text = "Waiting for player to make their move...";
            this.lblStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGreenPlayer
            // 
            this.pnlGreenPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.pnlGreenPlayer.Controls.Add(this.pnlPlayer);
            this.pnlGreenPlayer.Location = new System.Drawing.Point(277, 247);
            this.pnlGreenPlayer.Name = "pnlGreenPlayer";
            this.pnlGreenPlayer.Size = new System.Drawing.Size(253, 66);
            this.pnlGreenPlayer.TabIndex = 8;
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.pnlPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayer.Controls.Add(this.lblHealthPlayer);
            this.pnlPlayer.Controls.Add(this.prgHealthPlayer);
            this.pnlPlayer.Controls.Add(this.lblNamePlayer);
            this.pnlPlayer.Location = new System.Drawing.Point(3, 3);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(247, 60);
            this.pnlPlayer.TabIndex = 6;
            // 
            // lblHealthPlayer
            // 
            this.lblHealthPlayer.AutoSize = true;
            this.lblHealthPlayer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthPlayer.Location = new System.Drawing.Point(165, 40);
            this.lblHealthPlayer.Name = "lblHealthPlayer";
            this.lblHealthPlayer.Size = new System.Drawing.Size(72, 16);
            this.lblHealthPlayer.TabIndex = 2;
            this.lblHealthPlayer.Text = "26 / 100";
            // 
            // prgHealthPlayer
            // 
            this.prgHealthPlayer.Location = new System.Drawing.Point(7, 27);
            this.prgHealthPlayer.Name = "prgHealthPlayer";
            this.prgHealthPlayer.Size = new System.Drawing.Size(230, 10);
            this.prgHealthPlayer.TabIndex = 1;
            this.prgHealthPlayer.Value = 26;
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNamePlayer.Location = new System.Drawing.Point(3, 4);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(76, 22);
            this.lblNamePlayer.TabIndex = 0;
            this.lblNamePlayer.Text = "PLAYER";
            // 
            // picPortraitEnemy
            // 
            this.picPortraitEnemy.BackColor = System.Drawing.Color.Transparent;
            this.picPortraitEnemy.Image = global::HumphreyErik2424RST.Properties.Resources.enemyplace;
            this.picPortraitEnemy.Location = new System.Drawing.Point(437, 30);
            this.picPortraitEnemy.Name = "picPortraitEnemy";
            this.picPortraitEnemy.Size = new System.Drawing.Size(163, 181);
            this.picPortraitEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPortraitEnemy.TabIndex = 6;
            this.picPortraitEnemy.TabStop = false;
            // 
            // pnlGreenEnemy
            // 
            this.pnlGreenEnemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.pnlGreenEnemy.Controls.Add(this.pnlEnemy);
            this.pnlGreenEnemy.Location = new System.Drawing.Point(228, 61);
            this.pnlGreenEnemy.Name = "pnlGreenEnemy";
            this.pnlGreenEnemy.Size = new System.Drawing.Size(188, 52);
            this.pnlGreenEnemy.TabIndex = 0;
            // 
            // pnlEnemy
            // 
            this.pnlEnemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.pnlEnemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEnemy.Controls.Add(this.prgHealthEnemy);
            this.pnlEnemy.Controls.Add(this.lblNameEnemy);
            this.pnlEnemy.Location = new System.Drawing.Point(3, 3);
            this.pnlEnemy.Name = "pnlEnemy";
            this.pnlEnemy.Size = new System.Drawing.Size(182, 46);
            this.pnlEnemy.TabIndex = 5;
            // 
            // prgHealthEnemy
            // 
            this.prgHealthEnemy.Location = new System.Drawing.Point(7, 27);
            this.prgHealthEnemy.Name = "prgHealthEnemy";
            this.prgHealthEnemy.Size = new System.Drawing.Size(168, 10);
            this.prgHealthEnemy.TabIndex = 1;
            this.prgHealthEnemy.Value = 90;
            // 
            // lblNameEnemy
            // 
            this.lblNameEnemy.AutoSize = true;
            this.lblNameEnemy.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNameEnemy.Location = new System.Drawing.Point(3, 4);
            this.lblNameEnemy.Name = "lblNameEnemy";
            this.lblNameEnemy.Size = new System.Drawing.Size(65, 22);
            this.lblNameEnemy.TabIndex = 0;
            this.lblNameEnemy.Text = "ENEMY";
            // 
            // picPortraitPlayer
            // 
            this.picPortraitPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPortraitPlayer.Image = global::HumphreyErik2424RST.Properties.Resources.sdgsg;
            this.picPortraitPlayer.Location = new System.Drawing.Point(109, 170);
            this.picPortraitPlayer.Name = "picPortraitPlayer";
            this.picPortraitPlayer.Size = new System.Drawing.Size(113, 171);
            this.picPortraitPlayer.TabIndex = 7;
            this.picPortraitPlayer.TabStop = false;
            // 
            // tmrAnimationTicker
            // 
            this.tmrAnimationTicker.Tick += new System.EventHandler(this.tmrAnimationTicker_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 64);
            this.button1.TabIndex = 13;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 441);
            this.Controls.Add(this.pnlBlack);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBattle";
            this.ShowIcon = false;
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.frmBattle_Load);
            this.pnlActions.ResumeLayout(false);
            this.pnlStuff.ResumeLayout(false);
            this.pnlYellow.ResumeLayout(false);
            this.pnlWhite.ResumeLayout(false);
            this.pnlWhite.PerformLayout();
            this.pnlTurquoise.ResumeLayout(false);
            this.pnlTurquoise.PerformLayout();
            this.pnlBlack.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSwipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPunch)).EndInit();
            this.pnlGreenPlayer.ResumeLayout(false);
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortraitEnemy)).EndInit();
            this.pnlGreenEnemy.ResumeLayout(false);
            this.pnlEnemy.ResumeLayout(false);
            this.pnlEnemy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortraitPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTL;
        private System.Windows.Forms.Button btnBR;
        private System.Windows.Forms.Button btnTR;
        private System.Windows.Forms.Button btnBL;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Panel pnlEnemy;
        private System.Windows.Forms.PictureBox picPortraitEnemy;
        private System.Windows.Forms.ProgressBar prgHealthEnemy;
        private System.Windows.Forms.Label lblNameEnemy;
        private System.Windows.Forms.PictureBox picPortraitPlayer;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Label lblHealthPlayer;
        private System.Windows.Forms.ProgressBar prgHealthPlayer;
        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.Panel pnlYellow;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlWhite;
        private System.Windows.Forms.Panel pnlTurquoise;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.Panel pnlStuff;
        private System.Windows.Forms.Panel pnlBlack;
        private System.Windows.Forms.Panel pnlGreenPlayer;
        private System.Windows.Forms.Panel pnlGreenEnemy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatusBar;
        private System.Windows.Forms.Timer tmrFistFlurry;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picPunch;
        private System.Windows.Forms.Timer tmrGameTicker;
        private System.Windows.Forms.PictureBox picSwipe;
        private System.Windows.Forms.Timer tmrAnimationTicker;
        private System.Windows.Forms.Button button1;
    }
}