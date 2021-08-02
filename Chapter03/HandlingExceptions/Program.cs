using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("How old are you? ");
            string input = ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch(OverflowException)
            {
                WriteLine("Your age is a valid number format but it is either too large or too small.");
            }
            catch(FormatException)
            {
                WriteLine("The age you entered is not a valid number format.");
            }
            catch (Exception ex)
            {            
                ForegroundColor = ConsoleColor.Red;    
                WriteLine($"{ex.GetType()}: {ex.Message}");
                ForegroundColor = ConsoleColor.White;
            }
            WriteLine("After parsing");
        }
    }
}