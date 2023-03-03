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
            Console.WriteLine();

            // even positions
            var numbersAtEvenPosition = numbers.ElementsAtEvenPositions();
            Console.WriteLine("Numbers at even positions:");
            Console.WriteLine("--------------------------");
            foreach (int number in numbersAtEvenPosition)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            var namesAtEvenPosition = names.ElementsAtEvenPositions();
            Console.WriteLine("Names at even positions:");
            Console.WriteLine("------------------------");
            foreach (string name in namesAtEvenPosition)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // combined
            string randomNameAtEvenPosition = names
                .ElementsAtEvenPositions()
                .TakeRandom();

            Console.WriteLine("Random name at even position:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Result: {randomNameAtEvenPosition}");
            Console.WriteLine();

            int sumNumbersAtEvenPositionSkipFirstTwo = numbers
                .Skip(2)
                .ElementsAtEvenPositions()
                .Sum();

            Console.WriteLine("Sum of numbers at even position (skip first two):");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Result: {sumNumbersAtEvenPositionSkipFirstTwo}");

            Console.ReadLine();
        }
    }
}
