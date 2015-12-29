namespace HumphreyErik2424RST
{
    partial class frmProgression
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
            this.lblLevelType = new System.Windows.Forms.Label();
            this.lblObjective = new System.Windows.Forms.Label();
            this.lblProgressHeader = new System.Windows.Forms.Label();
            this.prgLevelProgress = new System.Windows.Forms.ProgressBar();
            this.lblAlphanumericProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLevelType
            // 
            this.lblLevelType.AutoSize = true;
            this.lblLevelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelType.Location = new System.Drawing.Point(18, 17);
            this.lblLevelType.Name = "lblLevelType";
            this.lblLevelType.Size = new System.Drawing.Size(268, 29);
            this.lblLevelType.TabIndex = 0;
            this.lblLevelType.Text = "Level type: Woodcutting";
            // 
            // lblObjective
            // 
            this.lblObjective.AutoSize = true;
            this.lblObjective.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjective.Location = new System.Drawing.Point(18, 56);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(333, 29);
            this.lblObjective.TabIndex = 1;
            this.lblObjective.Text = "Make 4 fires using willow logs";
            // 
            // lblProgressHeader
            // 
            this.lblProgressHeader.AutoSize = true;
            this.lblProgressHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressHeader.Location = new System.Drawing.Point(126, 94);
            this.lblProgressHeader.Name = "lblProgressHeader";
            this.lblProgressHeader.Size = new System.Drawing.Size(259, 39);
            this.lblProgressHeader.TabIndex = 3;
            this.lblProgressHeader.Text = "Level progress";
            // 
            // prgLevelProgress
            // 
            this.prgLevelProgress.Location = new System.Drawing.Point(23, 143);
            this.prgLevelProgress.Name = "prgLevelProgress";
            this.prgLevelProgress.Size = new System.Drawing.Size(455, 20);
            this.prgLevelProgress.TabIndex = 2;
            this.prgLevelProgress.Value = 60;
            // 
            // lblAlphanumericProgress
            // 
            this.lblAlphanumericProgress.AutoSize = true;
            this.lblAlphanumericProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphanumericProgress.Location = new System.Drawing.Point(199, 179);
            this.lblAlphanumericProgress.Name = "lblAlphanumericProgress";
            this.lblAlphanumericProgress.Size = new System.Drawing.Size(121, 18);
            this.lblAlphanumericProgress.TabIndex = 4;
            this.lblAlphanumericProgress.Text = "0 / 4 fires created";
            // 
            // frmProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 230);
            this.ControlBox = false;
            this.Controls.Add(this.lblAlphanumericProgress);
            this.Controls.Add(this.lblProgressHeader);
            this.Controls.Add(this.prgLevelProgress);
            this.Controls.Add(this.lblObjective);
            this.Controls.Add(this.lblLevelType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProgression";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Progression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLevelType;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.Label lblProgressHeader;
        private System.Windows.Forms.ProgressBar prgLevelProgress;
        private System.Windows.Forms.Label lblAlphanumericProgress;
    }
}