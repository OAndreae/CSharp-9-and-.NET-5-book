﻿using System;
using System.Text;

namespace PrimeFactorsLib
{
    public class PrimeFactorDecomposer
    {
        /// <summary>
        /// Finds the prime factors of number up to 100
        /// </summary>
        /// <param name="number">The number to decompose into prime factors</param>
        /// <returns>A list of prime factors e.g. 2 x 2 x 3</returns>
        string PrimeFactors(int number)
        {
            StringBuilder builder = new();
            for (int i = 0; i < number; i++)
            {
                // number is divisible by i
                if (number % i == 0)
                {
                    // start again from other pair
                    number = number / i;
                    i = 2;
                    builder.Append($"{i} x ");
                }
            }
            // Remove last three characters (' x ') from the string
            builder.Length -= 3;
            return builder.ToString();
        }
    }
}
