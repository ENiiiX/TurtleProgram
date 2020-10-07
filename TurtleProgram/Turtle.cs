using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurtleProgram
{





    public class Turtle
    {

        private readonly Image backgroundImage;

        public Turtle(Image backgroundImage)
        {
            this.backgroundImage = backgroundImage;
        }


 


        public void drawLine(Graphics g, int x, int y)
        {

            Pen p = new Pen(Color.Black, 2);
            Rectangle r = new Rectangle(x, y, 225, 225);
            g.DrawRectangle(p, r);
            p.Dispose();


        }




    }
}
