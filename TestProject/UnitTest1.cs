using EventLink.Controllers;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
    }

    public class HomeControllerTests
    {
        [Theory]
        [InlineData("r")]
        [InlineData("s")]
        [InlineData("c")]
        public void GetRandomImageFromFolder_ValidCategory(string categoryCode)
        {
            // Arrange
            var expectedPath = $"/images/{categoryCode}/"; // Assuming the folder structure is consistent
            var sut = new HomeController();

            // Act
            var result = HomeController.GetRandomImageFromFolder(categoryCode);

            // Assert
            Assert.StartsWith(expectedPath, result);
            Assert.EndsWith(".jpg", result); // Assuming only JPG images are considered
        }

        [Theory]
        [InlineData("x")]
        [InlineData("abc")]
        [InlineData("")]
        public void GetRandomImageFromFolder_InvalidCategory(string categoryCode)
        {
            // Arrange
            var sut = new HomeController();

            // Act
            var result = HomeController.GetRandomImageFromFolder(categoryCode);

            // Assert
            Assert.Equal("/images/default/default-image.jpg", result);
        }

        [Fact]
        public void GetRandomImageFromFolder_NoImagesFound()
        {
            // Arrange
            var categoryCode = "r"; // Assuming 'restaurants' folder is empty
            var sut = new HomeController();

            // Act
            var result = HomeController.GetRandomImageFromFolder(categoryCode);

            // Assert
            Assert.Equal("/images/default/default-image.jpg", result);
        }

        // For testing when images are found, you can create a test that ensures the result is a valid image path
        // You may need to adjust this test based on the structure of your test project and the images in the folders.
        [Fact]
        public void GetRandomImageFromFolder_ImagesFound()
        {
            // Arrange
            var categoryCode = "r"; // Assuming 'restaurants' folder has images
            var sut = new HomeController();

            // Act
            var result = HomeController.GetRandomImageFromFolder(categoryCode);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.StartsWith("/images/restaurants/"));
            Assert.EndsWith(".jpg", result); // Assuming only JPG images are considered
        }
    }
}