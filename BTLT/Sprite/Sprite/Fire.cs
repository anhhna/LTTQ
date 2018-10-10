using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;

namespace Sprite_image
{
    class Fire:Sprite
    {
        Bitmap PnG = new Bitmap("Tuan.png");
        private Timer timer;
        public Fire()
        {
            base.Height = 67; base.Weight = 67;
            base.Index = 0;
            timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 67;
        }
        internal void RenderW(Graphics g)
        {
            int x = (Index % _Spriteperow) * Weight;
            int y = (Index / _Spriteperow) * Height;
            Rectangle srect = new Rectangle(x, y, Height, Weight);
            g.DrawImage(PnG, X, Y, srect, GraphicsUnit.Pixel);
    
        }
        public void Move()
        {
            if (Index < 1 || Index > 31)
                Index = 1;
            else
                Index++;
        }
    }
}
