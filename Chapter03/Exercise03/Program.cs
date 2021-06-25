using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 100;
            for (int n = 0; n <= max; n++)
            {
                string message = n switch
                {
                    int x when (x % 3 == 0) && (x % 5 == 0)
                        => "FizzBuzz",
                    int x when (x % 3 == 0)
                        => "Fizz",
                    int x when (x % 5 == 0)
                        => "Buzz",
                    int x
                        => x.ToString()
                };

                Write($"{message, -8} ");
                if(n%10==0)
                {
                    WriteLine();
                }
            }
        }
    }
}