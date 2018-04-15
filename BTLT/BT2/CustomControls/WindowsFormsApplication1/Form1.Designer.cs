namespace WindowsFormsApplication1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBoxColor2 = new hsCustomControl.TextBoxColor();
            this.textBoxFont1 = new hsCustomControl.TextBoxFont();
            this.textBoxColor1 = new hsCustomControl.TextBoxColor();
            this.vistaButton1 = new VistaButtonTest.VistaButton();
            this.SuspendLayout();
            // 
            // textBoxColor2
            // 
            this.textBoxColor2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxColor2.Color = System.Drawing.Color.Red;
            this.textBoxColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor2.Location = new System.Drawing.Point(164, 60);
            this.textBoxColor2.Name = "textBoxColor2";
            this.textBoxColor2.Size = new System.Drawing.Size(200, 27);
            this.textBoxColor2.TabIndex = 2;
            // 
            // textBoxFont1
            // 
            this.textBoxFont1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFont1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFont1.FontFromText = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxFont1.Location = new System.Drawing.Point(164, 196);
            this.textBoxFont1.Name = "textBoxFont1";
            this.textBoxFont1.Size = new System.Drawing.Size(200, 27);
            this.textBoxFont1.TabIndex = 1;
            this.textBoxFont1.ButtonFontClick += new System.EventHandler(this.textBoxFont1_ButtonFontClick);
            // 
            // textBoxColor1
            // 
            this.textBoxColor1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(9)))), ((int)(((byte)(255)))));
            this.textBoxColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor1.Location = new System.Drawing.Point(164, 119);
            this.textBoxColor1.Name = "textBoxColor1";
            this.textBoxColor1.Size = new System.Drawing.Size(200, 27);
            this.textBoxColor1.TabIndex = 0;
            this.textBoxColor1.ButtonColorClick += new System.EventHandler(this.textBoxColor1_ButtonColorClick);
            // 
            // vistaButton1
            // 
            this.vistaButton1.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton1.BaseColor = System.Drawing.Color.Coral;
            this.vistaButton1.ButtonColor = System.Drawing.Color.Maroon;
            this.vistaButton1.ButtonText = null;
            this.vistaButton1.CornerRadius = 20;
            this.vistaButton1.GlowColor = System.Drawing.Color.Blue;
            this.vistaButton1.Location = new System.Drawing.Point(164, 262);
            this.vistaButton1.Name = "vistaButton1";
            this.vistaButton1.Size = new System.Drawing.Size(272, 62);
            this.vistaButton1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 437);
            this.Controls.Add(this.vistaButton1);
            this.Controls.Add(this.textBoxColor2);
            this.Controls.Add(this.textBoxFont1);
            this.Controls.Add(this.textBoxColor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private hsCustomControl.TextBoxColor textBoxColor1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private hsCustomControl.TextBoxFont textBoxFont1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private hsCustomControl.TextBoxColor textBoxColor2;
        private VistaButtonTest.VistaButton vistaButton1;
    }
}

