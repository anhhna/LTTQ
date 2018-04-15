using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hsCustomControl
{
    public partial class TextBoxFont : UserControl
    {
        public event EventHandler ButtonFontClick;

        public TextBoxFont()
        {
            InitializeComponent();
        }

        public Font FontFromText
        {
            get
            {
                try
                {
                    TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
                    return (Font)converter.ConvertFromString(this.tbFont.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return null;
            }
            set
            {
                try
                {
                    TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
                    string strFontString = converter.ConvertToString(value);
                    this.tbFont.Text = strFontString;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public override string Text
        {
            get
            {
                return this.tbFont.Text;
            }
            set
            {
                this.tbFont.Text = value;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (this.ButtonFontClick != null)
            {
                this.ButtonFontClick(this, e);
            }
        }
    }
}
