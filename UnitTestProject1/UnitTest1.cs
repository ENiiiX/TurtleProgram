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

        Turtle turtle = new Turtle(); //Turtle used for testing
        Parser parser = new Parser(); //Parser used for testing


        /// <summary>
        /// Test to determine whether the pen status sets the pen to 'on'
        /// </summary>
        [TestMethod]
        public void CommandValidationPenStatus()
        {
            bool expectedStatus = true;
            String command = "pen on";
            parser.turtle = this.turtle;
            parser.isValid(command);

            Assert.AreEqual(expectedStatus, this.turtle.penStatus, "Pen wasn't set down");
        }

        /// <summary>
        /// Test to determine whether the parser can validate the command 'forward 50'
        /// </summary>
        [TestMethod]
        public void CommandValidationForwardCommand()
        {
            bool expectedStatus = true;
            String command = "forward 50";
            parser.turtle = this.turtle;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Pen wasn't set down");
        }

        /// <summary>
        /// Test to determine whether the parser can invalidate incorrect commands.
        /// In this case, 'forward' should be numeric.
        /// </summary>
        [TestMethod]
        public void CommandValidationFailedForwardCommand()
        {
            bool expectedStatus = false;
            String command = "forward number";
            parser.turtle = this.turtle;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Pen wasn't set down");
        }

        /// <summary>
        /// Test to determine whether the parser can validate the triangle command.
        /// This is run with the keyword 'triangle' followed by 4 parameters.
        /// </summary>
        [TestMethod]
        public void CommandValidationSuccessfulTriangleCommand()
        {
            bool expectedStatus = true;
            String command = "triangle 50,100,234,234";
            parser.turtle = this.turtle;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Pen wasn't set down");
        }



        //Tests for part 2 (Setting variable and starting loop)


        /// <summary>
        /// Future test for part 2, test whether parser can detect a variable being set
        /// </summary>
        [TestMethod]
        public void CommandValidationSuccessfulVariableSet()
        {
            bool expectedStatus = true;
            String command = "x = 10";
            parser.turtle = this.turtle;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Pen wasn't set down");
        }

        /// <summary>
        /// Future test for part 2, test whether the parser can detect the start of a loop
        /// </summary>
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
