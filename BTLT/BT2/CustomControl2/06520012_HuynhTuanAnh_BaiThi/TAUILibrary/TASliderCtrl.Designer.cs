namespace BaiThi
{
    partial class TASliderCtrl
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
            this.SuspendLayout();
            // 
            // TASliderCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Name = "TASliderCtrl";
            this.Size = new System.Drawing.Size(480, 58);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TASliderCtrl_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TASliderCtrl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TASliderCtrl_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
