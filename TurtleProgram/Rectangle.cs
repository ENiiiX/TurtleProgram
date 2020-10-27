using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleProgram
{
    class Rectangle : Shape
    {
        int width, height;


        public Rectangle() : base()
        {
            
        }

        public Rectangle(Color colour, int x, int y, int width, int height) : base(colour, x, y)
        {
            this.width = width;
            this.height = height;
        }

        public override void set(Color colour, params int[] list)
        {
            base.set(colour, list[0], list[1]);
            this.width = list[2];
            this.height = list[3];
        }

        public override void draw(Graphics g, Color colour, bool fill)
        {
            Pen p = new Pen(colour, 2);
            g.DrawRectangle(p, x, y, width, height);

            if (fill)
            {
                SolidBrush b = new SolidBrush(base.shapeColour);
                g.FillRectangle(b, x, y, width, height);
            }

        }

        public override double calcArea()
        {
            return width * height;
        }

        public override double calcPerimeter()
        {
            return 2 * width + 2 * height;
        }
    }
}
