using System.Numbers;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestIsPrime_ReturnsTrueForPrimeNumbers()
        {
            // Arrange
            var primeService = new PrimeService();

            // Act
            bool result = primeService.IsPrime(2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsPrime_ReturnsFalseForNonPrimeNumbers()
        {
            // Arrange
            var primeService = new PrimeService();

            // Act
            bool result = primeService.IsPrime(4);

            // Assert
            Assert.False(result);
        }
    }
}