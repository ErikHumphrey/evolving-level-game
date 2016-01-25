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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattle));
            this.btnTL = new System.Windows.Forms.Button();
            this.btnBR = new System.Windows.Forms.Button();
            this.btnTR = new System.Windows.Forms.Button();
            this.btnBL = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlStuff = new System.Windows.Forms.Panel();
            this.pnlYellow = new System.Windows.Forms.Panel();
            this.pnlWhite = new System.Windows.Forms.Panel();
            this.pnlTurquoise = new System.Windows.Forms.Panel();
            this.lblHelper = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlBlack = new System.Windows.Forms.Panel();
            this.tmrFistFlurry = new System.Windows.Forms.Timer(this.components);
            this.tmrGameTicker = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimationTicker = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemyHealthDecay = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerHealthDecay = new System.Windows.Forms.Timer(this.components);
            this.tmrHealAnimation = new System.Windows.Forms.Timer(this.components);
            this.tmrActionDelay = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblHavingTrouble = new System.Windows.Forms.Label();
            this.lblBuddhaDescription = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBuddha = new System.Windows.Forms.Button();
            this.pnlGreenPlayer = new System.Windows.Forms.Panel();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.lblHealthPlayer = new System.Windows.Forms.Label();
            this.prgHealthPlayer = new System.Windows.Forms.ProgressBar();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.picEnemyHider = new System.Windows.Forms.PictureBox();
            this.picHealingBeam = new System.Windows.Forms.PictureBox();
            this.picSwipe = new System.Windows.Forms.PictureBox();
            this.picPunch = new System.Windows.Forms.PictureBox();
            this.picPortraitEnemy = new System.Windows.Forms.PictureBox();
            this.pnlGreenEnemy = new System.Windows.Forms.Panel();
            this.pnlEnemy = new System.Windows.Forms.Panel();
            this.lblHealthEnemy = new System.Windows.Forms.Label();
            this.prgHealthEnemy = new System.Windows.Forms.ProgressBar();
            this.lblNameEnemy = new System.Windows.Forms.Label();
            this.picPortraitPlayer = new System.Windows.Forms.PictureBox();
            this.tmrDeathAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnlActions.SuspendLayout();
            this.pnlStuff.SuspendLayout();
            this.pnlYellow.SuspendLayout();
            this.pnlWhite.SuspendLayout();
            this.pnlTurquoise.SuspendLayout();
            this.pnlBlack.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlGreenPlayer.SuspendLayout();
            this.pnlPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyHider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHealingBeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPunch)).BeginInit();
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
            this.btnTL.MouseEnter += new System.EventHandler(this.btnTL_MouseEnter);
            this.btnTL.MouseLeave += new System.EventHandler(this.MouseLeavesButton);
            // 
            // btnBR
            // 
            this.btnBR.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBR.Location = new System.Drawing.Point(180, 42);
            this.btnBR.Name = "btnBR";
            this.btnBR.Size = new System.Drawing.Size(178, 40);
            this.btnBR.TabIndex = 678;
            this.btnBR.Text = "FLEE";
            this.btnBR.UseVisualStyleBackColor = true;
            this.btnBR.Click += new System.EventHandler(this.btnBR_Click);
            this.btnBR.MouseEnter += new System.EventHandler(this.btnBR_MouseEnter);
            this.btnBR.MouseLeave += new System.EventHandler(this.MouseLeavesButton);
            // 
            // btnTR
            // 
            this.btnTR.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTR.Location = new System.Drawing.Point(180, 2);
            this.btnTR.Name = "btnTR";
            this.btnTR.Size = new System.Drawing.Size(178, 40);
            this.btnTR.TabIndex = 78;
            this.btnTR.Text = "REST";
            this.btnTR.UseVisualStyleBackColor = true;
            this.btnTR.Click += new System.EventHandler(this.btnTR_Click);
            this.btnTR.MouseEnter += new System.EventHandler(this.btnTR_MouseEnter);
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
            this.btnBL.Text = "ITEMS";
            this.btnBL.UseVisualStyleBackColor = true;
            this.btnBL.Click += new System.EventHandler(this.btnBL_Click);
            this.btnBL.MouseEnter += new System.EventHandler(this.btnBL_MouseEnter);
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
            this.pnlYellow.MaximumSize = new System.Drawing.Size(1000, 95);
            this.pnlYellow.Name = "pnlYellow";
            this.pnlYellow.Size = new System.Drawing.Size(725, 95);
            this.pnlYellow.TabIndex = 8;
            // 
            // pnlWhite
            // 
            this.pnlWhite.BackColor = System.Drawing.Color.White;
            this.pnlWhite.Controls.Add(this.pnlTurquoise);
            this.pnlWhite.Controls.Add(this.lblStatus);
            this.pnlWhite.Location = new System.Drawing.Point(3, 3);
            this.pnlWhite.Name = "pnlWhite";
            this.pnlWhite.Size = new System.Drawing.Size(719, 87);
            this.pnlWhite.TabIndex = 1;
            // 
            // pnlTurquoise
            // 
            this.pnlTurquoise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.pnlTurquoise.Controls.Add(this.lblHelper);
            this.pnlTurquoise.Location = new System.Drawing.Point(3, 3);
            this.pnlTurquoise.Name = "pnlTurquoise";
            this.pnlTurquoise.Size = new System.Drawing.Size(713, 81);
            this.pnlTurquoise.TabIndex = 0;
            // 
            // lblHelper
            // 
            this.lblHelper.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHelper.ForeColor = System.Drawing.Color.White;
            this.lblHelper.Location = new System.Drawing.Point(51, 28);
            this.lblHelper.Name = "lblHelper";
            this.lblHelper.Size = new System.Drawing.Size(725, 22);
            this.lblHelper.TabIndex = 0;
            this.lblHelper.Text = "Choose an ACTION.";
            this.lblHelper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // tmrAnimationTicker
            // 
            this.tmrAnimationTicker.Tick += new System.EventHandler(this.tmrAnimationTicker_Tick);
            // 
            // tmrEnemyHealthDecay
            // 
            this.tmrEnemyHealthDecay.Interval = 30;
            this.tmrEnemyHealthDecay.Tick += new System.EventHandler(this.tmrEnemyHealthDecay_Tick);
            // 
            // tmrPlayerHealthDecay
            // 
            this.tmrPlayerHealthDecay.Interval = 30;
            this.tmrPlayerHealthDecay.Tick += new System.EventHandler(this.tmrPlayerHealthDecay_Tick);
            // 
            // tmrHealAnimation
            // 
            this.tmrHealAnimation.Interval = 80;
            this.tmrHealAnimation.Tick += new System.EventHandler(this.tmrHealAnimation_Tick);
            // 
            // tmrActionDelay
            // 
            this.tmrActionDelay.Interval = 1000;
            this.tmrActionDelay.Tick += new System.EventHandler(this.tmrActionDelay_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnHelp);
            this.pnlTop.Controls.Add(this.lblHavingTrouble);
            this.pnlTop.Controls.Add(this.lblBuddhaDescription);
            this.pnlTop.Controls.Add(this.lblDescription);
            this.pnlTop.Controls.Add(this.btnBuddha);
            this.pnlTop.Controls.Add(this.pnlGreenPlayer);
            this.pnlTop.Controls.Add(this.picEnemyHider);
            this.pnlTop.Controls.Add(this.picHealingBeam);
            this.pnlTop.Controls.Add(this.picSwipe);
            this.pnlTop.Controls.Add(this.picPunch);
            this.pnlTop.Controls.Add(this.picPortraitEnemy);
            this.pnlTop.Controls.Add(this.pnlGreenEnemy);
            this.pnlTop.Controls.Add(this.picPortraitPlayer);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(732, 344);
            this.pnlTop.TabIndex = 9;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(4, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(24, 23);
            this.btnHelp.TabIndex = 19;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblHavingTrouble
            // 
            this.lblHavingTrouble.AutoSize = true;
            this.lblHavingTrouble.Location = new System.Drawing.Point(54, 65);
            this.lblHavingTrouble.Name = "lblHavingTrouble";
            this.lblHavingTrouble.Size = new System.Drawing.Size(82, 13);
            this.lblHavingTrouble.TabIndex = 18;
            this.lblHavingTrouble.Text = "Having trouble?";
            // 
            // lblBuddhaDescription
            // 
            this.lblBuddhaDescription.AutoSize = true;
            this.lblBuddhaDescription.Location = new System.Drawing.Point(84, 88);
            this.lblBuddhaDescription.Name = "lblBuddhaDescription";
            this.lblBuddhaDescription.Size = new System.Drawing.Size(119, 13);
            this.lblBuddhaDescription.TabIndex = 17;
            this.lblBuddhaDescription.Text = "sets enemy health to 10";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(359, 318);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(371, 27);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Button descriptions appear here when moused over.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescription.Visible = false;
            // 
            // btnBuddha
            // 
            this.btnBuddha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuddha.Location = new System.Drawing.Point(36, 83);
            this.btnBuddha.Name = "btnBuddha";
            this.btnBuddha.Size = new System.Drawing.Size(47, 23);
            this.btnBuddha.TabIndex = 16;
            this.btnBuddha.Text = "Buddha";
            this.btnBuddha.UseVisualStyleBackColor = true;
            this.btnBuddha.Click += new System.EventHandler(this.btnBuddha_Click);
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
            this.lblHealthPlayer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthPlayer.Location = new System.Drawing.Point(7, 40);
            this.lblHealthPlayer.Name = "lblHealthPlayer";
            this.lblHealthPlayer.Size = new System.Drawing.Size(238, 16);
            this.lblHealthPlayer.TabIndex = 2;
            this.lblHealthPlayer.Text = "100 / 100";
            this.lblHealthPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prgHealthPlayer
            // 
            this.prgHealthPlayer.Location = new System.Drawing.Point(7, 27);
            this.prgHealthPlayer.MarqueeAnimationSpeed = 0;
            this.prgHealthPlayer.Name = "prgHealthPlayer";
            this.prgHealthPlayer.Size = new System.Drawing.Size(230, 10);
            this.prgHealthPlayer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgHealthPlayer.TabIndex = 1;
            this.prgHealthPlayer.Value = 100;
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNamePlayer.Location = new System.Drawing.Point(3, 4);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(54, 22);
            this.lblNamePlayer.TabIndex = 0;
            this.lblNamePlayer.Text = "ERIK";
            this.lblNamePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picEnemyHider
            // 
            this.picEnemyHider.Image = global::HumphreyErik2424RST.Properties.Resources.imgEnemyHider;
            this.picEnemyHider.Location = new System.Drawing.Point(424, 181);
            this.picEnemyHider.Name = "picEnemyHider";
            this.picEnemyHider.Size = new System.Drawing.Size(181, 149);
            this.picEnemyHider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnemyHider.TabIndex = 15;
            this.picEnemyHider.TabStop = false;
            // 
            // picHealingBeam
            // 
            this.picHealingBeam.BackColor = System.Drawing.Color.Transparent;
            this.picHealingBeam.Image = global::HumphreyErik2424RST.Properties.Resources.imgBeam01;
            this.picHealingBeam.Location = new System.Drawing.Point(628, 213);
            this.picHealingBeam.Name = "picHealingBeam";
            this.picHealingBeam.Size = new System.Drawing.Size(66, 97);
            this.picHealingBeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHealingBeam.TabIndex = 14;
            this.picHealingBeam.TabStop = false;
            this.picHealingBeam.Visible = false;
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
            // picPortraitEnemy
            // 
            this.picPortraitEnemy.BackColor = System.Drawing.Color.Transparent;
            this.picPortraitEnemy.Image = global::HumphreyErik2424RST.Properties.Resources.imgCultistAlive;
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
            this.pnlGreenEnemy.Location = new System.Drawing.Point(228, 52);
            this.pnlGreenEnemy.Name = "pnlGreenEnemy";
            this.pnlGreenEnemy.Size = new System.Drawing.Size(188, 66);
            this.pnlGreenEnemy.TabIndex = 0;
            // 
            // pnlEnemy
            // 
            this.pnlEnemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.pnlEnemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEnemy.Controls.Add(this.lblHealthEnemy);
            this.pnlEnemy.Controls.Add(this.prgHealthEnemy);
            this.pnlEnemy.Controls.Add(this.lblNameEnemy);
            this.pnlEnemy.Location = new System.Drawing.Point(3, 3);
            this.pnlEnemy.Name = "pnlEnemy";
            this.pnlEnemy.Size = new System.Drawing.Size(182, 60);
            this.pnlEnemy.TabIndex = 5;
            // 
            // lblHealthEnemy
            // 
            this.lblHealthEnemy.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthEnemy.Location = new System.Drawing.Point(7, 40);
            this.lblHealthEnemy.Name = "lblHealthEnemy";
            this.lblHealthEnemy.Size = new System.Drawing.Size(174, 16);
            this.lblHealthEnemy.TabIndex = 3;
            this.lblHealthEnemy.Text = "80 / 100";
            this.lblHealthEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prgHealthEnemy
            // 
            this.prgHealthEnemy.Location = new System.Drawing.Point(7, 27);
            this.prgHealthEnemy.MarqueeAnimationSpeed = 0;
            this.prgHealthEnemy.Name = "prgHealthEnemy";
            this.prgHealthEnemy.Size = new System.Drawing.Size(168, 10);
            this.prgHealthEnemy.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgHealthEnemy.TabIndex = 1;
            this.prgHealthEnemy.Value = 80;
            // 
            // lblNameEnemy
            // 
            this.lblNameEnemy.AutoSize = true;
            this.lblNameEnemy.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNameEnemy.Location = new System.Drawing.Point(3, 4);
            this.lblNameEnemy.Name = "lblNameEnemy";
            this.lblNameEnemy.Size = new System.Drawing.Size(153, 22);
            this.lblNameEnemy.TabIndex = 0;
            this.lblNameEnemy.Text = "HOODED FIGURE";
            // 
            // picPortraitPlayer
            // 
            this.picPortraitPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPortraitPlayer.Image = global::HumphreyErik2424RST.Properties.Resources.imgHero;
            this.picPortraitPlayer.Location = new System.Drawing.Point(50, 147);
            this.picPortraitPlayer.Name = "picPortraitPlayer";
            this.picPortraitPlayer.Size = new System.Drawing.Size(210, 217);
            this.picPortraitPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPortraitPlayer.TabIndex = 7;
            this.picPortraitPlayer.TabStop = false;
            // 
            // tmrDeathAnimation
            // 
            this.tmrDeathAnimation.Tick += new System.EventHandler(this.tmrDeathAnimation_Tick);
            // 
            // frmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 441);
            this.Controls.Add(this.pnlBlack);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBattle";
            this.ShowIcon = false;
            this.Text = "Battle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBattle_FormClosing);
            this.Load += new System.EventHandler(this.frmBattle_Load);
            this.pnlActions.ResumeLayout(false);
            this.pnlStuff.ResumeLayout(false);
            this.pnlYellow.ResumeLayout(false);
            this.pnlWhite.ResumeLayout(false);
            this.pnlWhite.PerformLayout();
            this.pnlTurquoise.ResumeLayout(false);
            this.pnlBlack.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlGreenPlayer.ResumeLayout(false);
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyHider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHealingBeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPunch)).EndInit();
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
        private System.Windows.Forms.Label lblHelper;
        private System.Windows.Forms.Panel pnlStuff;
        private System.Windows.Forms.Panel pnlBlack;
        private System.Windows.Forms.Panel pnlGreenPlayer;
        private System.Windows.Forms.Panel pnlGreenEnemy;
        private System.Windows.Forms.Timer tmrFistFlurry;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picPunch;
        private System.Windows.Forms.Timer tmrGameTicker;
        private System.Windows.Forms.PictureBox picSwipe;
        private System.Windows.Forms.Timer tmrAnimationTicker;
        private System.Windows.Forms.Timer tmrEnemyHealthDecay;
        private System.Windows.Forms.Label lblHealthEnemy;
        private System.Windows.Forms.Timer tmrPlayerHealthDecay;
        private System.Windows.Forms.PictureBox picHealingBeam;
        private System.Windows.Forms.Timer tmrHealAnimation;
        private System.Windows.Forms.Timer tmrActionDelay;
        private System.Windows.Forms.PictureBox picEnemyHider;
        private System.Windows.Forms.Timer tmrDeathAnimation;
        private System.Windows.Forms.Button btnBuddha;
        private System.Windows.Forms.Label lblHavingTrouble;
        private System.Windows.Forms.Label lblBuddhaDescription;
        private System.Windows.Forms.Button btnHelp;
    }
}