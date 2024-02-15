using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void TestingUnitTests()
        {
            int x = 1; int y = 2;
            Assert.AreEqual(x, y);
        }

        [TestMethod]
        public void TestingUnitTests2()
        {
            int x1 = 1;
            int y1 = 1;

            Assert.IsTrue(x1 == y1);
        }
    }
}
