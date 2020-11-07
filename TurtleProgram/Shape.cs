
using System.Drawing;


namespace TurtleProgram
{
    ///<inheritdoc cref="Shapes"/>
    public abstract class Shape : Shapes
    {


        protected int x, y;
        public Color shapeColour;

        /// <summary>
        /// Constructor to create shape that requires colour and x/y coordinates
        /// Future shape constructions can inherit parameters from Shape.cs
        /// </summary>
        /// <param name="colour">Set colour of shape</param>
        /// <param name="x">x coordinate of the shape being created</param>
        /// <param name="y">y coordinate of the shape being created</param>


        public Shape(Color colour, int x, int y)
        {
            shapeColour = colour;
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Empty shape constructor for instantiating empty shapes
        /// </summary>
        protected Shape()
        {

        }

        ///<inheritdoc cref="Shapes.draw(Graphics, Color, bool)"/>
        public abstract void draw(Graphics g, Color colour, bool fill);

        ///<inheritdoc cref="Shapes.set(Color, int[])"/>
        public virtual void set(Color colour, params int[] list)
        {
            shapeColour = colour;
            this.x = list[0];
            this.y = list[1];
        }
    }
}
