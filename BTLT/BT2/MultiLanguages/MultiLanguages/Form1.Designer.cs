namespace MultiLanguages
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thayĐổiNgônNgữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAnh = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu21ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu22ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayĐổiNgônNgữToolStripMenuItem,
            this.menu1ToolStripMenuItem,
            this.menu2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1282, 44);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thayĐổiNgônNgữToolStripMenuItem
            // 
            this.thayĐổiNgônNgữToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViet,
            this.tsmiAnh});
            this.thayĐổiNgônNgữToolStripMenuItem.Name = "thayĐổiNgônNgữToolStripMenuItem";
            this.thayĐổiNgônNgữToolStripMenuItem.Size = new System.Drawing.Size(231, 36);
            this.thayĐổiNgônNgữToolStripMenuItem.Text = "Thay đổi ngôn ngữ";
            // 
            // tsmiViet
            // 
            this.tsmiViet.Checked = true;
            this.tsmiViet.CheckOnClick = true;
            this.tsmiViet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiViet.Name = "tsmiViet";
            this.tsmiViet.Size = new System.Drawing.Size(224, 38);
            this.tsmiViet.Text = "Tiếng Việt";
            this.tsmiViet.CheckedChanged += new System.EventHandler(this.tsmiViet_CheckedChanged);
            // 
            // tsmiAnh
            // 
            this.tsmiAnh.CheckOnClick = true;
            this.tsmiAnh.Name = "tsmiAnh";
            this.tsmiAnh.Size = new System.Drawing.Size(224, 38);
            this.tsmiAnh.Text = "Tiếng Anh";
            this.tsmiAnh.CheckedChanged += new System.EventHandler(this.tsmiAnh_CheckedChanged);
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu11ToolStripMenuItem,
            this.menu12ToolStripMenuItem});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.menu1ToolStripMenuItem.Tag = "1";
            this.menu1ToolStripMenuItem.Text = "Menu1";
            // 
            // menu11ToolStripMenuItem
            // 
            this.menu11ToolStripMenuItem.Name = "menu11ToolStripMenuItem";
            this.menu11ToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.menu11ToolStripMenuItem.Tag = "11";
            this.menu11ToolStripMenuItem.Text = "Menu11";
            // 
            // menu12ToolStripMenuItem
            // 
            this.menu12ToolStripMenuItem.Name = "menu12ToolStripMenuItem";
            this.menu12ToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.menu12ToolStripMenuItem.Text = "Menu12";
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu21ToolStripMenuItem,
            this.menu22ToolStripMenuItem});
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.menu2ToolStripMenuItem.Text = "Menu2";
            // 
            // menu21ToolStripMenuItem
            // 
            this.menu21ToolStripMenuItem.Name = "menu21ToolStripMenuItem";
            this.menu21ToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.menu21ToolStripMenuItem.Text = "Menu21";
            // 
            // menu22ToolStripMenuItem
            // 
            this.menu22ToolStripMenuItem.Name = "menu22ToolStripMenuItem";
            this.menu22ToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.menu22ToolStripMenuItem.Text = "Menu22";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 700);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiNgônNgữToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiViet;
        private System.Windows.Forms.ToolStripMenuItem tsmiAnh;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu21ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu22ToolStripMenuItem;
    }
}

