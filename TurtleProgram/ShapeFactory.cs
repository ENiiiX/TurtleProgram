using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    public class ShapeFactory
    {

        public Shape getShape(String shapeType)
        {

            shapeType = shapeType.ToUpper().Trim();

            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();
            }
            if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else
            {
                throw new ArgumentException("Shape does not exist");
            }

        }



    }
}
