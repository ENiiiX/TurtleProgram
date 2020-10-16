using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace TurtleProgram
{
    public class Turtle
    {
        Pen p = new Pen(Color.Black, 2);

        private int xPos = 456, yPos = 326; //Sets pen to center of screen
        private int direction = 180;
        private bool penStatus = true;


        public Turtle()
        {
            Console.WriteLine("Turtle has been created"); //debug code, delete
        }

        public void penUp() //Sets pen state to up
        {
            penStatus = false;
        }

        public void penDown() //Sets pen state to down
        {
            penStatus = true;
        }

        public void setColour(String color)
        {
            if (color == "red")
            {
                p.Color = Color.Red;
            }
            else if (color == "blue")
            {
                p.Color = Color.Blue;
            }
            else if (color == "cyan")
            {
                p.Color = Color.Cyan;
            }
            else
            {
                MessageBox.Show("Invalid color");
            }
        }

        public void drawLine(Graphics g, int x1, int y1, int x2, int y2)
        {
            g.DrawLine(p, x1, y1, x2, y2);
        }

        public void forward(Graphics g, int distance) //Method is called to make the pen go forward
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
            if (penStatus)
            {
                drawLine(g, xPos, yPos, x, y);
            }
            //now robot has moved to the new position
            xPos = x;
            yPos = y;
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


























        public void drawRectangle(Graphics g, int x, int y)
        {
            Rectangle r = new Rectangle(x, y, 225, 225);
            g.DrawRectangle(p, r);

        }
        public void drawCircle(Graphics g, int x, int y)
        {
            Rectangle r = new Rectangle(x, y, 225, 225);
            g.DrawEllipse(p, r);
        }
        public void clear(Graphics g)
        {
            g.Clear(Color.White);
        }




    }
}
