using PeopleLibrary.Shared;
using System;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            WriteLine($"{bob.Name} was born on {bob.DateOfBirth:dddd, d MMMM yyyy}");

            var alice = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };
            WriteLine($"{alice.Name} was born on {alice.DateOfBirth:dd MM yy}");

            bob.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            WriteLine($"{bob.Name}'s favourite ancient wonder is {bob.FavouriteAncientWonder}. Its integer value is {(int)bob.FavouriteAncientWonder}");

            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

            bob.Children.Add(new Person { Name = "Alfred" });
            bob.Children.Add(new Person { Name = "Zoe" });
            WriteLine($"{bob.Name} has {bob.Children.Count} children:");
            foreach (var child in bob.Children)
            {
                WriteLine(child.Name);
            }

            BankAccount.InterestRate = 0.012M;

            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs Jones";
            jonesAccount.Balance = 2400;
            WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C} interest");

            var smithAccount = new BankAccount();
            smithAccount.AccountName = "Mr Smith";
            smithAccount.Balance = 98;
            WriteLine($"{smithAccount.AccountName} earned {smithAccount.Balance * BankAccount.InterestRate:C} interest");

            WriteLine($"{bob.Name} is a {Person.Species}");

            WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

            var blankPerson = new Person();
            WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on {blankPerson.Instantiated:dddd}");

            var gunny = new Person("Gunny", "Mars");
            WriteLine($"{gunny.Name} of {gunny.HomePlanet} was created at {gunny.Instantiated:hh:mm:ss} on {blankPerson.Instantiated:dddd}");

            bob.WriteToconsole();
            WriteLine(bob.GetOrigin());

            (string, int) fruit = bob.GetFruit();
            WriteLine($"There are {fruit.Item2} {fruit.Item1}");

            var namedFruit = bob.GetNamedFruit();
            WriteLine($"There are {namedFruit.Count} {namedFruit.Name}");

            var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

            var thing2 = (bob.Name, bob.Children.Count);
            WriteLine($"{thing2.Name} has {thing2.Count} children.");

            (string fruitName, int fruitNumber) = bob.GetFruit();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

            WriteLine(bob.SayHello());
            WriteLine(bob.SayHello("Emily"));

            WriteLine(bob.OptionalParameters());
            WriteLine(bob.OptionalParameters("Jump!", 98.5));
            WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));
            WriteLine(bob.OptionalParameters("Poke!", active: false));


            // Pattern matching

            object[] passengers = {
        new FirstClassPassenger { AirMiles = 1_419 },
        new FirstClassPassenger { AirMiles = 16_562 },
        new BusinessClassPassenger(),
        new CoachClassPassenger { CarryOnKG = 25.7 },
        new CoachClassPassenger { CarryOnKG = 0 },
      };

            foreach (object passenger in passengers)
            {
                decimal flightCost = passenger switch
                {

                    /* C# 8 syntax
                    FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
                    FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
                    FirstClassPassenger                           => 2000M, */

                    // C# 9 syntax
                    FirstClassPassenger p => p.AirMiles switch
                    {
                        > 35000 => 1500M,
                        > 15000 => 1750M,
                        _ => 2000M
                    },

                    BusinessClassPassenger => 1000M,
                    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                    CoachClassPassenger => 650M,
                    _ => 800M
                };

                WriteLine($"Flight costs {flightCost:C} for {passenger}");
            }
        }
    }
}
