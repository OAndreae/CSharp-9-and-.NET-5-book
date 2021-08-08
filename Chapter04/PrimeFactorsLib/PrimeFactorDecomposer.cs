using System;
using System.Text;

namespace PrimeFactorsLib
{
    public class PrimeFactorDecomposer
    {
        /// <summary>
        /// Finds the prime factors of number up to 100
        /// </summary>
        /// <param name="number">The number to decompose into prime factors</param>
        /// <returns>The list of prime factors of<paramref name="number"/> e.g. 2 x 2 x 3</returns>
        public static string PrimeFactors(int number)
        {
            
            string primeFactors = "";
            const int FIRST_PRIME = 2;

            for (int i = FIRST_PRIME; i <= number; i++)
            {
                // Number is divisible by i
                if (number % i == 0)
                {
                    // Start again from other the factor in the pair
                    number = number / i;
                    primeFactors += $"{i} x ";

                    // Start again from i = 2 on the next cycle,
                    // accounting for the effect of i++
                    i = FIRST_PRIME - 1;
                }
            }
            // Remove last three characters (' x ') from the string
            if (primeFactors.Length >= 3)
            {
                return primeFactors.Substring(0, primeFactors.Length-3);
            }

            return primeFactors;
        }

        public static string PrimeFactorsFunctional(int number)
        {
            string primeFactors = "";
            const int FIRST_PRIME = 2;
            if (number < FIRST_PRIME)
            {
                return "";
            }

            for (int i = FIRST_PRIME; i < number; i++)
            {
                if(number % i == 0)
                {
                    int otherFactor = number/i;
                    primeFactors = $"{i} x " + PrimeFactorsFunctional(otherFactor);
                    return primeFactors;
                }
            }

            // number has no prime factors so is prime itself
            // Therefore, it's the last prime factor of the original number.
            return number.ToString();
        }
    }
}
