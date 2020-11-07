using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    /// <summary>
    /// Interface utilized by shape factory classes to set colour/size parameters and to draw   
    /// </summary>
    interface Shapes
    {
        /// <summary>
        /// Sets colour of shape and params such as xPos/yPos, shape dimensions
        /// </summary>
        /// <param name="colour">Set colour of shape</param>
        /// <param name="list">List containing shape dimensions (width, height)</param>
        void set(Color colour, params int[] list);

        /// <summary>
        /// Draw shape to graphic with specified colour and fill bool
        /// </summary>
        /// <param name="g">Graphic in which the shape is drawn</param>
        /// <param name="colour">Set colour of shape</param>
        /// <param name="list">Bool to toggle shape fill on/off</param>
        void draw(Graphics g, Color colour, bool fill);
    }
}
