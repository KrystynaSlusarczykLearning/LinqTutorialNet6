using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class GeneratingNewCollection
    {
        //Coding Exercise 1
        public static Dictionary<int, string> NewYearsEvesSince(
            int initialYear, int yearsCount)
        {
            return
                Enumerable.Range(initialYear, yearsCount)
                .ToDictionary(year => year,
                year => new DateTime(year, 12, 31).DayOfWeek.ToString());
        }

        //Coding Exercise 2
        public static string BuildTree(int levels)
        {
            return string.Join(Environment.NewLine, Enumerable.Range(1, levels)
                .Select(level =>
                string.Join("", Enumerable.Repeat("*", level))));
        }

        //Refactoring challenge
        public static IEnumerable<string> DoubleLetters_Refactored(int countOfLetters)
        {
            const int CountOfLettersInEnglishAlphabet = 26;
            var finalCountOfLetters = Math.Min(
                countOfLetters,
                CountOfLettersInEnglishAlphabet);

            var allLetters = Enumerable
                .Range('A', finalCountOfLetters)
                .Select(i => (char)i);

            return allLetters.SelectMany(
                letter => allLetters, (first, second) => $"{first}{second}");
        }

        //do not modify this method
        public static IEnumerable<string> DoubleLetters(int countOfLetters)
        {
            const int CountOfLettersInEnglishAlphabet = 26;
            var finalCountOfLetters = Math.Min(
                countOfLetters,
                CountOfLettersInEnglishAlphabet);

            var allLetters = new List<char>();
            var letter = 'A';
            for (int i = 0; i < finalCountOfLetters; ++i)
            {
                allLetters.Add(letter);
                letter++;
            }

            var result = new List<string>();
            foreach (var firstLetter in allLetters)
            {
                foreach (var secondLetter in allLetters)
                {
                    result.Add($"{firstLetter}{secondLetter}");
                }
            }
            return result;
        }
    }
}
