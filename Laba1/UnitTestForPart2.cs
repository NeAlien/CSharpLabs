using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Laba1Part2;

namespace TestForLab1Part2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double side1 = 4;
            double side2 = 5;

            Rectangle object_test = new Rectangle(side1, side2);

            Assert.AreEqual(object_test.Area, 20);
            Assert.AreEqual(object_test.Perimeter, 18);
        }
    }
}
