using Xunit;
using System.IO;
using EventLink.Controllers;

namespace EventLinkTests
{
    

    public class HomeControllerTests
    {
        [Fact]
        public void Add_TwoIntegers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act & Assert
            Assert.Equal(8, a + b);
        }

        
    }

}