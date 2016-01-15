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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblAlphanumericProgress = new System.Windows.Forms.Label();
            this.prgLevelProgress = new System.Windows.Forms.ProgressBar();
            this.cboEquippedItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrFishingSpotAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnlGameView = new System.Windows.Forms.Panel();
            this.picFirePit = new System.Windows.Forms.PictureBox();
            this.picFishingSpot = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrFireAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnlGameView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirePit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFishingSpot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Test",
            "Game Llog",
            "Test test test",
            "Foo",
            "Bar",
            "Quaz"});
            this.listBox1.Location = new System.Drawing.Point(-1, 266);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(576, 186);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Hatchet",
            "Tinderbox"});
            this.listBox2.Location = new System.Drawing.Point(607, 168);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(101, 69);
            this.listBox2.TabIndex = 3;
            // 
            // lblAlphanumericProgress
            // 
            this.lblAlphanumericProgress.AutoSize = true;
            this.lblAlphanumericProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphanumericProgress.Location = new System.Drawing.Point(615, 389);
            this.lblAlphanumericProgress.Name = "lblAlphanumericProgress";
            this.lblAlphanumericProgress.Size = new System.Drawing.Size(121, 18);
            this.lblAlphanumericProgress.TabIndex = 9;
            this.lblAlphanumericProgress.Text = "0 / 4 fires created";
            // 
            // prgLevelProgress
            // 
            this.prgLevelProgress.Location = new System.Drawing.Point(597, 350);
            this.prgLevelProgress.Name = "prgLevelProgress";
            this.prgLevelProgress.Size = new System.Drawing.Size(160, 21);
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
            this.pnlGameView.Controls.Add(this.pictureBox2);
            this.pnlGameView.Controls.Add(this.pictureBox1);
            this.pnlGameView.Location = new System.Drawing.Point(-1, 2);
            this.pnlGameView.Name = "pnlGameView";
            this.pnlGameView.Size = new System.Drawing.Size(572, 258);
            this.pnlGameView.TabIndex = 4;
            // 
            // picFirePit
            // 
            this.picFirePit.Image = global::HumphreyErik2424RST.Properties.Resources.imgFirePitLit3;
            this.picFirePit.Location = new System.Drawing.Point(249, 118);
            this.picFirePit.Name = "picFirePit";
            this.picFirePit.Size = new System.Drawing.Size(90, 90);
            this.picFirePit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFirePit.TabIndex = 4;
            this.picFirePit.TabStop = false;
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
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HumphreyErik2424RST.Properties.Resources.imgSurvivalWater;
            this.pictureBox2.Location = new System.Drawing.Point(0, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HumphreyErik2424RST.Properties.Resources.tree;
            this.pictureBox1.Location = new System.Drawing.Point(384, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tmrFireAnimation
            // 
            this.tmrFireAnimation.Tick += new System.EventHandler(this.tmrFireAnimation_Tick);
            // 
            // frmSurvival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEquippedItem);
            this.Controls.Add(this.lblAlphanumericProgress);
            this.Controls.Add(this.pnlGameView);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.prgLevelProgress);
            this.Name = "frmSurvival";
            this.Text = "Survival";
            this.Load += new System.EventHandler(this.frmSurvival_Load);
            this.pnlGameView.ResumeLayout(false);
            this.pnlGameView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirePit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFishingSpot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel pnlGameView;
        private System.Windows.Forms.Label lblAlphanumericProgress;
        private System.Windows.Forms.ProgressBar prgLevelProgress;
        private System.Windows.Forms.ComboBox cboEquippedItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picFishingSpot;
        private System.Windows.Forms.Timer tmrFishingSpotAnimation;
        private System.Windows.Forms.PictureBox picFirePit;
        private System.Windows.Forms.Timer tmrFireAnimation;
    }
}