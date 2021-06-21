using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned integer means a positive whole number
            // including 0 (i.e. the natural numbers)
            uint naturalNumber = 23;

            // integer means negative or positive whole number
            // including 0
            int integerNumber = -23;

            // float means single-precision floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;

            // double means double-precision floating point 
            double anotherRealNumber = 2.3;

            /*
                STORING WHOLE NUMBERS 
            */

            // three variables that store the number 2 million
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            // check the three variables have the same value
            // both statements output true
            Console.WriteLine($"\n{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

            /*
                EXPLORING NUMBER SIZES
            */

            Console.WriteLine($"\nint uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");


            /*
                COMPARING DOUBLE AND DECIMAL TYPES
            */
            Console.WriteLine("\nUsing doubles:");
            double a = 0.1;
            double b = 0.2;
            
            // BAD PRACTICE: Don't compare double values using ==
            // http://www-users.math.umn.edu/~arnold//disasters/patriot.html 
            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }

            Console.WriteLine("Using decimals:");
            decimal c = 0.1M; // M suffix means a decimal literal value
            decimal d = 0.2M;

            if (c + d == 0.3M)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }

            /*
                STORING BOOLEANS
            */

            bool happy = true;
            bool sad = false;

        }
    }
}
