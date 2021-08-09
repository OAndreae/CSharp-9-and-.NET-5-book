using System;
using System.Collections.Generic;

using static System.Console;

namespace PeopleLibrary.Shared
{
    // Explicit inheritance from object not needed
    public class Person : object
    {
        public string Name;
        public DateTime DateOfBirth;

        public WondersOfTheAncientWorld FavouriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;

        public List<Person> Children = new List<Person>();

        // Bad practice - use readonly instead as it is initialised
        // at runtime, not compile time. This avoids errors when 
        // recompiling assemblies. It can also be assigned a expression
        // that is evaluated at runtime (e.g. a function return value).
        public const string Species = "Homo sapien";

        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public void WriteToconsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string Name, int Count) GetNamedFruit()
        {
            return (Name: "Pears", Count: 3);
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
        {
            return string.Format(
              format: "command is {0}, number is {1}, active is {2}",
              arg0: command, arg1: number, arg2: active);
        }
    }
}
