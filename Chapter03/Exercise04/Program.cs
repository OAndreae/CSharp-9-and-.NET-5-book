using System;
using static System.Console;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {

            Write("Enter a number between 0 and 255: ");
            string input1 = ReadLine();

            Write("Enter another number between 0 and 255: ");
            string input2 = ReadLine();

            try
            {
                byte b1 = byte.Parse(input1);
                byte b2 = byte.Parse(input2);
                WriteLine($"{b1} divided by {b2} is {b1 / b2}");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType().Name}: {ex.Message}");
            }
        }
    }
}
