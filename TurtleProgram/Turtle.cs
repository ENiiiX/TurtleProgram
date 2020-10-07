using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurtleProgram
{





    public class Turtle
    {
        private int initialWidth = 600, initialHeight = 600;
        Pen p = new Pen(Color.Black, 2);
        private readonly Image backgroundImage;


        public void drawLine(Graphics g, int x, int y)
        {
            Rectangle r = new Rectangle(x, y, 225, 225);
            g.DrawRectangle(p, r);
            //p.Dispose();
        }
        public void drawCircle(Graphics g, int x, int y)
        {
            Rectangle r = new Rectangle(x, y, 225, 225);
            g.DrawEllipse(p, r);
        }
        public void clear(Graphics g)
        {
            g.Clear(Color.White);
        }




    }
}
