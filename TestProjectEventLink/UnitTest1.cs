using EventLink.Controllers;
using FFImageLoading;

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
        }

    }
}