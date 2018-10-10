using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThi
{
    public partial class TASliderCtrl : UserControl
    {
        const int CLICK_NO = -1;
        const int CLICK_LEFT = Int16.MinValue;
        const int CLICK_RIGHT = Int16.MaxValue;

        Bitmap m_hbmpBtn;
        Bitmap m_hbmpFrm;
        int m_nMin;
        int m_nMax;
        int m_nPos;
        Size m_sizeFrm;
        Size m_sizeBtn;
        int m_cxMargin;
        bool m_bPressed;
        int m_posDragStart;
        Point m_ptDragStart;
        Timer timerAutoClick1;
        Timer timerAutoClick2;

        [Category("Appearance"),
                 DefaultValue(typeof(Bitmap), null),
                 Description("Background")]
        public Bitmap BmpFrm
        {
            get { return m_hbmpFrm; }
            set {
                m_hbmpFrm = value;

                m_sizeFrm.Width = m_hbmpFrm.Width;
                m_sizeFrm.Height = m_hbmpFrm.Height;

                this.Invalidate(); 
            }
        }

        [Category("Appearance"),
                 DefaultValue(typeof(Bitmap), null),
                 Description("Slider")]
        public Bitmap BmpBtn
        {
            get { return m_hbmpBtn; }
            set
            {
                m_hbmpBtn = value;

                m_sizeBtn.Width = m_hbmpBtn.Width / 2;
                m_sizeBtn.Height = m_hbmpBtn.Height;


                m_cxMargin = m_sizeBtn.Width * 5 / 4;

                this.Invalidate();
            }
        }

        [Category("Appearance"),
                 DefaultValue(typeof(int), "0"),
                 Description("Min Value")]
        public int MinValue
        {
            get { return m_nMin; }
            set
            {
                m_nMin = value;

                this.Invalidate();
            }
        }

        [Category("Appearance"),
                 DefaultValue(typeof(int), "100"),
                 Description("Max Value")]
        public int MaxValue
        {
            get { return m_nMax; }
            set
            {
                m_nMax = value;

                this.Invalidate();
            }
        }

        public TASliderCtrl()
        {
            InitializeComponent();

            m_nMin = 0;
            m_nMax = 100;
            m_nPos = 0;

            m_bPressed = false;
            m_posDragStart = CLICK_NO;
            timerAutoClick1 = new Timer();
            timerAutoClick2 = new Timer();
            timerAutoClick1.Interval = 100;
            timerAutoClick2.Interval = 20;
            timerAutoClick1.Tick += timerAutoClick1_Tick;
            timerAutoClick2.Tick += timerAutoClick2_Tick;
            this.DoubleBuffered = true;
        }

        void timerAutoClick1_Tick(object sender, EventArgs e)
        {
            timerAutoClick1.Stop();
            timerAutoClick2.Start();

            TimerAutoClick();

            this.Invalidate();
        }

        void TimerAutoClick()
        {
            switch (m_posDragStart)
            {
                case CLICK_LEFT:
                    m_nPos = Math.Max(m_nMin, m_nPos - 1);
                    break;

                case CLICK_RIGHT:
                    m_nPos = Math.Min(m_nMax, m_nPos + 1);
                    break;

                default:
                    //ASSERT(0);
                    return;
            }
        }

        void timerAutoClick2_Tick(object sender, EventArgs e)
        {
            TimerAutoClick();
            this.Invalidate();
        }

        void GetWindowRect(out Rectangle rc)
        {
            rc = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        void GetClientRect(out Rectangle rc)
        {
            rc = new Rectangle(0, 0, this.Width, this.Height);
        }

        int GetThumbPos()
        {
            Rectangle rc;
            GetClientRect(out rc);
            rc.X = rc.Left + m_cxMargin;
            rc.Width = rc.Width - m_cxMargin*2;

            return rc.Left + rc.Width*(m_nPos-m_nMin)/(m_nMax-m_nMin);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (m_hbmpFrm == null || m_hbmpBtn == null)
                return;

            Graphics g = e.Graphics;
            Rectangle rc;
            GetClientRect(out rc);
            rc.Offset(-rc.Left, -rc.Top);

            int nTickPos = GetThumbPos();

            int cx, yPos;
            yPos = (rc.Bottom - m_sizeFrm.Height) / 2;

            //draw frame
            cx = m_sizeFrm.Width / 4;
            m_hbmpFrm.MakeTransparent(Color.FromArgb(0xFF00FF));
            g.DrawImage(m_hbmpFrm, new Rectangle(0, yPos, cx, m_sizeFrm.Height), 0, 0, cx, m_sizeFrm.Height, GraphicsUnit.Pixel);
            g.DrawImage(m_hbmpFrm, new Rectangle(rc.Right - cx, yPos, cx, m_sizeFrm.Height), cx * 3, 0, cx, m_sizeFrm.Height, GraphicsUnit.Pixel);
            if (nTickPos - cx > 0)
                g.DrawImage(m_hbmpFrm, new Rectangle(cx, yPos, nTickPos - cx, m_sizeFrm.Height), cx, 0, cx, m_sizeFrm.Height, GraphicsUnit.Pixel);
            if (rc.Right - nTickPos - cx > 0)
                g.DrawImage(m_hbmpFrm, new Rectangle(nTickPos, yPos, rc.Right - nTickPos - cx, m_sizeFrm.Height), cx * 2, 0, cx, m_sizeFrm.Height, GraphicsUnit.Pixel);

            //draw thumb
            g.DrawImage(m_hbmpBtn, new Rectangle(nTickPos - m_sizeBtn.Width / 2, yPos, m_sizeBtn.Width, m_sizeBtn.Height), (m_bPressed ? m_sizeBtn.Width : 0), 0, m_sizeBtn.Width, m_sizeBtn.Height, GraphicsUnit.Pixel);

            //draw min value
            string szValue;
            szValue = m_nMin.ToString();
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Far;
            g.DrawString(szValue, this.Font, Brushes.Black, rc, stringFormat);

            //draw max value
            szValue = m_nMax.ToString();
            stringFormat.Alignment = StringAlignment.Far;
            stringFormat.LineAlignment = StringAlignment.Far;
            g.DrawString(szValue, this.Font, Brushes.Black, rc, stringFormat);

            //draw Current Position
            szValue = m_nPos.ToString();
            Rectangle rcTmp = rc;
            SizeF sizef = g.MeasureString(szValue, this.Font);
            cx = (int)sizef.Width + 1;
            rcTmp.X = Math.Min(rc.Right + 1 - cx, Math.Max(rc.Left, nTickPos - cx / 2));
            rcTmp.Width = cx;
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Near;
            g.DrawString(szValue, this.Font, Brushes.Black, rcTmp, stringFormat);
        }

        int HitTestCtrl(Point pt)
        {
            Rectangle rc;
            int nPosInPx = GetThumbPos();
            GetClientRect(out rc);

            if (pt.X>=nPosInPx-m_sizeBtn.Width && pt.X<=nPosInPx+m_sizeBtn.Width)
                return nPosInPx;

            if (pt.X < rc.Left+m_cxMargin)
                return CLICK_LEFT;

            if (pt.X > rc.Right-m_cxMargin)
                return CLICK_RIGHT;

            return CLICK_NO;
        }

        private void TASliderCtrl_MouseDown(object sender, MouseEventArgs e)
        {
            m_posDragStart = HitTestCtrl(e.Location);
            if (m_posDragStart == CLICK_NO)
                return;

            //SetCapture();
            switch (m_posDragStart)
            {
                case CLICK_LEFT:
                    m_nPos = Math.Max(m_nMin, m_nPos - 1);
                    timerAutoClick1.Start();
                    break;

                case CLICK_RIGHT:
                    m_nPos = Math.Min(m_nMax, m_nPos + 1);
                    timerAutoClick1.Start();
                    break;

                default:
                    //ASSERT(m_posDragStart>=0);
                    m_ptDragStart = e.Location;
                    break;
            }

            m_bPressed = true;
            this.Invalidate();
        }

        private void TASliderCtrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_posDragStart != CLICK_NO && m_posDragStart != CLICK_LEFT && m_posDragStart != CLICK_RIGHT)
            {
                int nPos = ConvPosFromPx(m_posDragStart + e.X - m_ptDragStart.X);
                if (nPos != m_nPos)
                {
                    m_nPos = nPos;
                    this.Invalidate();
                }
            }

        }

        int ConvPosFromPx(int posInPixel)
        {
            Rectangle rc;
            GetClientRect(out rc);
            rc.X = rc.Left+m_cxMargin;
            rc.Width = rc.Width-m_cxMargin*2;
            posInPixel = m_nMin + (int)((posInPixel-rc.Left)*(m_nMax-m_nMin)/(double)(rc.Width)+0.5);
            return Math.Min(m_nMax, Math.Max(m_nMin, posInPixel));
        }

        private void TASliderCtrl_MouseUp(object sender, MouseEventArgs e)
        {
            // TODO: Add your message handler code here and/or call default
            if (m_posDragStart != CLICK_NO)
            {
                switch (m_posDragStart)
                {
                    case CLICK_LEFT:
                    case CLICK_RIGHT:
                        timerAutoClick2.Stop();
                        break;

                    default:
                        m_nPos = ConvPosFromPx(m_posDragStart + e.X - m_ptDragStart.X);
                        break;
                }

                m_posDragStart = CLICK_NO;
                this.Invalidate();
            }

            m_bPressed = false;
        }
    }
}
