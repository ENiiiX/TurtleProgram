
using System.Drawing;


namespace TurtleProgram
{
    public abstract class Shape : Shapes
    {


        protected int x, y;
        public Color shapeColour;

        public Shape(Color colour, int x, int y)
        {
            shapeColour = colour;
            this.x = x;
            this.y = y;
        }

        protected Shape()
        {

        }

        public abstract double calcArea();

        public abstract double calcPerimeter();

        public abstract void draw(Graphics g, Color colour, bool fill);

        public virtual void set(Color colour, params int[] list)
        {
            shapeColour = colour;
            this.x = list[0];
            this.y = list[1];
        }






        public override string ToString()
        {
            return base.ToString() + "  "+this.x+","+this.y+" : ";
        }




    }
}
