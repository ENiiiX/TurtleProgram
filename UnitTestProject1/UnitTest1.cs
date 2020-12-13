using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurtleProgram;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// UnitTests for part 1 and part 2 of the ASE assignment.
        /// Tests the parser
        /// Tests the CommandFactory classes are functional and returned as part of parsing(PenUpCommand.cs, ForwardCommand.cs, TriangleCommand.cs)
        /// </summary>


        CommandFactory cf = new CommandFactory(); //CF used for returning commands

        private bool test;

        Bitmap bmp = new Bitmap(300, 300);
        Graphics g;

        Parser parser = new Parser(); //Parser used for testing
        StoredProgram sp = new StoredProgram(); //StoredProgram used for testing
        Turtle turtle; //Turtle used for testing





        /// <summary>
        /// Test to determine whether the pen status sets the pen to 'on'
        /// </summary>
        [TestMethod]
        public void CommandValidationPenStatus()
        {
            bool expectedStatus = true;
            String command = "pen on";
            parser.turtle = this.turtle;
            parser.sp = this.sp;
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
            parser.sp = this.sp;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Command parameters missing and/or non-numeric");
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
            parser.sp = this.sp;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Command parameters missing and/or non-numeric");
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
            parser.sp = this.sp;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Command parameters missing and/or non-numeric");
        }



        //Tests for part 2 (Setting variable and starting loop)


        /// <summary>
        /// Test whether parser can detect a variable being set
        /// </summary>
        [TestMethod]
        public void CommandValidationSuccessfulVariableSet()
        {
            bool valid = true;
            String input = "test = 10"; //Text input we're testing
            bool expectedStatus = true;
            parser.turtle = this.turtle;
            parser.sp = this.sp;

            Assert.AreEqual(expectedStatus, parser.isValid(input), "Command parameters missing and/or non-numeric");
        }

        /// <summary>
        /// Test whether the parser can detect the start of a loop
        /// </summary>
        [TestMethod]
        public void CommandValidationSuccessfulLoopSet()
        {
            bool expectedStatus = true;
            String command = "loop 10";
            parser.turtle = this.turtle;
            parser.sp = this.sp;

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Command parameters missing and/or non-numeric");
        }
        /// <summary>
        /// Test based on CommandValidationFailedForwardCommand, this time showing the command
        /// executes once a variable has been declared and added to the program
        /// </summary>
        [TestMethod]
        public void CommandValidationSuccessfulForwardCommand()
        {
            bool expectedStatus = true;
            String command = "forward number";
            parser.turtle = this.turtle;
            parser.sp = this.sp;
            parser.isValid("number = 10"); //Parses and stores the variable 'number' ready for testing.

            Assert.AreEqual(expectedStatus, parser.isValid(command), "Command parameters missing and/or non-numeric");
        }
    }
}
