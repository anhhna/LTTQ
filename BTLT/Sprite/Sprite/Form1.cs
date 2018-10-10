using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprite_image
{
    public partial class Form1 : Form
    {
        Sprite sprite = new Sprite();
        Mummy mummy = new Mummy();
        Fire fire = new Fire();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            sprite.RenderS(g);
            mummy.RenderM(g);
            fire.RenderW(g);
           
            int x = this.Height - 10;
            int y = this.Width - 10;
        }

        private void Form1_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().ToUpper() == Keys.W.ToString())
            {
                sprite.Move_Up();
            }
            if (e.KeyChar.ToString().ToUpper() == Keys.S.ToString())
            {
                sprite.Move_Down();
            }
            if (e.KeyChar.ToString().ToUpper() == Keys.A.ToString())
            {
                sprite.Move_Left();
            }
            if (e.KeyChar.ToString().ToUpper() == Keys.D.ToString())
            {
                sprite.Move_Right();
            }
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                mummy.Move_up();
            }
            if (e.KeyCode == Keys.Down)
            {
                mummy.Move_down();
            }
            if (e.KeyCode == Keys.Left)
            {
                mummy.Move_left();
            }
            if (e.KeyCode == Keys.Right)
            {
                mummy.Move_right();
            }
            Invalidate();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
