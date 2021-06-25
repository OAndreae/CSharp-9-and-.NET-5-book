using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // throws an exception if a variable overflows at runtime
                checked
                {
                    int x = int.MaxValue - 1;
                    WriteLine($"Initial value: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                }
            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed but I caught the exception.");
            }

            // prevents compile-time errors due to overflow of variables
            unchecked
            {
                int y = int.MaxValue + 1;
                WriteLine($"Initial value: {y}");
                y--;
                WriteLine($"After decrementing: {y}");
                y--;
                WriteLine($"After decrementing: {y}");
            }

        }
    }
}
