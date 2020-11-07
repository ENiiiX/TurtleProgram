using System.Drawing;


namespace TurtleProgram
{
    public class Rectangle : Shape
    {
        int width, height;


        ///<inheritdoc cref="Shape.Shape"/>
        public Rectangle() : base()
        {
            
        }

        ///<inheritdoc cref="Shape.Shape(Color, int, int)"/>
        ///<param name="width">int to declare width of rectangle and assign to permanent variable</param>
        ///<param name="height">int to declare height of rectangle and assign to permanent variable</param>
        public Rectangle(Color colour, int x, int y, int width, int height) : base(colour, x, y)
        {
            this.width = width;
            this.height = height;
        }

        ///<inheritdoc cref="Shape.set(Color, int[])"/>
        public override void set(Color colour, params int[] list)
        {
            base.set(colour, list[0], list[1]);
            this.width = list[2];
            this.height = list[3];
        }

        ///<inheritdoc cref="Shape.draw(Graphics, Color, bool)"/>
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
    }
}
