using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
//using Moq;
//using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventLink.Models.Unit_Tests
{

    [TestClass]
    public class Test1
    {

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