using System;
using System.Collections.Generic;

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

            Console.ReadLine();
        }
    }
}
