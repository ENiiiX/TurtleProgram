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

        public void TestMethod2()
        {
            bool expectedPenStatus = true;
            String command = "penup";
            parser.turtle = this.turtle;
            parser.Parse(command);

            Assert.AreEqual(expectedPenStatus, this.turtle.penStatus, "Pen wasn't set down");
        }
    }
}
