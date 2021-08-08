using PrimeFactorsLib;
using Xunit;

namespace PrimeFactorsLibUnitTests
{
    public class PrimeFactorsFunctionalTests
    {
        [Fact]
        public void PrimeFactorsFunctional_InputIs1_ReturnsEmptyString()
        {
            int number = 1;
            string expected = "";

            string actual = PrimeFactorsLib.PrimeFactorDecomposer.PrimeFactorsFunctional(number);

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void PrimeFactorsFunctional_InputIs2_Returns2()
        {
            int number = 2;
            string expected = "2";

            string actual = PrimeFactorsLib.PrimeFactorDecomposer.PrimeFactorsFunctional(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, "2 x 2")]
        [InlineData(7, "7")]
        [InlineData(20, "2 x 2 x 5")]
        [InlineData(12, "2 x 2 x 3")]
        public void PrimeFactorsFunctional_ValuesGreaterThan2_ReturnsPrimeFactors(int number, string expected)
        {
            string actual = PrimeFactorsLib.PrimeFactorDecomposer.PrimeFactorsFunctional(number);

            Assert.Equal(expected, actual);
        }
    }
}
