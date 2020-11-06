using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurtleProgram;
using System.Drawing;
using System.Drawing.Imaging;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        CommandFactory cf = new CommandFactory();


        
        private bool test;

 
        Bitmap bmp = new Bitmap(300, 300);
        Graphics g;


        Turtle turtle = new Turtle();
        Parser parser = new Parser();


        [TestMethod]
        public void TestMethod1()
        {
                bool compareBool = true;

                Assert.AreEqual(compareBool, test = true, "Bool didn't return false");
        }

        [TestMethod]

        public void CommandValidationPenStatus()
        {
            bool expectedStatus = true;
            String command = "pen on";
            parser.turtle = this.turtle;
            parser.isValid(command);

            Assert.AreEqual(expectedStatus, this.turtle.penStatus, "Pen wasn't set down");
        }
        [TestMethod]
        public void CommandValidationForwardCommand()
        {
            bool expectedStatus = true;
            String command = "forward 50";
            parser.turtle = this.turtle;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Pen wasn't set down");
        }
        [TestMethod]
        public void CommandValidationFailedForwardCommand()
        {
            bool expectedStatus = false;
            String command = "forward number";
            parser.turtle = this.turtle;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Pen wasn't set down");
        }
        [TestMethod]
        public void CommandValidationSuccessfulTriangleCommand()
        {
            bool expectedStatus = true;
            String command = "triangle 50,100,234,234";
            parser.turtle = this.turtle;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Pen wasn't set down");
        }



        //Tests for part 2 (Setting variable and starting loop

        [TestMethod]
        public void CommandValidationSuccessfulVariableSet()
        {
            bool expectedStatus = true;
            String command = "x = 10";
            parser.turtle = this.turtle;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Pen wasn't set down");
        }
        [TestMethod]
        public void CommandValidationSuccessfulLoopSet()
        {
            bool expectedStatus = true;
            String command = "loop 10";
            parser.turtle = this.turtle;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Pen wasn't set down");
        }
    }
}
