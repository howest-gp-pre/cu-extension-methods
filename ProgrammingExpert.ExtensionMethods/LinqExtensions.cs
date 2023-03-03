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

        public static T TakeRandom<T>(this IEnumerable<T> enumerable)
        {
            int randomIndex = _random.Next(enumerable.Count());
            return enumerable.ElementAt(randomIndex);
        }

        public static IEnumerable<T> ElementsAtEvenPositions<T>(this IEnumerable<T> enumerable)
        {
            bool evenIndex = true;
            foreach (T element in enumerable)
            {
                if (evenIndex)
                {
                    yield return element;
                }
                evenIndex = !evenIndex;
            }
        }

    }
}
