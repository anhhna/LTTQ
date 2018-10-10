namespace howto_analog_clock
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
            this.components = new System.ComponentModel.Container();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.ctxOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSize100x100 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSize150x150 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSize200x200 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSize100x150 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDigital = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxKeepOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTick
            // 
            this.tmrTick.Enabled = true;
            this.tmrTick.Interval = 250;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // ctxOptions
            // 
            this.ctxOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ctxDigital,
            this.ctxKeepOnTop,
            this.toolStripSeparator1,
            this.ctxExit});
            this.ctxOptions.Name = "contextMenuStrip1";
            this.ctxOptions.Size = new System.Drawing.Size(143, 98);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxSize100x100,
            this.ctxSize150x150,
            this.ctxSize200x200,
            this.ctxSize100x150});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "&Size";
            // 
            // ctxSize100x100
            // 
            this.ctxSize100x100.Name = "ctxSize100x100";
            this.ctxSize100x100.Size = new System.Drawing.Size(152, 22);
            this.ctxSize100x100.Tag = "";
            this.ctxSize100x100.Text = "&100x100";
            this.ctxSize100x100.Click += new System.EventHandler(this.mnuSize_Click);
            // 
            // ctxSize150x150
            // 
            this.ctxSize150x150.Name = "ctxSize150x150";
            this.ctxSize150x150.Size = new System.Drawing.Size(152, 22);
            this.ctxSize150x150.Tag = "";
            this.ctxSize150x150.Text = "1&50x150";
            this.ctxSize150x150.Click += new System.EventHandler(this.mnuSize_Click);
            // 
            // ctxSize200x200
            // 
            this.ctxSize200x200.Checked = true;
            this.ctxSize200x200.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctxSize200x200.Name = "ctxSize200x200";
            this.ctxSize200x200.Size = new System.Drawing.Size(152, 22);
            this.ctxSize200x200.Tag = "";
            this.ctxSize200x200.Text = "&200x200";
            this.ctxSize200x200.Click += new System.EventHandler(this.mnuSize_Click);
            // 
            // ctxSize100x150
            // 
            this.ctxSize100x150.Name = "ctxSize100x150";
            this.ctxSize100x150.Size = new System.Drawing.Size(152, 22);
            this.ctxSize100x150.Tag = "";
            this.ctxSize100x150.Text = "100x150";
            this.ctxSize100x150.Click += new System.EventHandler(this.mnuSize_Click);
            // 
            // ctxDigital
            // 
            this.ctxDigital.Name = "ctxDigital";
            this.ctxDigital.Size = new System.Drawing.Size(152, 22);
            this.ctxDigital.Text = "&Digital";
            this.ctxDigital.Click += new System.EventHandler(this.ctxDigital_Click);
            // 
            // ctxKeepOnTop
            // 
            this.ctxKeepOnTop.Name = "ctxKeepOnTop";
            this.ctxKeepOnTop.Size = new System.Drawing.Size(152, 22);
            this.ctxKeepOnTop.Text = "&Keep On Top";
            this.ctxKeepOnTop.Click += new System.EventHandler(this.ctxKeepOnTop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // ctxExit
            // 
            this.ctxExit.Name = "ctxExit";
            this.ctxExit.Size = new System.Drawing.Size(152, 22);
            this.ctxExit.Text = "E&xit";
            this.ctxExit.Click += new System.EventHandler(this.ctxExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ctxOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.ContextMenuStrip ctxOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctxSize100x100;
        private System.Windows.Forms.ToolStripMenuItem ctxSize150x150;
        private System.Windows.Forms.ToolStripMenuItem ctxSize200x200;
        private System.Windows.Forms.ToolStripMenuItem ctxSize100x150;
        private System.Windows.Forms.ToolStripMenuItem ctxDigital;
        private System.Windows.Forms.ToolStripMenuItem ctxKeepOnTop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctxExit;
    }
}

