using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class OrderBy
    {
        //Coding Exercise 1
        public static IEnumerable<string> OrderFromLongestToShortest(
            IEnumerable<string> words)
        {
            return words.OrderByDescending(word => word.Length);
        }

        //Coding Exercise 2
        public static IEnumerable<int> FirstEvenThenOddDescending(
            IEnumerable<int> numbers)
        {
            return numbers
                .OrderBy(number => number % 2 != 0)
                .ThenByDescending(number => number);
        }

        //Refactoring challenge
        public static IEnumerable<DateTime> OrderByMonth_Refactored(
            List<DateTime> dates)
        {
            return dates.OrderBy(date => date.Month);
        }

        //do not modify this method
        public static IEnumerable<DateTime> OrderByMonth(List<DateTime> dates)
        {
            dates.Sort((left, right) =>
            {
                return left.Month.CompareTo(right.Month);
            });
            return dates;
        }
    }
}
