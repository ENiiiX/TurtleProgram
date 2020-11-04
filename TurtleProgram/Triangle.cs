using System.Drawing;


namespace TurtleProgram
{
    public class Triangle : Shape
    {
        int pntX1, pntY1, pntX2, pntY2;


        public Triangle() : base()
        {

        }

        public Triangle(Color colour, int x, int y, int pntX1, int pntY1, int pntX2, int pntY2) : base(colour, x, y)
        {
            this.pntX1 = pntX1;
            this.pntY1 = pntY1;
            this.pntX2 = pntX2;
            this.pntY2 = pntY2;
        }

        public override void set(Color colour, params int[] list)
        {
            base.set(colour, list[0], list[1]);
            this.pntX1 = list[2];
            this.pntY1 = list[3];
            this.pntX2 = list[4];
            this.pntY2 = list[5];
        }

        public override void draw(Graphics g, Color colour, bool fill)
        {
            Pen p = new Pen(colour, 2);
            Point point1 = new Point(x, y);
            Point point2 = new Point(pntX1, pntY1);
            Point point3 = new Point(pntX2, pntY2);
            Point[] curvePoints = {point1, point2, point3};


            g.DrawPolygon(p, curvePoints);

            if (fill)
            {
                SolidBrush b = new SolidBrush(base.shapeColour);
                g.FillPolygon(b, curvePoints);
            }

        }

        public override double calcArea()
        {
            return 2 * x;
        }

        public override double calcPerimeter()
        {
            return 2 * x;
        }
    }
}
