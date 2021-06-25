using System;
using static System.Console;

namespace BitewiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // 0000 1010
            int b = 6; //  0000 0110
            WriteLine($"a & b = {a & b}"); // AND => 0000 0010
            WriteLine($"a | b = {a | b}"); // OR => 0000 1110
            WriteLine($"a ^ b = {a ^ b}"); // XOR => 0000 1100

            // left-shift a by three bit columns => 0101 0000
            // equivalent to multiplying by 8
            // CPUs can perform bit-shifting more quickly
            WriteLine($"a << 3 = {a << 3}");

            // multiply by 8
            WriteLine($"a * 8 = {a * 8}");

            // right-shift b by one bit column
            WriteLine($"b >> 1 = {b >> 1}");
        }
    }
}
