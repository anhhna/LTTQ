using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAUILibrary
{
    public partial class TAButton : UserControl
    {
        const int BST_UNCHECKED = 0x0000;
        const int BST_CHECKED = 0x0001;

        Bitmap m_bmp;
        string m_text;
        int m_dwCheck;
        int m_bmpType;

        [Category("Appearance"),
                 DefaultValue(typeof(int), "0"),
                 Description("Button Style")]
        public int RBChecked
        {
            get { return m_dwCheck; }
            set
            {
                m_dwCheck = value;

                this.Invalidate();
            }
        }

        [Category("Appearance"),
                 DefaultValue(typeof(Bitmap), null),
                 Description("Bitmap")]
        public Bitmap Bmp
        {
            get { return m_bmp; }
            set
            {
                m_bmp = value;

                this.Invalidate();
            }
        }

        [Category("Appearance"),
                 DefaultValue(typeof(string), ""),
                 Description("Text")]
        public string ButtonText
        {
            get { return m_text; }
            set
            {
                m_text = value;

                this.Invalidate();
            }
        }

        public TAButton()
        {
            InitializeComponent();

            m_dwCheck = BST_UNCHECKED;
            m_bmpType = 2;

            this.DoubleBuffered = true;
        }

        void GetWindowRect(out Rectangle rc)
        {
            rc = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        void GetClientRect(out Rectangle rc)
        {
            rc = new Rectangle(0, 0, this.Width, this.Height);
        }

        void DrawButtonBitmap(Graphics g, Rectangle prcRgn, int nState)
        {
            if (m_bmp == null)
            {
                return;
            }

            int cxBmp, xPosBmp;
            cxBmp = m_bmp.Width / m_bmpType;
            xPosBmp = (nState < m_bmpType ? nState * cxBmp : 0);

            Rectangle rc;
            rc = prcRgn;

            g.DrawImage(m_bmp, new Rectangle(rc.Left, rc.Top, cxBmp, m_bmp.Height), xPosBmp, 0, cxBmp, m_bmp.Height, GraphicsUnit.Pixel);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rc;
            GetClientRect(out rc);
            rc.Offset(-rc.Left, -rc.Top);

            int nState;	//0: Unchecked, 1:Checked, 2: Disable
            nState = m_dwCheck;

            //draw bitmap
            DrawButtonBitmap(g, rc, nState);
            //draw text
            SizeF sizef = g.MeasureString(this.ButtonText, this.Font);
            g.DrawString(this.ButtonText, this.Font, Brushes.Black, (ClientSize.Width - sizef.Width)/2, (ClientSize.Height - sizef.Height)/2);
        }

        public void SetCheck(int nCheck)
        {
            if (m_dwCheck != nCheck)
            {
                m_dwCheck = nCheck;
                this.Invalidate();
            }
        }

        private void TAButton_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.Parent.Controls.Count; i++)
            {
                Control control = this.Parent.Controls[i];
                if (control is TAButton)
                {
                    TAButton pbtn = (TAButton)control;
                    pbtn.SetCheck(BST_UNCHECKED);
                }
            }
            m_dwCheck = BST_CHECKED;
            this.Invalidate();
        }
    }
}
