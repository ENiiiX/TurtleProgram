using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    interface Shapes
    {

        void set(Color colour, params int[] list);

        void draw(Graphics g, Color colour);

        double calcArea();

        double calcPerimeter();




    }
}
