using System.Collections.Generic;

namespace RemoveDuplicatesKata
{
    static class RemoveDuplicates
    {
        public static T[] Simplify<T>(T[] input)
        {
            List<T> results = (List<T>) Simplify(new List<T>(input));
            return results.ToArray();
        }

        public static ICollection<T> Simplify<T>(IList<T> input)
        {
            return Simplify(input, new List<T>());
        }
        
        public static ICollection<T> Simplify<T>(ICollection<T> input, ICollection<T> results)
        {
            Atavism(input, results);
            return results;
        }

        /****************************************************************************/
        private static void Atavism<T>(ICollection<T> input, ICollection<T> results)
        {
            foreach (T item in input)
            {
                AddIfNotDuplicate(results, item);
            }
        }

        public static void AddIfNotDuplicate<T>(ICollection<T> collection, T item)
        {
            if (!collection.Contains(item))
            {
                collection.Add(item);
            }
        }
    }
}
