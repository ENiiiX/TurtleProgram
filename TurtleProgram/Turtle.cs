using System;
using System.Collections;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace TurtleProgram
{
    public class Turtle
    { 
        private int xPos = 50;
        private int yPos = 50;
        private int direction = 180;
        private bool penStatus = true;
        private bool shapeFill = false;
        private Color penColour = Color.Black;
        private Color shapeColour = Color.Blue;

        Pen p;
        Graphics g;

        ShapeFactory factory = new ShapeFactory();


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
        public void reset(Graphics g)
        {
            xPos = 50;
            yPos = 50;
            direction = 180;
            penColour = Color.Black;
            shapeColour = Color.Blue;
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
            if (penStatus)
            {
                g.DrawLine(p, x1, y1, x2, y2);
            }
            else
            {
                MessageBox.Show("Pen is disabled");
            }
        }
        public void forward(int distance) //Method is called to make the pen go forward
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
        public void triangle(Graphics g, int distance) //Same concept as the line method, but instead of moving one point of the line on the x/y axis, both points are moved to allow diagonal movement
        {
            int x = xPos, y = yPos;
            if (direction == 180)  //Checks the direction the pen is facing, only runs if facing said direction
            {
                forward(distance); //Goes forward to create one side of the triangle
                turnLeft(); //Turns left to create the right angle of the triangle
                forward(distance); //Goes forward to create the second side of the triangle
                y = yPos - distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
                x = xPos - distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
            }
            else if (direction == 0)  //Checks the direction the pen is facing, only runs if facing said direction
            {
                forward(distance);  //Goes forward to create one side of the triangle
                turnLeft();  //Turns left to create the right angle of the triangle
                forward(distance); //Goes forward to create the second side of the triangle
                y = yPos + distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
                x = xPos + distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
            }
            else if (direction == 90)  //Checks the direction the pen is facing, only runs if facing said direction
            {
                forward(distance);  //Goes forward to create one side of the triangle
                turnLeft();  //Turns left to create the right angle of the triangle
                forward(distance); //Goes forward to create the second side of the triangle
                y = yPos + distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
                x = xPos - distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
            }
            else if (direction == 270)  //Checks the direction the pen is facing, only runs if facing said direction
            {
                forward(distance);  //Goes forward to create one side of the triangle
                turnLeft();  //Turns left to create the right angle of the triangle
                forward(distance); //Goes forward to create the second side of the triangle
                y = yPos - distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
                x = xPos + distance; //Hypotenuse of the triangle is calculated by moving the x/y position away from current xPos and yPos. Plus or minusing depending on pen direction
            }
            
            drawLine(xPos, yPos, x, y);

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
            drawLine(xPos, yPos, x, y);
        }
        public void circle(Graphics g, int radius)
        {
            Shape s;

            s = factory.getShape("circle");
            s.set(shapeColour, xPos, yPos, radius);
            s.draw(g, penColour, shapeFill);
        }
        public void rectangle(Graphics g, int width, int height)
        {
            Shape s;

            s = factory.getShape("rectangle");
            s.set(shapeColour, xPos, yPos, width, height);
            s.draw(g, penColour, shapeFill);
        }























        //public void drawRectangle(Graphics g, int x, int y)
        //{
        //    Rectangle r = new Rectangle(x, y, 225, 225);
        //    g.DrawRectangle(p, r);

        //}
        //public void drawCircle(Graphics g, int x, int y)
        //{
        //    Rectangle r = new Rectangle(x, y, 225, 225);
        //    g.DrawEllipse(p, r);
        //}
        //public void clear(Graphics g)
        //{
        //    g.Clear(Color.White);
        //}




    }
}
