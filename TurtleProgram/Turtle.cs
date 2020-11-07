using System;
using System.Drawing;

using MessageBox = System.Windows.Forms.MessageBox;

namespace TurtleProgram
{
    /// <summary>
    /// Main turtle class
    /// Contains main functionality for performing drawing actions.
    /// <remarks>
    /// This class can do the following functions.
    /// penUp, penDown, fillOn, fillOff, reset, clear, setPenColour, setShapeColour,
    /// drawLine, forward, turnRight, turnLeft, moveTo, drawTo, circle, rectangle, triangle
    /// </remarks>
    /// </summary>
    public class Turtle
    { 
        private int xPos = 50;
        private int yPos = 50;
        private int direction = 180;
        public bool penStatus = true;
        private bool shapeFill = true;
        private Color penColour = Color.Black;
        private Color shapeColour = Color.Blue;
        
        Pen p;
        Graphics g;

        ShapeFactory factory = new ShapeFactory();

        /// <summary>
        /// Constructor used for UnitTesting purposes.
        /// </summary>
        public Turtle()
        {
            System.Drawing.Graphics g;
            Bitmap bmp = new Bitmap(200, 200);
            g = Graphics.FromImage(bmp);
        }
        /// <summary>
        /// Constructor used to instantiate a Turtle object.
        /// </summary>
        /// <param name="g">Parameter to pass the drawing area graphic to the Turtle.</param>
        public Turtle(Graphics g)
        {
            this.g = g;
            p = new Pen(penColour, 2);
            Console.WriteLine("Turtle has been created"); //debug code, delete
            xPos = 50;
            yPos = 50;

         //   s.Add(factory.getShape("circle"));
        }
        /// <summary>
        /// Method to disable pen from drawing
        /// </summary>
        public void penUp()
        {
            penStatus = false;
        }
        /// <summary>
        /// Method to enable pen drawing
        /// </summary>
        public void penDown() 
        {
            penStatus = true;
        }
        /// <summary>
        /// Method to enable shape colour filling
        /// </summary>
        public void fillOn()
        {
            shapeFill = true;
        }
        /// <summary>
        /// Method to disable shape colour filling
        /// </summary>
        public void fillOff()
        {
            shapeFill = false;
        }
        /// <summary>
        /// Method to reset the canvas and restore the Turtle to its original position/colour.
        /// </summary>
        public void reset()
        {
            xPos = 50;
            yPos = 50;
            direction = 180;
            p.Color = Color.Black;
            shapeColour = Color.Blue;
            g.Clear(Color.White);
        }
        /// <summary>
        /// Method to clear the canvas but keep the Turtle in its current state
        /// </summary>
        public void clear()
        {
            g.Clear(Color.White);
        }
        /// <summary>
        /// Method to set the colour of the pen
        /// </summary>
        /// <param name="color">String to set pen colour</param>
        public void setPenColour(String color)
        {
            if (color == "red")
            {
                p.Color = Color.Red;
            }
            else if (color == "blue")
            {
                p.Color = Color.Blue;
            }
            else if (color == "black")
            {
                p.Color = Color.Black;
            }
            else
            {
                MessageBox.Show("Invalid color");
            }
        }
        /// <summary>
        /// Method to set the colour of the shape
        /// </summary>
        /// <param name="color">String to set shape fill colour</param>
        public void setShapeColour(String color)
        {
            if (color == "red")
            {
                shapeColour = Color.Red;
            }
            else if (color == "blue")
            {
                shapeColour = Color.Blue;
            }
            else if (color == "black")
            {
                shapeColour = Color.Black;
            }
            else
            {
                MessageBox.Show("Invalid color");
            }
        }
        /// <summary>
        /// Method to drawLinr based off of user input (utilized by forward method)
        /// </summary>
        /// <param name="x1">Original xPos of the pen</param>
        /// <param name="y1">Original yPos of the pen</param>
        /// <param name="x2">Updated xPos of the pen</param>
        /// <param name="y2">Updated yPos of the pen</param>
        public void drawLine(int x1, int y1, int x2, int y2)
        {
            g.DrawLine(p, x1, y1, x2, y2);
        }
        /// <summary>
        /// Method to move pen forward x distance
        /// </summary>
        /// <param name="distance">Int to determine pen forward movement amount</param>
        public void forward(int distance) 
        {
            if(penStatus)
            {
                int x = xPos, y = yPos;
                //stored xPos and yPos are current location
                if (direction == 0) //robot facing up the screen, so forward subtracts y
                {
                    y = yPos - distance;
                }
                else if (direction == 90) //robot facing right so forward add x
                {
                    x = xPos + distance;
                }
                else if (direction == 180) //robot facing down the screen, so forwards adds to y
                {
                    y = yPos + distance;
                }
                else if (direction == 270) //robot facing left, so forwards subtracts from x
                {
                    x = xPos - distance;
                }
                else
                {
                    Console.WriteLine("strange, shouldn't get here");
                }

                drawLine(xPos, yPos, x, y);

                //now robot has moved to the new position
                xPos = x;
                yPos = y;
            }
            
            else
            {
                MessageBox.Show("Pen is disabled");
            }

        }
        /// <summary>
        /// Method to turn pen direction right
        /// </summary>
        public void turnRight() 
        {
            direction += 90;
            if (direction >= 360)
                direction = 0;
        }
        /// <summary>
        /// Method to turn pen direction left
        /// </summary>
        public void turnLeft() 
        {
            direction -= 90;
            if (direction < 0)
                direction = 270;
        }
        /// <summary>
        /// Method to move pen location to user defined position
        /// </summary>
        /// <param name="x">Updated x position of the pen</param>
        /// <param name="y">Updated y position of the pen</param>
        public void moveTo(int x, int y)
        {
            xPos = x;
            yPos = y;
        }
        /// <summary>
        /// Methodo to draw to a new location
        /// </summary>
        /// <param name="x">Updated x position of the pen</param>
        /// <param name="y">Updated y position of the pen</param>
        public void drawTo(int x, int y)
        {
            if(penStatus)
            {
                drawLine(xPos, yPos, x, y);
                xPos = x;
                yPos = y;
            }
            else
            {
                MessageBox.Show("Pen is disabled");
            }
        }
        /// <summary>
        /// Method to draw a circle within specified radius. Utilizes shape factory classes
        /// </summary>
        /// <param name="radius">Set radius of circle</param>
        public void circle(int radius)
        {
            if(penStatus)
            {
                Shape s;

                s = factory.getShape("circle");
                s.set(shapeColour, xPos, yPos, radius);
                s.draw(g, penColour, shapeFill);
            }
            else
            {
                MessageBox.Show("Pen is disabled");
            }

        }
        /// <summary>
        /// Method to draw a rectangle with specified width/height. Utilizes shape factory classes
        /// </summary>
        /// <param name="width">Width of rectangle</param>
        /// <param name="height">Height of rectangle</param>
        public void rectangle(int width, int height)
        {
            if(penStatus)
            {
                Shape s;

                s = factory.getShape("rectangle");
                s.set(shapeColour, xPos, yPos, width, height);
                s.draw(g, penColour, shapeFill);
            }

            else
            {
                MessageBox.Show("Pen is disabled");
            }



        }
        /// <summary>
        /// Method to draw a triangle with specified points
        /// </summary>
        /// <param name="pntX1">xPos of first triangle point</param>
        /// <param name="pntY1">yPos of first triangle point</param>
        /// <param name="pntX2">xPos of second triangle point</param>
        /// <param name="pntY2">yPos of second triangle point</param>
        public void triangle(int pntX1, int pntY1, int pntX2, int pntY2)
        {
            if (penStatus)
            {
                Shape s;

                s = factory.getShape("triangle");
                s.set(shapeColour, xPos, yPos, pntX1, pntY1, pntX2, pntY2);
                s.draw(g, penColour, shapeFill);
            }
            else
            {
                MessageBox.Show("Pen is disabled");
            }
        }
    }
}
