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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSurvival));
            this.lstGameLog = new System.Windows.Forms.ListBox();
            this.prgTreeGrowth = new System.Windows.Forms.ProgressBar();
            this.tmrFishingSpotAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnlGameView = new System.Windows.Forms.Panel();
            this.prgFireFuel = new System.Windows.Forms.ProgressBar();
            this.picFirePit = new System.Windows.Forms.PictureBox();
            this.picFishingSpot = new System.Windows.Forms.PictureBox();
            this.picWater = new System.Windows.Forms.PictureBox();
            this.picTree = new System.Windows.Forms.PictureBox();
            this.tmrFireAnimation = new System.Windows.Forms.Timer(this.components);
            this.tmrActionWait = new System.Windows.Forms.Timer(this.components);
            this.tmrRegrow = new System.Windows.Forms.Timer(this.components);
            this.pnlSideView = new System.Windows.Forms.Panel();
            this.prgFishRespawn = new System.Windows.Forms.ProgressBar();
            this.picFishingSpotSide = new System.Windows.Forms.PictureBox();
            this.picFishingLine = new System.Windows.Forms.PictureBox();
            this.picFish = new System.Windows.Forms.PictureBox();
            this.picFireSide = new System.Windows.Forms.PictureBox();
            this.picTreeSide = new System.Windows.Forms.PictureBox();
            this.tmrFishMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrBonusPointsDecay = new System.Windows.Forms.Timer(this.components);
            this.tmrFishingDelay = new System.Windows.Forms.Timer(this.components);
            this.tmrFishRespawn = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBonusPointsCounter = new System.Windows.Forms.Label();
            this.lblBonusPoints = new System.Windows.Forms.Label();
            this.lblFishCookedCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblItemTitle = new System.Windows.Forms.Label();
            this.cboEquippedItem = new System.Windows.Forms.ComboBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlGameView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirePit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFishingSpot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTree)).BeginInit();
            this.pnlSideView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFishingSpotSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFishingLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFireSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeSide)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGameLog
            // 
            this.lstGameLog.BackColor = System.Drawing.Color.Bisque;
            this.lstGameLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstGameLog.FormattingEnabled = true;
            this.lstGameLog.Items.AddRange(new object[] {
            " "});
            this.lstGameLog.Location = new System.Drawing.Point(0, 240);
            this.lstGameLog.Name = "lstGameLog";
            this.lstGameLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstGameLog.Size = new System.Drawing.Size(571, 195);
            this.lstGameLog.TabIndex = 0;
            // 
            // prgTreeGrowth
            // 
            this.prgTreeGrowth.Location = new System.Drawing.Point(392, 186);
            this.prgTreeGrowth.Maximum = 2000;
            this.prgTreeGrowth.Name = "prgTreeGrowth";
            this.prgTreeGrowth.Size = new System.Drawing.Size(112, 10);
            this.prgTreeGrowth.TabIndex = 7;
            this.prgTreeGrowth.Visible = false;
            // 
            // tmrFishingSpotAnimation
            // 
            this.tmrFishingSpotAnimation.Interval = 320;
            this.tmrFishingSpotAnimation.Tick += new System.EventHandler(this.tmrFishingSpotAnimation_Tick);
            // 
            // pnlGameView
            // 
            this.pnlGameView.BackColor = System.Drawing.Color.Transparent;
            this.pnlGameView.BackgroundImage = global::HumphreyErik2424RST.Properties.Resources.imgSurvivalHorizon;
            this.pnlGameView.Controls.Add(this.prgFireFuel);
            this.pnlGameView.Controls.Add(this.prgTreeGrowth);
            this.pnlGameView.Controls.Add(this.picFirePit);
            this.pnlGameView.Controls.Add(this.picFishingSpot);
            this.pnlGameView.Controls.Add(this.picWater);
            this.pnlGameView.Controls.Add(this.picTree);
            this.pnlGameView.Location = new System.Drawing.Point(0, 0);
            this.pnlGameView.Name = "pnlGameView";
            this.pnlGameView.Size = new System.Drawing.Size(570, 255);
            this.pnlGameView.TabIndex = 4;
            // 
            // prgFireFuel
            // 
            this.prgFireFuel.Location = new System.Drawing.Point(254, 225);
            this.prgFireFuel.Maximum = 2000;
            this.prgFireFuel.Name = "prgFireFuel";
            this.prgFireFuel.Size = new System.Drawing.Size(79, 10);
            this.prgFireFuel.TabIndex = 8;
            this.prgFireFuel.Visible = false;
            // 
            // picFirePit
            // 
            this.picFirePit.Image = global::HumphreyErik2424RST.Properties.Resources.imgFirePitEmpty;
            this.picFirePit.Location = new System.Drawing.Point(247, 129);
            this.picFirePit.Name = "picFirePit";
            this.picFirePit.Size = new System.Drawing.Size(90, 90);
            this.picFirePit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFirePit.TabIndex = 4;
            this.picFirePit.TabStop = false;
            this.picFirePit.Click += new System.EventHandler(this.picFirePit_Click);
            this.picFirePit.MouseLeave += new System.EventHandler(this.clickableLeave);
            // 
            // picFishingSpot
            // 
            this.picFishingSpot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.picFishingSpot.Image = global::HumphreyErik2424RST.Properties.Resources.imgWaterAnimation3;
            this.picFishingSpot.Location = new System.Drawing.Point(103, 201);
            this.picFishingSpot.Name = "picFishingSpot";
            this.picFishingSpot.Size = new System.Drawing.Size(50, 48);
            this.picFishingSpot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFishingSpot.TabIndex = 3;
            this.picFishingSpot.TabStop = false;
            this.picFishingSpot.Click += new System.EventHandler(this.picFishingSpot_Click);
            this.picFishingSpot.MouseLeave += new System.EventHandler(this.clickableLeave);
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
            this.picTree.MouseLeave += new System.EventHandler(this.clickableLeave);
            // 
            // tmrFireAnimation
            // 
            this.tmrFireAnimation.Tick += new System.EventHandler(this.tmrFireAnimation_Tick);
            // 
            // tmrRegrow
            // 
            this.tmrRegrow.Tick += new System.EventHandler(this.tmrRegrow_Tick);
            // 
            // pnlSideView
            // 
            this.pnlSideView.BackgroundImage = global::HumphreyErik2424RST.Properties.Resources.imgSideView;
            this.pnlSideView.Controls.Add(this.prgFishRespawn);
            this.pnlSideView.Controls.Add(this.picFishingSpotSide);
            this.pnlSideView.Controls.Add(this.picFishingLine);
            this.pnlSideView.Controls.Add(this.picFish);
            this.pnlSideView.Controls.Add(this.picFireSide);
            this.pnlSideView.Controls.Add(this.picTreeSide);
            this.pnlSideView.Location = new System.Drawing.Point(571, 255);
            this.pnlSideView.Name = "pnlSideView";
            this.pnlSideView.Size = new System.Drawing.Size(248, 181);
            this.pnlSideView.TabIndex = 14;
            // 
            // prgFishRespawn
            // 
            this.prgFishRespawn.Location = new System.Drawing.Point(85, 158);
            this.prgFishRespawn.Maximum = 2000;
            this.prgFishRespawn.Name = "prgFishRespawn";
            this.prgFishRespawn.Size = new System.Drawing.Size(79, 10);
            this.prgFishRespawn.TabIndex = 9;
            this.prgFishRespawn.Visible = false;
            // 
            // picFishingSpotSide
            // 
            this.picFishingSpotSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.picFishingSpotSide.Image = global::HumphreyErik2424RST.Properties.Resources.imgWaterAnimation3;
            this.picFishingSpotSide.Location = new System.Drawing.Point(160, 62);
            this.picFishingSpotSide.Name = "picFishingSpotSide";
            this.picFishingSpotSide.Size = new System.Drawing.Size(72, 14);
            this.picFishingSpotSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFishingSpotSide.TabIndex = 9;
            this.picFishingSpotSide.TabStop = false;
            // 
            // picFishingLine
            // 
            this.picFishingLine.BackColor = System.Drawing.Color.Transparent;
            this.picFishingLine.Image = global::HumphreyErik2424RST.Properties.Resources.imgSurvivalFishingLine;
            this.picFishingLine.Location = new System.Drawing.Point(194, 62);
            this.picFishingLine.Name = "picFishingLine";
            this.picFishingLine.Size = new System.Drawing.Size(4, 131);
            this.picFishingLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFishingLine.TabIndex = 11;
            this.picFishingLine.TabStop = false;
            this.picFishingLine.Visible = false;
            // 
            // picFish
            // 
            this.picFish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.picFish.Image = global::HumphreyErik2424RST.Properties.Resources.imgFishSmallBack;
            this.picFish.Location = new System.Drawing.Point(16, 108);
            this.picFish.Name = "picFish";
            this.picFish.Size = new System.Drawing.Size(41, 24);
            this.picFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFish.TabIndex = 10;
            this.picFish.TabStop = false;
            // 
            // picFireSide
            // 
            this.picFireSide.BackColor = System.Drawing.Color.Transparent;
            this.picFireSide.Image = global::HumphreyErik2424RST.Properties.Resources.imgFirePitEmpty;
            this.picFireSide.Location = new System.Drawing.Point(103, 29);
            this.picFireSide.Name = "picFireSide";
            this.picFireSide.Size = new System.Drawing.Size(25, 39);
            this.picFireSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFireSide.TabIndex = 9;
            this.picFireSide.TabStop = false;
            // 
            // picTreeSide
            // 
            this.picTreeSide.BackColor = System.Drawing.Color.Transparent;
            this.picTreeSide.Image = global::HumphreyErik2424RST.Properties.Resources.tree;
            this.picTreeSide.Location = new System.Drawing.Point(25, 7);
            this.picTreeSide.Name = "picTreeSide";
            this.picTreeSide.Size = new System.Drawing.Size(35, 50);
            this.picTreeSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTreeSide.TabIndex = 9;
            this.picTreeSide.TabStop = false;
            // 
            // tmrFishMovement
            // 
            this.tmrFishMovement.Interval = 27;
            this.tmrFishMovement.Tick += new System.EventHandler(this.tmrFishMovement_Tick);
            // 
            // tmrBonusPointsDecay
            // 
            this.tmrBonusPointsDecay.Interval = 2;
            this.tmrBonusPointsDecay.Tick += new System.EventHandler(this.tmrBonusPointsDecay_Tick);
            // 
            // tmrFishingDelay
            // 
            this.tmrFishingDelay.Interval = 3000;
            this.tmrFishingDelay.Tick += new System.EventHandler(this.tmrFishingDelay_Tick);
            // 
            // tmrFishRespawn
            // 
            this.tmrFishRespawn.Tick += new System.EventHandler(this.tmrFishRespawn_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.lblBonusPointsCounter);
            this.panel1.Controls.Add(this.lblBonusPoints);
            this.panel1.Controls.Add(this.lblFishCookedCounter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblItemTitle);
            this.panel1.Controls.Add(this.cboEquippedItem);
            this.panel1.Location = new System.Drawing.Point(571, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 254);
            this.panel1.TabIndex = 15;
            // 
            // lblBonusPointsCounter
            // 
            this.lblBonusPointsCounter.BackColor = System.Drawing.Color.White;
            this.lblBonusPointsCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBonusPointsCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBonusPointsCounter.Location = new System.Drawing.Point(96, 174);
            this.lblBonusPointsCounter.Name = "lblBonusPointsCounter";
            this.lblBonusPointsCounter.Size = new System.Drawing.Size(59, 20);
            this.lblBonusPointsCounter.TabIndex = 25;
            this.lblBonusPointsCounter.Text = "0";
            this.lblBonusPointsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBonusPoints
            // 
            this.lblBonusPoints.AutoSize = true;
            this.lblBonusPoints.Font = new System.Drawing.Font("Myriad Web Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonusPoints.Location = new System.Drawing.Point(74, 157);
            this.lblBonusPoints.Name = "lblBonusPoints";
            this.lblBonusPoints.Size = new System.Drawing.Size(112, 14);
            this.lblBonusPoints.TabIndex = 24;
            this.lblBonusPoints.Text = "BONUS CREDITS";
            // 
            // lblFishCookedCounter
            // 
            this.lblFishCookedCounter.BackColor = System.Drawing.Color.White;
            this.lblFishCookedCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFishCookedCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFishCookedCounter.Location = new System.Drawing.Point(96, 124);
            this.lblFishCookedCounter.Name = "lblFishCookedCounter";
            this.lblFishCookedCounter.Size = new System.Drawing.Size(59, 20);
            this.lblFishCookedCounter.TabIndex = 23;
            this.lblFishCookedCounter.Text = "0 / 5";
            this.lblFishCookedCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Web Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "FISH COOKED";
            // 
            // lblItemTitle
            // 
            this.lblItemTitle.AutoSize = true;
            this.lblItemTitle.Font = new System.Drawing.Font("Myriad Web Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemTitle.Location = new System.Drawing.Point(74, 59);
            this.lblItemTitle.Name = "lblItemTitle";
            this.lblItemTitle.Size = new System.Drawing.Size(109, 14);
            this.lblItemTitle.TabIndex = 21;
            this.lblItemTitle.Text = "EQUIPPED ITEM";
            // 
            // cboEquippedItem
            // 
            this.cboEquippedItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquippedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEquippedItem.Font = new System.Drawing.Font("Myriad Web Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEquippedItem.FormattingEnabled = true;
            this.cboEquippedItem.Location = new System.Drawing.Point(64, 77);
            this.cboEquippedItem.Name = "cboEquippedItem";
            this.cboEquippedItem.Size = new System.Drawing.Size(121, 20);
            this.cboEquippedItem.TabIndex = 20;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(217, 224);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 25);
            this.btnHelp.TabIndex = 26;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmSurvival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGameView);
            this.Controls.Add(this.pnlSideView);
            this.Controls.Add(this.lstGameLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSurvival";
            this.Text = "Evolving Level Game - Survival - Difficulty: 1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSurvival_FormClosed);
            this.Load += new System.EventHandler(this.frmSurvival_Load);
            this.pnlGameView.ResumeLayout(false);
            this.pnlGameView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirePit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFishingSpot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTree)).EndInit();
            this.pnlSideView.ResumeLayout(false);
            this.pnlSideView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFishingSpotSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFishingLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFireSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeSide)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstGameLog;
        private System.Windows.Forms.PictureBox picTree;
        private System.Windows.Forms.Panel pnlGameView;
        private System.Windows.Forms.ProgressBar prgTreeGrowth;
        private System.Windows.Forms.PictureBox picWater;
        private System.Windows.Forms.PictureBox picFishingSpot;
        private System.Windows.Forms.Timer tmrFishingSpotAnimation;
        private System.Windows.Forms.PictureBox picFirePit;
        private System.Windows.Forms.Timer tmrFireAnimation;
        private System.Windows.Forms.Timer tmrActionWait;
        private System.Windows.Forms.Timer tmrRegrow;
        private System.Windows.Forms.ProgressBar prgFireFuel;
        private System.Windows.Forms.Panel pnlSideView;
        private System.Windows.Forms.PictureBox picFireSide;
        private System.Windows.Forms.PictureBox picTreeSide;
        private System.Windows.Forms.PictureBox picFishingSpotSide;
        private System.Windows.Forms.PictureBox picFish;
        private System.Windows.Forms.Timer tmrFishMovement;
        private System.Windows.Forms.Timer tmrBonusPointsDecay;
        private System.Windows.Forms.PictureBox picFishingLine;
        private System.Windows.Forms.Timer tmrFishingDelay;
        private System.Windows.Forms.ProgressBar prgFishRespawn;
        private System.Windows.Forms.Timer tmrFishRespawn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBonusPointsCounter;
        private System.Windows.Forms.Label lblBonusPoints;
        private System.Windows.Forms.Label lblFishCookedCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItemTitle;
        private System.Windows.Forms.ComboBox cboEquippedItem;
        private System.Windows.Forms.Button btnHelp;
    }
}