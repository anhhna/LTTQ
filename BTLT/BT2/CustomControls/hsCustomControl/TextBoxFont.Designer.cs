namespace hsCustomControl
{
    partial class TextBoxFont
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFont = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFont
            // 
            this.tbFont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFont.BackColor = System.Drawing.SystemColors.Window;
            this.tbFont.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbFont.Location = new System.Drawing.Point(3, 3);
            this.tbFont.Name = "tbFont";
            this.tbFont.Size = new System.Drawing.Size(166, 19);
            this.tbFont.TabIndex = 0;
            // 
            // btnFont
            // 
            this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFont.Location = new System.Drawing.Point(170, 0);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(30, 26);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // TextBoxFont
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.tbFont);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TextBoxFont";
            this.Size = new System.Drawing.Size(200, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFont;
        private System.Windows.Forms.Button btnFont;
    }
}
