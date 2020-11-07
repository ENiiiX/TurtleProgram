using System;
using System.Drawing;


namespace TurtleProgram
{

    class Circle : Shape
    {

        int radius;

        ///<inheritdoc cref="Shape.Shape"/>
        public Circle() : base()
        {

        }

        ///<inheritdoc cref="Shape.Shape(Color, int, int)"/>
        ///<param name="radius">int to declare radius of circle and assign to permanent variable</param>
        public Circle(Color colour, int x, int y, int radius) : base(colour, x, y)
        {
            this.radius = radius;
        }


        ///<inheritdoc cref="Shape.set(Color, int[])"/>
        public override void set(Color colour, params int[] list)
        {
            base.set(colour, list[0], list[1]);
            this.radius = list[2];
        }

        ///<inheritdoc cref="Shape.draw(Graphics, Color, bool)"/>
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
    }
}
