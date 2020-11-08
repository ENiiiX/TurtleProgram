using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    /// <summary>
    /// ShapeFactory class that creates shapes when called by a user from the parser class
    /// Every shape availale to the user can be called from this class.
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// Calls shape class based on user input
        /// </summary>
        /// <param name="shapeType">Shape type requested</param>
        /// <returns></returns>
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
            if (shapeType.Equals("TRIANGLE"))
            {
                return new Triangle();
            }
            else
            {
                throw new ArgumentException("Shape does not exist");
            }

        }
    }
}
