using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================
            //
            // WHILE STATEMENTS
            //
            // ================

            int x = 0;
            while (x < 50)
            {
                WriteLine(x);
                x++;
            }

            string password = string.Empty;

            int attempts = 0;
            const int maxAttempts = 10;
            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                attempts++;
            }
            while (password == "Pa$$w0rd" && !(attempts < maxAttempts));

            if(attempts < 10)
            {
                WriteLine("Correct!");
            }
            else
            {
                WriteLine("Too many attempts.");
            }

            // ==============
            //
            // FOR STATEMENTS
            //
            // ==============

            for(int y = 1; y<= 10; y++)
            {
                WriteLine(y);
            }

            // ==================
            //
            // FOREACH STATEMENTS
            //
            // ==================

            string[] names = {"Adam", "Barry", "Charlie"};
            
            foreach(string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }


        }
    }
}
