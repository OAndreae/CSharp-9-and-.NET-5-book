#nullable enable

using System;

namespace NullHandling
{

    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {

        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            // thisCannotBeNull = null; // compile error

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull); // outputs a blank line as value is null
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault()); // outputs 0 (the default value)

            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            /*
                NULLABLE AND NON-NULLABLE REFERENCE TYPES
            */

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;

            string authorName = null;

            // the following throws a NullReferenceException
            // int x = authorName.Length;

            // instead of throwing an exception, null is assigned to y
            int? y = authorName?.Length;

            // NULL-COALESCING OPERATOR

            // simplified using the null-coalescing operator (below)
            int result;
            if (authorName == null)
            {
                result = 3;
            }
            else
            {
                result = authorName.Length;
            }

            // result will be 3 if authorName?.Length is null
            var result2 = authorName?.Length ?? 3;
            Console.WriteLine(result2);
        }
    }
}