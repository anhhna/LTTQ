namespace BaiThi
{
    partial class Form1
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
            this.taSliderCtrl1 = new BaiThi.TASliderCtrl();
            this.SuspendLayout();
            // 
            // taSliderCtrl1
            // 
            this.taSliderCtrl1.BackColor = System.Drawing.SystemColors.Control;
            this.taSliderCtrl1.BmpBtn = global::BaiThi.Properties.Resources.ctrSliderBtn;
            this.taSliderCtrl1.BmpFrm = global::BaiThi.Properties.Resources.ctrSliderFrm;
            this.taSliderCtrl1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taSliderCtrl1.Location = new System.Drawing.Point(88, 180);
            this.taSliderCtrl1.Margin = new System.Windows.Forms.Padding(4);
            this.taSliderCtrl1.Name = "taSliderCtrl1";
            this.taSliderCtrl1.Size = new System.Drawing.Size(638, 105);
            this.taSliderCtrl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.taSliderCtrl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TASliderCtrl taSliderCtrl1;


    }
}

