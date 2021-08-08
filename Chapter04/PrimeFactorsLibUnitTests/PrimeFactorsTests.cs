using System;
using Xunit;
using PrimeFactorsLib;

namespace PrimeFactorsLibUnitTests
{
    public class PrimeFactors_Tests
    {
        [Fact]
        public void PrimeFactors_InputIs1_ReturnsEmptyString()
        {
            int number = 1;
            string expected = "";

            string actual = PrimeFactorsLib.PrimeFactorDecomposer.PrimeFactors(number);

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void PrimeFactors_InputIs2_Returns2()
        {
            int number = 2;
            string expected = "2";

            string actual = PrimeFactorsLib.PrimeFactorDecomposer.PrimeFactors(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, "2 x 2")]
        [InlineData(7, "7")]
        [InlineData(20, "2 x 2 x 5")]
        [InlineData(12, "2 x 2 x 3")]
        public void PrimeFactors_ValuesGreaterThan2_ReturnsPrimeFactors(int number, string expected)
        {
            string actual = PrimeFactorsLib.PrimeFactorDecomposer.PrimeFactors(number);

            Assert.Equal(expected, actual);
        }
    }
}
