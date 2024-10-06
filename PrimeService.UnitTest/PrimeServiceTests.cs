using System.Numbers;
using Xunit;

namespace UnitTest
{
    public class PrimeServiceTests
    {
        [Fact]
        public void IsPrime_ReturnsTrueForPrimeNumbers()
        {
            // Arrange
            var primeService = new PrimeService();

            // Act
            bool result = primeService.IsPrime(2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPrime_ReturnsFalseForNonPrimeNumbers()
        {
            // Arrange
            var primeService = new PrimeService();

            // Act
            bool result = primeService.IsPrime(4);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        public void IsPrime_ReturnsExpectedResult(int candidate, bool expectedResult)
        {
            // Arrange
            var primeService = new PrimeService();

            // Act
            bool result = primeService.IsPrime(candidate);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
