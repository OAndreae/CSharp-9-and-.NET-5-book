using System;
using System.IO;
using System.Xml;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                STORING ANY TYPE OF OBJECT
            */

            object height = 1.88;
            object name = "Amir";
            Console.WriteLine($"{name} is {height} metres tall.");

            // int length1 = name.Length; // compiler error
            int length2 = ((string)name).Length;
            Console.WriteLine($"{name} has {length2} characters.");

            /*
                STORING DYNAMIC TYPES
            */

            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";

            // this compiles but would throw an exception at run-time
            // if you later store a data type that does not have a 
            // property named Length
            int length = anotherName.Length;

            /*
                SPECIFYING AND INFERRING THE TYPE OF A LOCAL
                VARIABLE
            */

            // int population = 66_000_000; // 66 million in the UK
            // double weight = 1.88; // in kilograms
            // decimal price = 4.99M; // in pounds sterling
            // string fruit = "Apples"; // strings use double-quotes
            // char letter = 'Z'; // chars use single-quotes
            // bool happy = true; // Booleans have value of true and false

            var population = 66_000_000; // 66 million in the UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; // chars use single-quotes
            var happy = true; // Booleans have value of true and false

            // good use of var because it avoids the repeated type
            // as shown in the more verbose second statement
            var xml1 = new XmlDocument();
            XmlDocument xml2 = new XmlDocument();

            // bad use of var because we cannot tell the type, so we
            // should use a specific type declaration as shown in
            // the second statement
            var file1 = File.CreateText(@"D:\Code\C# 9 and .NET 5 book\Chapter02\something.txt");
            StreamWriter file2 = File.CreateText(@"D:\Code\C# 9 and .NET 5 book\Chapter02\something else.txt");

            /* 
                TARGET-TYPED NEW
            */

            XmlDocument xml3 = new();

            /*
                DEFAULT VALUES
            */

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");            
        }
    }
}
