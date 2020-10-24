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

        public void triangle(Graphics g, int distance) //Same concept as the line method, but instead of moving one point of the line on the x/y axis, both points are moved to allow diagonal movement
        {
            int x = xPos, y = yPos;
            if (direction == 180)  //Checks the direction the pen is facing, only runs if facing said direction
            {
                forward(g, distance); //Goes forward to create one side of the triangle
                turnLeft(); //Turns left to create the right angle of the triangle
                forward(g, distance); //Goes forward to create the second side of the triangle
                y = yPos - distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
                x = xPos - distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
            }
            else if (direction == 0)  //Checks the direction the pen is facing, only runs if facing said direction
            {
                forward(g, distance);  //Goes forward to create one side of the triangle
                turnLeft();  //Turns left to create the right angle of the triangle
                forward(g, distance); //Goes forward to create the second side of the triangle
                y = yPos + distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
                x = xPos + distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
            }
            else if (direction == 90)  //Checks the direction the pen is facing, only runs if facing said direction
            {
                forward(g, distance);  //Goes forward to create one side of the triangle
                turnLeft();  //Turns left to create the right angle of the triangle
                forward(g, distance); //Goes forward to create the second side of the triangle
                y = yPos + distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
                x = xPos - distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
            }
            else if (direction == 270)  //Checks the direction the pen is facing, only runs if facing said direction
            {
                forward(g, distance);  //Goes forward to create one side of the triangle
                turnLeft();  //Turns left to create the right angle of the triangle
                forward(g, distance); //Goes forward to create the second side of the triangle
                y = yPos - distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
                x = xPos + distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
            }
            if (penStatus) //If pen is down, hyptonuse of triangle is drawn based off of calculated inputs
            {
                drawLine(g, xPos, yPos, x, y);
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
        public void drawTo(Graphics g, int x, int y)
        {
            drawLine(g, xPos, yPos, x, y);
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
