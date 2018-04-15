using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxColor1_ButtonColorClick(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBoxColor1.Color = this.colorDialog1.Color;
            }
        }

        private void textBoxFont1_ButtonFontClick(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBoxFont1.FontFromText = this.fontDialog1.Font;
            }
        }
    }
}
