using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Distinct
    {
        //Coding Exercise 1
        public static bool AreAllUnique<T>(IEnumerable<T> collection)
        {
            return collection.Distinct().Count() == collection.Count();
        }

        //Coding Exercise 2
        public static IEnumerable<T> GetCollectionWithMostDuplicates<T>(
            IEnumerable<IEnumerable<T>> collections)
        {
            return collections
           .OrderBy(collection => collection.Count() - collection.Distinct().Count())
           .ThenByDescending(collection => collection.Count())
           .LastOrDefault();
        }

        //Refactoring challenge
        public static IEnumerable<string> GetWordsShorterThan5Letters_Refactored(
            IEnumerable<string> words)
        {
            return words.Distinct().Where(word => word.Length < 5);
        }

        //do not modify this method
        public static IEnumerable<string> GetWordsShorterThan5Letters(
            IEnumerable<string> words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                if (word.Length < 5 && !result.Contains(word))
                {
                    result.Add(word);
                }
            }
            return result;
        }
    }
}
