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
    public partial class TextBoxColor : UserControl
    {
        public event EventHandler ButtonColorClick;

        public TextBoxColor()
        {
            InitializeComponent();
        }

        public Color Color12
        {
            get
            {
                return this.lblColor.BackColor;
            }
            set
            {
                try
                {
                    TypeConverter converter = TypeDescriptor.GetConverter(typeof(Color));
                    string strColorString = converter.ConvertToString(value);
                    this.tbColor.Text = strColorString;
                    this.lblColor.BackColor = value;

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
                return this.tbColor.Text;
            }
            set
            {
                try
                {
                    TypeConverter converter = TypeDescriptor.GetConverter(typeof(Color));
                    this.lblColor.BackColor = (Color)converter.ConvertFromString(value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                this.tbColor.Text = value;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (this.ButtonColorClick != null)
            {
                this.ButtonColorClick(this, e);
            }
        }
    }
}
