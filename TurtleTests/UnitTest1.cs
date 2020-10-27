using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurtleProgram;

namespace TurtleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int xPos = 100;
            int yPos = 100;

            void moveTo(int x, int y)
            {
                xPos = x;
                yPos = y;
            }

            int expectedX = 50;
            int expectedY = 50;

            moveTo(50, 50);

            Assert.AreEqual(expectedX, xPos);
            Assert.AreEqual(expectedY, yPos);
        }
    }
}
