namespace HumphreyErik2424RST
{
    partial class frmNewSave
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
            this.lblLoginHeader = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.txtNameEntry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLoginHeader
            // 
            this.lblLoginHeader.AutoSize = true;
            this.lblLoginHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginHeader.ForeColor = System.Drawing.Color.Yellow;
            this.lblLoginHeader.Location = new System.Drawing.Point(39, 25);
            this.lblLoginHeader.Name = "lblLoginHeader";
            this.lblLoginHeader.Size = new System.Drawing.Size(206, 13);
            this.lblLoginHeader.TabIndex = 14;
            this.lblLoginHeader.Text = "Enter your name to create a new save file.";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNameTitle.ForeColor = System.Drawing.Color.White;
            this.lblNameTitle.Location = new System.Drawing.Point(55, 51);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(38, 13);
            this.lblNameTitle.TabIndex = 13;
            this.lblNameTitle.Text = "Name:";
            // 
            // txtNameEntry
            // 
            this.txtNameEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(88)))));
            this.txtNameEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEntry.ForeColor = System.Drawing.Color.White;
            this.txtNameEntry.Location = new System.Drawing.Point(95, 51);
            this.txtNameEntry.Name = "txtNameEntry";
            this.txtNameEntry.Size = new System.Drawing.Size(137, 17);
            this.txtNameEntry.TabIndex = 15;
            this.txtNameEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameEntry_KeyPress);
            // 
            // frmNewSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(336, 102);
            this.Controls.Add(this.txtNameEntry);
            this.Controls.Add(this.lblLoginHeader);
            this.Controls.Add(this.lblNameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewSave";
            this.Text = "NewSave";
            this.Load += new System.EventHandler(this.frmNewSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginHeader;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.TextBox txtNameEntry;
    }
}