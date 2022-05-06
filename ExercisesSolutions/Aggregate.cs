using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Aggregate
    {
        //Coding Exercise 1
        public static TimeSpan TotalActivityDuration(
            IEnumerable<int> activityTimesInSeconds)
        {
            return activityTimesInSeconds
                 .Aggregate(
                 new TimeSpan(),
                 (totalTimeSpan, activitySeconds) =>
                 totalTimeSpan.Add(
                     TimeSpan.FromSeconds(activitySeconds)));
        }

        //Coding Exercise 2
        public static string PrintAlphabet(int count)
        {
            if (count < 1 || count > 26)
            {
                throw new ArgumentException($"'{nameof(count)}' must be between 1 and 26");
            }
            return Enumerable.Range(1, count - 1)
                .Aggregate("a", (accumulated, index) => $"{accumulated},{(char)('a' + index)}");
        }

        //Refactoring challenge
        public static IEnumerable<int> Fibonacci_Refactored(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException(
                    $"Can't generate Fibonacci sequence " +
                    $"for {n} elements. N must be a " +
                    $"positive number");
            }

            if (n == 1)
            {
                return new[] { 0 };
            }
            return Enumerable.Range(1, n - 2)
                .Aggregate(
                new List<int> { 0, 1 } as IEnumerable<int>,
                (sequence, nextIndex) => sequence.Append(
                    sequence.ElementAt(nextIndex - 1) +
                    sequence.ElementAt(nextIndex)));
        }

        //do not modify this method
        public static IEnumerable<int> Fibonacci(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException(
                    $"Can't generate Fibonacci sequence " +
                    $"for {n} elements. N must be a " +
                    $"positive number");
            }

            if (n == 1)
            {
                return new[] { 0 };
            }
            var result = new List<int> { 0, 1 };
            for (int i = 1; i < n - 1; ++i)
            {
                result.Add(result[i - 1] + result[i]);
            }
            return result;
        }
    }
}
