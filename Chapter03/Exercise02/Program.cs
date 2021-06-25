using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int max = 500;
                    for(byte i = 0; i<max; i++)
                    {
                        WriteLine(i);
                    }
                }    
            }
            catch(OverflowException)
            {
                WriteLine($"Overflow exception occurred.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()}: {ex.Message}");
            }
        }
    }
}
