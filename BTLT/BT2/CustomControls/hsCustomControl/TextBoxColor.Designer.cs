namespace hsCustomControl
{
    partial class TextBoxColor
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
            this.tbColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbColor
            // 
            this.tbColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbColor.BackColor = System.Drawing.SystemColors.Window;
            this.tbColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbColor.Location = new System.Drawing.Point(33, 4);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(137, 19);
            this.tbColor.TabIndex = 0;
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColor.BackColor = System.Drawing.SystemColors.Control;
            this.lblColor.Location = new System.Drawing.Point(4, 2);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(24, 22);
            this.lblColor.TabIndex = 1;
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.Location = new System.Drawing.Point(170, 0);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(30, 26);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // TextBoxColor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.tbColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TextBoxColor";
            this.Size = new System.Drawing.Size(200, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnColor;
    }
}
