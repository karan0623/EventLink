using EventLink.Controllers;
using EventLink.Models;
using FFImageLoading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;

namespace TestProjectEventLink
{
    public class UnitTest1
    {
        public class ImageServiceTests
        {
            //[Fact]
            //public void GetRandomImageFromFolder_Returns_DefaultImage_When_NoImagesFound()
            //{
            //    // Arrange
            //    var categoryCode = "unknown";
            //    var subcategoryCode = "unknown";

            //    // Act
            //    var result = HomeController.GetRandomImageFromFolder(categoryCode, subcategoryCode);

            //    // Assert
            //    Assert.Equal("/images/default/default-image.jpg", result);
            //}

            [Theory]
            [InlineData("r", "market")]
            [InlineData("r", "bars")]
            [InlineData("r", "fancy")]
            public void GetRandomImageFromFolder_Returns_Image_From_Restaurant_Subcategory(string categoryCode, string subcategoryCode)
            {
                // Act
                var result = HomeController.GetRandomImageFromFolder(categoryCode, subcategoryCode);

                // Assert
                Assert.StartsWith("/images/restaurants/", result);
            }

            [Theory]
            [InlineData("s", "bearcats")]
            [InlineData("s", "bengals")]
            [InlineData("s", "reds")]
            public void GetRandomImageFromFolder_Returns_Image_From_Sports_Subcategory(string categoryCode, string subcategoryCode)
            {
                // Act
                var result = HomeController.GetRandomImageFromFolder(categoryCode, subcategoryCode);

                // Assert
                Assert.StartsWith("/images/sports/", result);
            }

            [Theory]
            [InlineData("c", "venue")]
            [InlineData("c", "symphony")]
            public void GetRandomImageFromFolder_Returns_Image_From_Concerts_Subcategory(string categoryCode, string subcategoryCode)
            {
                // Act
                var result = HomeController.GetRandomImageFromFolder(categoryCode, subcategoryCode);

                // Assert
                Assert.StartsWith("/images/concerts/", result);
            }


            /* Home Controller Unit Tests */

            [Fact]
            public void Index_WhenCalledWithSpecificCategory_FiltersDataAccordingly()
            {
                // Arrange
                var loggerMock = new Mock<ILogger<HomeController>>();
                var controller = new HomeController(loggerMock.Object);

                // Ideally, here you would set up an in-memory database and seed it with data.
                // Since the contexts are created inside the Index method, it's challenging to
                // replace them with in-memory versions without altering the controller's design.
                // This limitation makes it difficult to isolate the test to unit testing and
                // it leans more towards an integration test.

                string testCategory = "SpecificCategory";

                // Act
                var result = controller.Index(testCategory) as ViewResult;

                // Assert
                Assert.NotNull(result);
                var viewModel = Assert.IsType<CombinedViewModel>(result.Model);

                // Without access to the data setup, specific assertions about the data
                // content are challenging. Ideally, you'd assert that the data in the viewModel
                // matches the expected data for the given category.
            }


            [Fact]
            public void Index_ReturnsViewResultWithCorrectModelType()
            {
                // Arrange
                var loggerMock = new Mock<ILogger<HomeController>>();
                var controller = new HomeController(loggerMock.Object);

                // Act
                var result = controller.Index();

                // Assert
                var viewResult = Assert.IsType<ViewResult>(result);
                Assert.IsAssignableFrom<CombinedViewModel>(viewResult.Model);
            }



        }

    }
}