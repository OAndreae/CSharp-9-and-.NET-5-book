using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // CAST OPERATOR
            //

            int a = 10;
            double b = a;
            WriteLine(b);

            double c = 9.8;
            int d = (int)c; // loses the .8 part
            WriteLine(d);

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            e = 5_000_000_000;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            // 
            // SYSTEM.CONVERT
            //

            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            //
            // ROUNDING
            //

            double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

            foreach(double n in doubles)
            {
                // uses Banker's Rounding (https://stackoverflow.com/questions/311696/why-does-net-use-bankers-rounding-as-default)
                WriteLine($"ToInt32({n}) is {ToInt32(n)}");
            }

            foreach (double n in doubles)
            {
                WriteLine($"Math.Round({n}, 0, MidpointRounding.AwayFromZero) is {Math.Round(n, 0, MidpointRounding.AwayFromZero)}");
            }

            //
            // CONVERTING TO STRINGS
            //

            int number = 12;
            WriteLine(number.ToString());

            bool boolean = true;
            WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            WriteLine(now.ToString());

            object obj = new object();
            WriteLine(obj.ToString());

            //
            // CONVERTING FROM BINARY TO A STRING
            //
            // e.g. when transmitting a binary object like an image

            // allocate array of 128 bytes
            byte[] binaryObject = new byte[128];

            // populate array with random bytes
            (new Random()).NextBytes(binaryObject);

            WriteLine("Binary Object as bytes:");
            for(int i = 0; i< binaryObject.Length; i++)
            {
                Write($"{binaryObject[i]:X}");
            }
            WriteLine();

            // convert to Base64 string and output as text
            string encoded = ToBase64String(binaryObject);

            WriteLine($"Binary Object as Bas64: {encoded}");

            //
            // PARSING STRINGS
            //

            int age = int.Parse("18");
            DateTime birthday = DateTime.Parse("16 October 2002");

            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}");

            // int count = int.Parse("abc"); // throws System.FormatException

            Write("How many eggs are there? ");
            string input = ReadLine();

            int count;
            if(int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input.");
            }
        }
    }
}
