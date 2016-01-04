namespace HumphreyErik2424RST
{
    partial class frmItems
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
            this.lstItemSelect = new System.Windows.Forms.ListBox();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstItemSelect
            // 
            this.lstItemSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstItemSelect.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItemSelect.FormattingEnabled = true;
            this.lstItemSelect.ItemHeight = 27;
            this.lstItemSelect.Items.AddRange(new object[] {
            "POISON++",
            "MANA POTION",
            "GREATER HEAL",
            "LESSER HEAL"});
            this.lstItemSelect.Location = new System.Drawing.Point(0, 0);
            this.lstItemSelect.Name = "lstItemSelect";
            this.lstItemSelect.Size = new System.Drawing.Size(260, 220);
            this.lstItemSelect.TabIndex = 0;
            // 
            // btnUse
            // 
            this.btnUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUse.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
            this.btnUse.Location = new System.Drawing.Point(26, 228);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(90, 38);
            this.btnUse.TabIndex = 1;
            this.btnUse.Text = "USE";
            this.btnUse.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(122, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 275);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.lstItemSelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItems";
            this.Text = "Items";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstItemSelect;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnCancel;
    }
}