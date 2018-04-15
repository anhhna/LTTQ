using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace hsCustomControl
{
    partial class hsTreeView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public CheckBox chkTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private ToolTip toolTip1;
        private System.Windows.Forms.TreeView treeView1;

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
            this.components = new Container();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.treeView1 = new TreeView();
            this.toolTip1 = new ToolTip(this.components);
            this.label5 = new Label();
            this.label6 = new Label();
            this.chkTitle = new CheckBox();
            this.panel1 = new Panel();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.label1.BackColor = Color.Gray;
            this.label1.Dock = DockStyle.Left;
            this.label1.Location = new Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(1, 0x89);
            this.label1.TabIndex = 0;
            this.label2.BackColor = Color.Gray;
            this.label2.Dock = DockStyle.Top;
            this.label2.Location = new Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x84, 1);
            this.label2.TabIndex = 1;
            this.label3.BackColor = Color.Gray;
            this.label3.Dock = DockStyle.Right;
            this.label3.Location = new Point(0x84, 1);
            this.label3.Name = "label3";
            this.label3.Size = new Size(1, 0x88);
            this.label3.TabIndex = 1;
            this.label4.BackColor = Color.Gray;
            this.label4.Dock = DockStyle.Bottom;
            this.label4.Location = new Point(1, 0x88);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x83, 1);
            this.label4.TabIndex = 1;
            this.treeView1.BackColor = SystemColors.Window;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = DockStyle.Fill;
            this.treeView1.Location = new Point(1, 0x13);
            this.treeView1.Margin = new Padding(5, 5, 5, 15);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowLines = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new Size(0x83, 0x75);
            this.treeView1.TabIndex = 9;
            this.treeView1.AfterCheck += new TreeViewEventHandler(this.treeView1_AfterCheck);
            this.label5.Dock = DockStyle.Top;
            this.label5.Location = new Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x83, 1);
            this.label5.TabIndex = 0;
            this.label6.Dock = DockStyle.Left;
            this.label6.Location = new Point(0, 1);
            this.label6.Name = "label6";
            this.label6.Size = new Size(5, 0x11);
            this.label6.TabIndex = 2;
            this.chkTitle.AutoSize = true;
            this.chkTitle.Dock = DockStyle.Left;
            this.chkTitle.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkTitle.Location = new Point(5, 1);
            this.chkTitle.Name = "chkTitle";
            this.chkTitle.Size = new Size(15, 0x11);
            this.chkTitle.TabIndex = 3;
            this.chkTitle.UseVisualStyleBackColor = true;
            this.chkTitle.MouseMove += new MouseEventHandler(this.chkTitle_MouseMove);
            this.chkTitle.CheckedChanged += new EventHandler(this.chkTitle_CheckedChanged);
            this.panel1.BackColor = SystemColors.Window;
            this.panel1.Controls.Add(this.chkTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x83, 0x12);
            this.panel1.TabIndex = 8;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = Color.Transparent;
            base.Controls.Add(this.treeView1);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Name = "TreeView_HAISON";
            base.Size = new Size(0x85, 0x89);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            base.ResumeLayout(false);
        }


        #endregion
    }
}
