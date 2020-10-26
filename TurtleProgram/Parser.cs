using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    class Parser
    {
        ArrayList s = new ArrayList();
        ShapeFactory factory = new ShapeFactory();
        public Parser()
        {

        }





        public void Shapes(Graphics g, Turtle turtle, String Input)
        {
            char[] delimiterChars = { ' ' };
            String CommandValue = Input.ToLower();

            if (CommandValue.Contains("shape"))
            {
                String[] ins = CommandValue.Split(delimiterChars);
                int testlength = ins.Length;
                String shape = ins[1].ToString();
                String colour = ins[3].ToString();
                if (shape.Contains("circle"))
                {
                    try
                    {
                        int circleRadius = Int16.Parse(ins[2]);

                        Shape s;

                        s = factory.getShape("circle");
                        Color test = s.ShapeColour(colour);
                        s.set(test, 50, 50, 200);
                        s.draw(g);
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("Invalid Parameters");

                    }
                }
                else
                {
                    Console.WriteLine("Invalid Shape");
                }
            }
            else
            {
                Console.WriteLine("Invalid Command");
            }
        }





    }
}
