using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurtleProgram;


namespace TurtleTest
{
    [TestClass]
    public class UnitTest1
    {
        Turtle turtle = new Turtle();
        Parser parser = new Parser();
        CommandFactory cf = new CommandFactory();
        private bool test;

        [TestMethod]
        public void TestMethod1()
        {


            bool expectedPenStatus = false;

            parser.Parse("penup");

            Assert.AreEqual(expectedPenStatus, test = false, "Pen wasn't set down");





        }
    }
}