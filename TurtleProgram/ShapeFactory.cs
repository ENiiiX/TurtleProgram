using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    class ShapeFactory
    {

        public Shape getShape(String shapeType)
        {

            shapeType = shapeType.ToUpper().Trim();



            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();
            }
            else
            {
                throw new ArgumentException("Shape does not exist");
            }

        }



    }
}
