using System;
using static System.Console;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 2 + ++x;
            WriteLine("int x = 3;");
            WriteLine("int y = 2 + ++x;");
            WriteLine($"x: {x,-4} y: {y}");
            WriteLine();

            x = 3 << 2;
            y = 10 >> 1;
            WriteLine("x = 3 << 2;");
            WriteLine("y = 10 >> 1;");
            WriteLine($"x: {x,-4} y: {y}");
            WriteLine();
            
            x = 10 & 8;
            y = 10 | 7;
            WriteLine("x = 10 & 8;");
            WriteLine("y = 10 | 7;");
            WriteLine($"x: {x,-4} y: {y}");
        }
    }
}
