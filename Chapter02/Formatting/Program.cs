using System;
using static System.Console;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;

            /*
                NUMBERED POSITIONAL ARGUMENTS
            */

            WriteLine(
                format: "{0} apples cost {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);
            
            string formatted = string.Format(
                format: "{0} apples cost {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);

            // WriteToFile(formatted); // example usage (albeit with nonexistant method)

            /*
                INTERPOLATED STRINGS
            */

            WriteLine($"{numberOfApples} apples cost {pricePerApple*numberOfApples:C}");

            /*
                ALIGNING TEXT
            */
            WriteLine();
            string applesText = "Apples";
            int applesCount = 1234;

            string bananasText = "Bananas";
            int bananasCount = 56789;

            WriteLine(
                format: "{0, -8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count");
            
            WriteLine($"{applesText,-8} {applesCount, 6:N0}");
            WriteLine($"{bananasText, -8} {bananasCount, 6:N0}");

            /*
                GETTING TEXT INPUT
            */

            Write("Type your name and press ENTER: ");
            string firstName = ReadLine();

            Write("Type your age and press ENTER: ");
            string age = ReadLine();

            WriteLine($"Hello, {firstName.Trim()}, you were born over {age} years ago.");

            /*
                GETTING KEY INPUT
            */

            Write("Press any key combination: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifiers: {key.Modifiers}");

        }
    }
}
