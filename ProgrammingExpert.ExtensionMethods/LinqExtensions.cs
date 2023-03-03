using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExpert.ExtensionMethods
{
    public static class LinqExtensions
    {
        private static readonly Random _random = new Random();

        public static int TakeRandom(this IEnumerable<int> enumerable)
        {
            int randomIndex = _random.Next(enumerable.Count());
            return enumerable.ElementAt(randomIndex);
        }
    }
}
