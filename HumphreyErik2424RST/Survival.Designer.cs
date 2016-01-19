namespace HumphreyErik2424RST
{
    partial class frmSurvival
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
            this.lstGameLog = new System.Windows.Forms.ListBox();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.lblAlphanumericProgress = new System.Windows.Forms.Label();
            this.prgLevelProgress = new System.Windows.Forms.ProgressBar();
            this.cboEquippedItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrFishingSpotAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnlGameView = new System.Windows.Forms.Panel();
            this.picFirePit = new System.Windows.Forms.PictureBox();
            this.picFishingSpot = new System.Windows.Forms.PictureBox();
            this.picWater = new System.Windows.Forms.PictureBox();
            this.picTree = new System.Windows.Forms.PictureBox();
            this.tmrFireAnimation = new System.Windows.Forms.Timer(this.components);
            this.tmrActionWait = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmrRegrow = new System.Windows.Forms.Timer(this.components);
            this.pnlGameView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirePit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFishingSpot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTree)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGameLog
            // 
            this.lstGameLog.FormattingEnabled = true;
            this.lstGameLog.Items.AddRange(new object[] {
            "Test",
            "Game Llog",
            "Test test test",
            "Foo",
            "Bar",
            "Quaz"});
            this.lstGameLog.Location = new System.Drawing.Point(-1, 266);
            this.lstGameLog.Name = "lstGameLog";
            this.lstGameLog.Size = new System.Drawing.Size(576, 186);
            this.lstGameLog.TabIndex = 0;
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.Items.AddRange(new object[] {
            "Hatchet",
            "Tinderbox"});
            this.lstInventory.Location = new System.Drawing.Point(577, 95);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(180, 160);
            this.lstInventory.TabIndex = 3;
            // 
            // lblAlphanumericProgress
            // 
            this.lblAlphanumericProgress.AutoSize = true;
            this.lblAlphanumericProgress.Font = new System.Drawing.Font("Myriad Web Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphanumericProgress.Location = new System.Drawing.Point(594, 270);
            this.lblAlphanumericProgress.Name = "lblAlphanumericProgress";
            this.lblAlphanumericProgress.Size = new System.Drawing.Size(88, 17);
            this.lblAlphanumericProgress.TabIndex = 9;
            this.lblAlphanumericProgress.Text = "Tree growth";
            // 
            // prgLevelProgress
            // 
            this.prgLevelProgress.Location = new System.Drawing.Point(597, 291);
            this.prgLevelProgress.Name = "prgLevelProgress";
            this.prgLevelProgress.Size = new System.Drawing.Size(160, 12);
            this.prgLevelProgress.TabIndex = 7;
            this.prgLevelProgress.Value = 60;
            // 
            // cboEquippedItem
            // 
            this.cboEquippedItem.FormattingEnabled = true;
            this.cboEquippedItem.Location = new System.Drawing.Point(598, 59);
            this.cboEquippedItem.Name = "cboEquippedItem";
            this.cboEquippedItem.Size = new System.Drawing.Size(121, 21);
            this.cboEquippedItem.TabIndex = 10;
            this.cboEquippedItem.Text = "Empty hands";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Equipped item";
            // 
            // tmrFishingSpotAnimation
            // 
            this.tmrFishingSpotAnimation.Interval = 450;
            this.tmrFishingSpotAnimation.Tick += new System.EventHandler(this.tmrFishingSpotAnimation_Tick);
            // 
            // pnlGameView
            // 
            this.pnlGameView.BackColor = System.Drawing.Color.Transparent;
            this.pnlGameView.BackgroundImage = global::HumphreyErik2424RST.Properties.Resources.imgSurvivalHorizon;
            this.pnlGameView.Controls.Add(this.picFirePit);
            this.pnlGameView.Controls.Add(this.picFishingSpot);
            this.pnlGameView.Controls.Add(this.picWater);
            this.pnlGameView.Controls.Add(this.picTree);
            this.pnlGameView.Location = new System.Drawing.Point(-1, 2);
            this.pnlGameView.Name = "pnlGameView";
            this.pnlGameView.Size = new System.Drawing.Size(572, 258);
            this.pnlGameView.TabIndex = 4;
            // 
            // picFirePit
            // 
            this.picFirePit.Image = global::HumphreyErik2424RST.Properties.Resources.imgFirePitEmpty;
            this.picFirePit.Location = new System.Drawing.Point(249, 118);
            this.picFirePit.Name = "picFirePit";
            this.picFirePit.Size = new System.Drawing.Size(90, 90);
            this.picFirePit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFirePit.TabIndex = 4;
            this.picFirePit.TabStop = false;
            this.picFirePit.Click += new System.EventHandler(this.picFirePit_Click);
            this.picFirePit.MouseEnter += new System.EventHandler(this.clickableEnter);
            // 
            // picFishingSpot
            // 
            this.picFishingSpot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.picFishingSpot.Image = global::HumphreyErik2424RST.Properties.Resources.imgWaterAnimation3;
            this.picFishingSpot.Location = new System.Drawing.Point(113, 173);
            this.picFishingSpot.Name = "picFishingSpot";
            this.picFishingSpot.Size = new System.Drawing.Size(50, 48);
            this.picFishingSpot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFishingSpot.TabIndex = 3;
            this.picFishingSpot.TabStop = false;
            this.picFishingSpot.MouseEnter += new System.EventHandler(this.clickableEnter);
            // 
            // picWater
            // 
            this.picWater.Image = global::HumphreyErik2424RST.Properties.Resources.imgSurvivalWater;
            this.picWater.Location = new System.Drawing.Point(0, 154);
            this.picWater.Name = "picWater";
            this.picWater.Size = new System.Drawing.Size(213, 100);
            this.picWater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picWater.TabIndex = 2;
            this.picWater.TabStop = false;
            // 
            // picTree
            // 
            this.picTree.BackColor = System.Drawing.Color.Transparent;
            this.picTree.Image = global::HumphreyErik2424RST.Properties.Resources.tree;
            this.picTree.Location = new System.Drawing.Point(384, 10);
            this.picTree.Name = "picTree";
            this.picTree.Size = new System.Drawing.Size(133, 174);
            this.picTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTree.TabIndex = 1;
            this.picTree.TabStop = false;
            this.picTree.Click += new System.EventHandler(this.picTree_Click);
            this.picTree.MouseEnter += new System.EventHandler(this.clickableEnter);
            // 
            // tmrFireAnimation
            // 
            this.tmrFireAnimation.Tick += new System.EventHandler(this.tmrFireAnimation_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Web Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fire fuel";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(599, 377);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(160, 12);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Value = 60;
            // 
            // tmrRegrow
            // 
            this.tmrRegrow.Tick += new System.EventHandler(this.tmrRegrow_Tick);
            // 
            // frmSurvival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEquippedItem);
            this.Controls.Add(this.lblAlphanumericProgress);
            this.Controls.Add(this.pnlGameView);
            this.Controls.Add(this.lstInventory);
            this.Controls.Add(this.lstGameLog);
            this.Controls.Add(this.prgLevelProgress);
            this.Name = "frmSurvival";
            this.Text = "Survival";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSurvival_FormClosed);
            this.Load += new System.EventHandler(this.frmSurvival_Load);
            this.pnlGameView.ResumeLayout(false);
            this.pnlGameView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirePit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFishingSpot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGameLog;
        private System.Windows.Forms.PictureBox picTree;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.Panel pnlGameView;
        private System.Windows.Forms.Label lblAlphanumericProgress;
        private System.Windows.Forms.ProgressBar prgLevelProgress;
        private System.Windows.Forms.ComboBox cboEquippedItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picWater;
        private System.Windows.Forms.PictureBox picFishingSpot;
        private System.Windows.Forms.Timer tmrFishingSpotAnimation;
        private System.Windows.Forms.PictureBox picFirePit;
        private System.Windows.Forms.Timer tmrFireAnimation;
        private System.Windows.Forms.Timer tmrActionWait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer tmrRegrow;
    }
}