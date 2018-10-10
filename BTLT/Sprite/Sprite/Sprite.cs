using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;
using System.Drawing;


namespace Sprite_image
{
    public class Sprite
    {
        protected int X;
        protected int Y;
        protected int Index;
        protected int Height;
        protected int Weight;
        protected int _Spriteperow;
        Bitmap PnG;

        public Sprite()
        {
            PnG = new Bitmap("Picture1.png");
            Index = 0; //hình cắt ban đầu
            _Spriteperow = 5; //số lượng hình trong dãy
            Height = Weight = 51; //hê số của hình con
            X = Y = 100; // vị trí của hình xuất phát 
        }
        internal void RenderS(Graphics g)
        {
            int x = (Index % _Spriteperow) * Weight;
            int y = (Index / _Spriteperow) * Height;
            Rectangle srect = new Rectangle(x, y, Height, Weight);
            g.DrawImage(PnG, X, Y, srect, GraphicsUnit.Pixel);
        }
        public void Move_Up()
        {
            Y = Y - 10;
            Index = Index + 1;
            if (Index > 4)
                Index = 0;

        }
        public void Move_Down()
        {
            Y = Y + 10;
            Index = Index + 1;
            if (Index < 10 || Index > 14)
                Index = 10;

        }
        public void Move_Right()
        {
            X = X + 10;
            Index = Index + 1;
            if (Index < 5 || Index > 9)
                Index = 5;

        }
        public void Move_Left()
        {
            X = X - 10;
            Index = Index + 1;
            if (Index < 15 || Index > 19)
                Index = 15;

        }
    }
}
