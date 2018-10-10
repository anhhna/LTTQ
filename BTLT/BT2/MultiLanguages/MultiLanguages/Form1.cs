using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiLanguages
{
    public partial class Form1 : Form
    {
        Language lang = new Language();

        // user     permission
        // a        1, 11, 12
        // b        2+21+22

        public Form1()
        {
            InitializeComponent();
        }

        private void tsmiAnh_CheckedChanged(object sender, EventArgs e)
        {
            if (tsmiAnh.Checked)
            {
                this.lang.SetLanguage((int)eLanguage.TiengAnh);
                this.lang.ChangeLanguage(this.Name, this);
                this.tsmiViet.Checked = false;
            }
        }

        private void tsmiViet_CheckedChanged(object sender, EventArgs e)
        {
            if (tsmiViet.Checked)
            {
                this.lang.SetLanguage((int)eLanguage.TiengViet);
                this.lang.ChangeLanguage(this.Name, this);
                this.tsmiAnh.Checked = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);
        }
    }
}
