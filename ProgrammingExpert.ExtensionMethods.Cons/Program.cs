using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingExpert.ExtensionMethods.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            // string
            string[] animals = { "monkey", "bear", "rabbit", "wolf" };

            if ("bear".In(animals))
                Console.WriteLine($"Found a bear in animals!");
            else
                Console.WriteLine($"Found no bear");

            // int
            List<int> numbers = new List<int> { 1, 3, 6, 34, 65, 456, 343, 694 };

            if (456.In(numbers))
                Console.WriteLine($"Found 456 in numbers!");
            else
                Console.WriteLine($"Number 456 was not found!");

            // random int
            int randomNumber = numbers.TakeRandom();
            Console.WriteLine($"Random number from list: {randomNumber}");

            int randomNumberSkipFirstTwo = numbers
                .Skip(2)
                .TakeRandom();
            Console.WriteLine($"Random number from list (skip first 2): {randomNumberSkipFirstTwo}");

            // random string
            string[] names = { "Alice", "Bob", "Carol", "Dave", "Eve" };
            string randomName = names.TakeRandom();
            Console.WriteLine($"Randomly chosen name: {randomName}");

            Console.ReadLine();
        }
    }
}
