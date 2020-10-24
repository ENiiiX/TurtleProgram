using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillEllipse(b, x, y, radius * 2, radius * 2);
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);
        }

        public override double calcArea()
        {
            return Math.PI * (radius ^ 2);
        }

        public override double CalcPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return base.ToString() + "  " +this.radius;
        }
    }
}
