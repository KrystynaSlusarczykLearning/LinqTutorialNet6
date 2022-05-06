using Exercises;
using NUnit.Framework;
using System.Collections.Generic;
using static ExercisesTests.Utilities.TestUtilities;
using Point = Exercises.SelectMany.Point;

namespace ExercisesTests
{
    [TestFixture]
    public class SelectMany_RefactoringChallenge_Tests
    {
        [Test]
        public void ShallCalculateLengthsCorrectly()
        {
            var starts = new[]
            {
                new Point{X = 5, Y = 5},
                new Point{X = 3, Y = 3},
            };

            var ends = new[]
            {
                new Point{X = 0, Y = 5},
                new Point{X = 4, Y = 5},
            };

            var result = SelectMany.SegmentsLengths(starts, ends);
            var expectedResult = new Dictionary<string, double>
            {
                ["Start: (X: 5, Y: 5), End: (X: 0, Y: 5)"] = 5,
                ["Start: (X: 5, Y: 5), End: (X: 4, Y: 5)"] = 1,
                ["Start: (X: 3, Y: 3), End: (X: 0, Y: 5)"] = 3.60,
                ["Start: (X: 3, Y: 3), End: (X: 4, Y: 5)"] = 2.23,
            };

            Assert.That(result, Is.EqualTo(expectedResult).AsCollection.Within(0.1),
                $"For starts {EnumerableToString(starts)} and ends " +
                $"{EnumerableToString(ends)} the result shall be " +
                $"{DictionaryToString(expectedResult)} but it was {DictionaryToString(result)}");
        }

        [Test]
        public void ShallCalculateLengthsCorrectly_Refactored()
        {
            var starts = new[]
            {
                new Point{X = 5, Y = 5},
                new Point{X = 3, Y = 3},
            };

            var ends = new[]
            {
                new Point{X = 0, Y = 5},
                new Point{X = 4, Y = 5},
            };

            var result = SelectMany.SegmentsLengths_Refactored(starts, ends);
            var expectedResult = new Dictionary<string, double>
            {
                ["Start: (X: 5, Y: 5), End: (X: 0, Y: 5)"] = 5,
                ["Start: (X: 5, Y: 5), End: (X: 4, Y: 5)"] = 1,
                ["Start: (X: 3, Y: 3), End: (X: 0, Y: 5)"] = 3.60,
                ["Start: (X: 3, Y: 3), End: (X: 4, Y: 5)"] = 2.23,
            };

            Assert.That(result, Is.EqualTo(expectedResult).AsCollection.Within(0.1),
                $"For starts {EnumerableToString(starts)} and ends " +
                $"{EnumerableToString(ends)} the result shall be " +
                $"{DictionaryToString(expectedResult)} but it was " +
                $"{DictionaryToString(result)}");
        }
    }
}
