using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleProgram
{

    class Circle : Shape
    {

        int radius;

        public Circle() : base()
        {

        }

        public Circle(Color colour, int x, int y, int radius) : base(colour, x, y)
        {
            this.radius = radius;
        }



        public override void set(Color colour, params int[] list)
        {
            base.set(colour, list[0], list[1]);
            this.radius = list[2];
        }

        public override void draw(Graphics g, Color colour, bool fill)
        {
            Pen p = new Pen(colour, 2);
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);

            if(fill)
            {
                SolidBrush b = new SolidBrush(base.shapeColour);
                g.FillEllipse(b, x, y, radius * 2, radius * 2);
            }

        }

        public override double calcArea()
        {
            return Math.PI * (radius ^ 2);
        }

        public override double calcPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return base.ToString() + "  " +this.radius;
        }
    }
}
