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
            this.btnFight = new System.Windows.Forms.Button();
            this.btnFlee = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlEnemy = new System.Windows.Forms.Panel();
            this.lblNameEnemy = new System.Windows.Forms.Label();
            this.prgHealthEnemy = new System.Windows.Forms.ProgressBar();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.lblHealthPlayer = new System.Windows.Forms.Label();
            this.prgHealthPlayer = new System.Windows.Forms.ProgressBar();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.pnlYellow = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.picPortraitPlayer = new System.Windows.Forms.PictureBox();
            this.picPortraitEnemy = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlWhite = new System.Windows.Forms.Panel();
            this.pnlTurquoise = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBlack = new System.Windows.Forms.Panel();
            this.pnlStuff = new System.Windows.Forms.Panel();
            this.pnlGreenEnemy = new System.Windows.Forms.Panel();
            this.pnlGreenPlayer = new System.Windows.Forms.Panel();
            this.pnlActions.SuspendLayout();
            this.pnlEnemy.SuspendLayout();
            this.pnlPlayer.SuspendLayout();
            this.pnlYellow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortraitPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortraitEnemy)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlWhite.SuspendLayout();
            this.pnlTurquoise.SuspendLayout();
            this.pnlBlack.SuspendLayout();
            this.pnlStuff.SuspendLayout();
            this.pnlGreenEnemy.SuspendLayout();
            this.pnlGreenPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFight
            // 
            this.btnFight.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFight.Location = new System.Drawing.Point(2, 2);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(178, 40);
            this.btnFight.TabIndex = 0;
            this.btnFight.Text = "FIGHT";
            this.btnFight.UseVisualStyleBackColor = true;
            // 
            // btnFlee
            // 
            this.btnFlee.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlee.Location = new System.Drawing.Point(180, 42);
            this.btnFlee.Name = "btnFlee";
            this.btnFlee.Size = new System.Drawing.Size(178, 40);
            this.btnFlee.TabIndex = 1;
            this.btnFlee.Text = "FLEE";
            this.btnFlee.UseVisualStyleBackColor = true;
            this.btnFlee.Click += new System.EventHandler(this.Flee);
            // 
            // btnItems
            // 
            this.btnItems.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Location = new System.Drawing.Point(180, 2);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(178, 40);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "ITEMS";
            this.btnItems.UseVisualStyleBackColor = true;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(2, 42);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(178, 40);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "SWITCH";
            this.btnSwitch.UseVisualStyleBackColor = true;
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
            // prgHealthEnemy
            // 
            this.prgHealthEnemy.Location = new System.Drawing.Point(7, 27);
            this.prgHealthEnemy.Name = "prgHealthEnemy";
            this.prgHealthEnemy.Size = new System.Drawing.Size(168, 10);
            this.prgHealthEnemy.TabIndex = 1;
            this.prgHealthEnemy.Value = 90;
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
            // picPortraitEnemy
            // 
            this.picPortraitEnemy.BackColor = System.Drawing.Color.Transparent;
            this.picPortraitEnemy.Image = global::HumphreyErik2424RST.Properties.Resources.enemyplace;
            this.picPortraitEnemy.Location = new System.Drawing.Point(480, 61);
            this.picPortraitEnemy.Name = "picPortraitEnemy";
            this.picPortraitEnemy.Size = new System.Drawing.Size(84, 111);
            this.picPortraitEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPortraitEnemy.TabIndex = 6;
            this.picPortraitEnemy.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImage = global::HumphreyErik2424RST.Properties.Resources.battlebg;
            this.pnlTop.Controls.Add(this.pnlGreenPlayer);
            this.pnlTop.Controls.Add(this.picPortraitEnemy);
            this.pnlTop.Controls.Add(this.pnlGreenEnemy);
            this.pnlTop.Controls.Add(this.picPortraitPlayer);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(732, 341);
            this.pnlTop.TabIndex = 9;
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
            this.pnlTurquoise.Controls.Add(this.label1);
            this.pnlTurquoise.Location = new System.Drawing.Point(3, 3);
            this.pnlTurquoise.Name = "pnlTurquoise";
            this.pnlTurquoise.Size = new System.Drawing.Size(340, 81);
            this.pnlTurquoise.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "What will PLAYER do?";
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
            // pnlStuff
            // 
            this.pnlStuff.BackColor = System.Drawing.Color.White;
            this.pnlStuff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStuff.Controls.Add(this.btnSwitch);
            this.pnlStuff.Controls.Add(this.btnFight);
            this.pnlStuff.Controls.Add(this.btnFlee);
            this.pnlStuff.Controls.Add(this.btnItems);
            this.pnlStuff.Location = new System.Drawing.Point(3, 3);
            this.pnlStuff.Name = "pnlStuff";
            this.pnlStuff.Size = new System.Drawing.Size(362, 87);
            this.pnlStuff.TabIndex = 5;
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
            // pnlGreenPlayer
            // 
            this.pnlGreenPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.pnlGreenPlayer.Controls.Add(this.pnlPlayer);
            this.pnlGreenPlayer.Location = new System.Drawing.Point(277, 247);
            this.pnlGreenPlayer.Name = "pnlGreenPlayer";
            this.pnlGreenPlayer.Size = new System.Drawing.Size(253, 66);
            this.pnlGreenPlayer.TabIndex = 8;
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
            this.ShowInTaskbar = false;
            this.Text = "Battle";
            this.pnlActions.ResumeLayout(false);
            this.pnlEnemy.ResumeLayout(false);
            this.pnlEnemy.PerformLayout();
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            this.pnlYellow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPortraitPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortraitEnemy)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlWhite.ResumeLayout(false);
            this.pnlWhite.PerformLayout();
            this.pnlTurquoise.ResumeLayout(false);
            this.pnlTurquoise.PerformLayout();
            this.pnlBlack.ResumeLayout(false);
            this.pnlStuff.ResumeLayout(false);
            this.pnlGreenEnemy.ResumeLayout(false);
            this.pnlGreenPlayer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.Button btnFlee;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnSwitch;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlStuff;
        private System.Windows.Forms.Panel pnlBlack;
        private System.Windows.Forms.Panel pnlGreenPlayer;
        private System.Windows.Forms.Panel pnlGreenEnemy;
    }
}