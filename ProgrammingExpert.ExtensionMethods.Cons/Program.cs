using System;

namespace ProgrammingExpert.ExtensionMethods.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 100;
            bool result = i.IsGreaterThan(j);

            Console.WriteLine($"Is {i} greater than {j}? Answer is: {result}");
            Console.ReadLine();
        }
    }
}
