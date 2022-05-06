using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Zip
    {
        //Coding Exercise 1
        public static IEnumerable<DateTime> BuildDates(
            IEnumerable<int> years,
            IEnumerable<int> months,
            IEnumerable<int> days)
        {
            return years.Zip(months,
                (year, month) => new { year, month }).Zip(days,
                (yearMonth, day) => new DateTime(
                    yearMonth.year, yearMonth.month, day))
                .OrderBy(date => date);
        }

        //Coding Exercise 2
        public static IEnumerable<string>
            GetDaysDifferencesBetweenDates(
                IEnumerable<DateTime> dates)
        {
            return dates.Zip(dates.Skip(1),
                (first, second) => $"It's been " +
                $"{(second - first).TotalDays} days " +
                $"between {first.ToString("yyyy-MM-dd")} " +
                $"and {second.ToString("yyyy-MM-dd")}");
        }

        //Refactoring challenge
        public static IEnumerable<string> MakeList_Refactored(IEnumerable<string> words)
        {
            return Enumerable
                .Range('A', words.Count())
                .Select(letter => (char)letter)
                .Zip(words, (letter, word) => $"{letter}) {word}");
        }

        //do not modify this method
        public static IEnumerable<string> MakeList(IEnumerable<string> words)
        {
            var result = new List<string>();
            char letter = 'A';
            foreach (var word in words)
            {
                result.Add($"{letter}) {word}");
                letter++;
            }
            return result;
        }
    }
}
