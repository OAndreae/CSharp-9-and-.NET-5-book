using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");

            for (int row = 0; row < 12; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }

            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;

            do
            {
                Write("Enter a number between 0 and 255: ");

                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number.");
                }
            } while (isNumber);
        }

        static decimal CalculateTax(decimal amount, string regionCode)
        {
            decimal rate = regionCode.ToUpper() switch
            {
                "CH" => 0.08M,
                "DK" or "NO" => 0.25M,
                "GB" or "UK" or "FR" => 0.2M,
                "HU" => 0.27M,
                "OR" or "AK" or "MT" => 0.0M,
                "ND" or "WI" => 0.05M,
                "ME" or "VA" => 0.05M,
                "CA" => 0.0825M,
                _ => 0.06M // Most US states
            };

            return rate * amount;
        }

        static void RunCalculateTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();
            Write("Enter a two-letter region code: ");
            string region = ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount.");
            }
        }

        /// <summary>
        /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
        /// </summary>
        /// <param name="number">Number is a cardinal value e.g. 1, 2, 3 etc.</param>
        /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd etc.</returns>
        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    int lastDigit = number % 10;

                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th"
                    };
                    return $"{number}{suffix}";
            }
        }

        static void RunCardinalToOrdinal()
        {
            for (int i = 1; i <= 40; i++)
            {
                Write($"{CardinalToOrdinal(i)} ");
            }
            WriteLine();
        }

        static int Factorial(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                checked // for overflow
                {
                    return number * Factorial(number - 1);
                }
            }
        }

        static void RunFactorial()
        {
            for (int i = 1; i < 15; i++)
            {
                try
                {
                    WriteLine($"{i}! = {Factorial(i):N0}");
                }
                catch (System.OverflowException)
                {
                    WriteLine($"{i}! is too big for a 32-bit integer.");
                }
            }
        }

        static int FibImperative(int term)
        {
            if (term == 1)
            {
                return 0;
            }
            else if (term == 2)
            {
                return 1;
            }
            else
            {
                return FibImperative(term - 1) + FibImperative(term - 2);
            }
        }

        static void RunFibImperative()
        {
            for (int i = 1; i <= 30; i++)
            {
                WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibImperative(term: i):N0}.");
            }
        }

        static int FibFunctional(int term) => term switch
        {
            1 => 0,
            2 => 1,
            _ => FibFunctional(term - 1) + FibFunctional(term - 2)
        };

        static void RunFibFunctional()
        {
            for (int i = 1; i <= 30; i++)
            {
                WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                  arg0: CardinalToOrdinal(i),
                  arg1: FibFunctional(term: i));
            }
        }
        static void Main(string[] args)
        {
            //RunTimesTable();
            //RunCalculateTax();
            // RunCardinalToOrdinal();
            // RunFactorial();
            // RunFibImperative();
            // RunFibFunctional();
        }

    }
}
