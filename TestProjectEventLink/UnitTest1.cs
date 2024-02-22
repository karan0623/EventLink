namespace TestProjectEventLink
{
    public class UnitTest1
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