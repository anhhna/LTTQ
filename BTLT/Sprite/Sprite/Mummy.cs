using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sprite_image
{
    class Mummy:Sprite
    {
        Bitmap Mum = new Bitmap("mummy_white.png");
        public Mummy()
        {
            base.Height = base.Weight = 60;
            base.Index = 0;
            base.X = base.Y = 200;
        }
        internal void RenderM(Graphics g)
        {
            int x = (Index % _Spriteperow) * Weight;
            int y = (Index / _Spriteperow) * Height;
            Rectangle srect = new Rectangle(x, y, Height, Weight);
            g.DrawImage(Mum, X, Y, srect, GraphicsUnit.Pixel);
        }
        public void Move_up()
        {
            base.Move_Up();
            
        }
        public void Move_down()
        {
            base.Move_Down();
            
        }
        public void Move_left()
        {
            base.Move_Left();
            
        }
        public void Move_right()
        {
            base.Move_Right();
            
        }
        
    }
}
