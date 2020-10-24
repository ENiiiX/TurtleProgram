using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    abstract class Shape : Shapes
    {

        protected Color colour = Color.Black;
        protected int x, y;

        public Shape(Color colour, int x, int y)
        {
            this.colour = colour;
            this.x = x;
            this.y = y;
        }

        protected Shape()
        {

        }
        public virtual Color ShapeColour(String colour)
        {
            if (colour == "red")
            {
                this.colour = Color.Red;
            }
            else if(colour == "blue")
            {
                this.colour = Color.Blue;
            }
            return this.colour;
        }


        public abstract double calcArea();

        public abstract double CalcPerimeter();

        public abstract void draw(Graphics g);

        public virtual void set(Color colour, params int[] list)
        {
            this.colour = colour;
            this.x = list[0];
            this.y = list[1];
        }






        public override string ToString()
        {
            return base.ToString() + "  "+this.x+","+this.y+" : ";
        }




    }
}
