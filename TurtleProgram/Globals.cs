using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    class Globals
    {
        public static Color penColour = Color.Black;

        //Create shapefactory shapes in turtle class rather than parse
        //will eliminate the need for global variables. can set pen colours there etc
    }
}
