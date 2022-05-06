using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class ConcatUnion
    {
        //Coding Exercise 1
        public static IEnumerable<News> SelectRecentAndImportant(IEnumerable<News> newsCollection)
        {
            return newsCollection
            .OrderByDescending(news => news.PublishingDate)
            .Take(3)
            .Concat(newsCollection.Where(news => news.Priority == Priority.High))
            .Distinct();
        }

        //Coding Exercise 2
        public static string CleanWord(string word)
        {
            var wordAsCharArray = word.ToCharArray();

            return new string(wordAsCharArray
                .Where(character => char.IsLetter(character))
                .Concat(
                    wordAsCharArray.Where(character => 
                    !char.IsLetter(character)).Distinct()).ToArray());
        }

        //Refactoring challenge
        public static IEnumerable<int> GetPerfectSquares_Refactored(
            IEnumerable<int> numbers1, IEnumerable<int> numbers2)
        {
            return numbers1
                .Where(HasNaturalSquareRoot)
                .Concat(numbers2
                    .Where(HasNaturalSquareRoot))
                .Distinct()
                .OrderBy(number => number);
        }

        static bool HasNaturalSquareRoot(int number) => Math.Sqrt(number) % 1 == 0;

        //do not modify this method
        public static IEnumerable<int> GetPerfectSquares(
            IEnumerable<int> numbers1, IEnumerable<int> numbers2)
        {
            var result = new List<int>();
            foreach (var number in numbers1)
            {
                if (Math.Sqrt(number) % 1 == 0 && !result.Contains(number))
                {
                    result.Add(number);
                }
            }
            foreach (var number in numbers2)
            {
                if (Math.Sqrt(number) % 1 == 0 && !result.Contains(number))
                {
                    result.Add(number);
                }
            }
            result.Sort();
            return result;
        }

        public struct News
        {
            public DateTime PublishingDate { get; set; }
            public Priority Priority { get; set; }

            public override string ToString()
            {
                return $"Date: {PublishingDate.ToString("d")}, Priority: {Priority}";
            }
        }

        public enum Priority
        {
            Low,
            Medium,
            High
        }
    }
}
