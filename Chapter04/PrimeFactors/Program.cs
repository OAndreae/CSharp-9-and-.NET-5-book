using static System.Console;
using PrimeFactorsLib;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string exitCmd = "exit";
            WriteLine("Please enter positive integers to see their prime factor decomposition.");
            WriteLine($"Enter '{exitCmd}' to stop.");

            for (string input = ""; true;)
            {
                Write("> ");
                input = ReadLine();
                if(input.ToUpper() == exitCmd.ToUpper())
                {
                    return;
                }

                bool isInt = int.TryParse(input, out int number);
                if ((!isInt || number < 2))
                {
                    WriteLine($"'{input}' is invalid. Please input positive integers in the range [2, {int.MaxValue:N0}].");
                    continue;
                }

                string primeFactors = PrimeFactorDecomposer.PrimeFactors(number);
                WriteLine($"{input} = {primeFactors}");
            }
        }
    }
}
