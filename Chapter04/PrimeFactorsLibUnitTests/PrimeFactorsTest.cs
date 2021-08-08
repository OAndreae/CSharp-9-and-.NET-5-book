using System;
using Xunit;
using PrimeFactorsLib;

namespace PrimeFactorsLibUnitTests
{
    public class PrimeFactors_Tests
    {
        [Fact]
        public void PrimeFactors_InputIs1_ReturnsErrorMessage()
        {

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
        public void PrimeFactors_ValuesGreaterThan2_ReturnsPrimeFactors(int value, string expected)
        {

        }
    }
}
