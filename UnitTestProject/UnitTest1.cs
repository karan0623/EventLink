using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;


namespace UnitTestProject
{
    //[TestClass]
    //public class UnitTest1
    //{
    //    //[TestMethod]
    //    //public void TestMethod1()
    //    //{

    //    //}

    //    //[TestMethod]
    //    //public void TestingUnitTests()
    //    //{
    //    //    int x = 1; int y = 2;
    //    //    Assert.AreEqual(x, y);
    //    //}

    //    //[TestMethod]
    //    //public void TestingUnitTests2()
    //    //{
    //    //    int x1 = 1;
    //    //    int y1 = 1;

    //    //    Assert.IsTrue(x1 == y1);
    //    //}
    //}
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void GetRandomImageFromFolder_RestaurantsCategory_ReturnsValidImagePath()
        {
            // Arrange
            var categoryCode = "R";

            // Act
            var result = HomeController.GetRandomImageFromFolder(categoryCode);

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(result));
            Assert.IsTrue(result.StartsWith("/images/restaurants/"));
            Assert.IsTrue(File.Exists(Path.Combine("wwwroot", result.TrimStart('/'))));
        }

        [TestMethod]
        public void GetRandomImageFromFolder_SportsCategory_ReturnsValidImagePath()
        {
            // Arrange
            var categoryCode = "S";

            // Act
            var result = HomeController.GetRandomImageFromFolder(categoryCode);

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(result));
            Assert.IsTrue(result.StartsWith("/images/sports/"));
            Assert.IsTrue(File.Exists(Path.Combine("wwwroot", result.TrimStart('/'))));
        }

        [TestMethod]
        public void GetRandomImageFromFolder_ConcertsCategory_ReturnsValidImagePath()
        {
            // Arrange
            var categoryCode = "C";

            // Act
            var result = HomeController.GetRandomImageFromFolder(categoryCode);

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(result));
            Assert.IsTrue(result.StartsWith("/images/concerts/"));
            Assert.IsTrue(File.Exists(Path.Combine("wwwroot", result.TrimStart('/'))));
        }

        [TestMethod]
        public void GetRandomImageFromFolder_DefaultCategory_ReturnsValidImagePath()
        {
            // Arrange
            var categoryCode = "Z"; // Unrecognized category

            // Act
            var result = HomeController.GetRandomImageFromFolder(categoryCode);

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(result));
            Assert.IsTrue(result.StartsWith("/images/default/"));
            Assert.IsTrue(File.Exists(Path.Combine("wwwroot", result.TrimStart('/'))));
        }
    }
}
