using System;
using System.Drawing;

using MessageBox = System.Windows.Forms.MessageBox;

namespace TurtleProgram
{
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

        public Turtle()
        {
            System.Drawing.Graphics g;
            Bitmap bmp = new Bitmap(200, 200);
            g = Graphics.FromImage(bmp);
        }
        public Turtle(Graphics g)
        {
            this.g = g;
            p = new Pen(penColour, 2);
            Console.WriteLine("Turtle has been created"); //debug code, delete
            xPos = 50;
            yPos = 50;

         //   s.Add(factory.getShape("circle"));
        }
        public void penUp() //Sets pen state to up
        {
            penStatus = false;
        }
        public void penDown() //Sets pen state to down
        {
            penStatus = true;
        }
        public void fillOn()
        {
            shapeFill = true;
        }
        public void fillOff()
        {
            shapeFill = false;
        }
        public void reset()
        {
            xPos = 50;
            yPos = 50;
            direction = 180;
            penColour = Color.Black;
            shapeColour = Color.Blue;
            g.Clear(Color.White);
        }
        public void clear()
        {
            g.Clear(Color.White);
        }
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
        public void drawLine(int x1, int y1, int x2, int y2)
        {
            g.DrawLine(p, x1, y1, x2, y2);
        }
        public void forward(int distance) //Method is called to make the pen go forward
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
        public void turnRight() //Turns pen right
        {
            direction += 90;
            if (direction >= 360)
                direction = 0;
        }
        public void turnLeft() //Turns pen left
        {
            direction -= 90;
            if (direction < 0)
                direction = 270;
        }
        public void moveTo(int x, int y)
        {
            xPos = x;
            yPos = y;
        }
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
