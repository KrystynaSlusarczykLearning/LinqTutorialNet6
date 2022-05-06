using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using System;

namespace ExercisesTests
{
    [TestFixture]
    public class Zip_Exercise1_Tests
    {
        [Test]
        public void BuildDatesShallWorkCorrectly1()
        {
            var years = new[] { 2020, 1990, 2010 };
            var months = new[] { 3, 5, 1 };
            var days = new[] { 1, 5, 17 };
            var result = Zip.BuildDates(years, months, days);
            var expectedResult = new[] { new DateTime(1990, 5, 5), new DateTime(2010, 1, 17), new DateTime(2020, 3, 1) };

            Assert.AreEqual(expectedResult, result, $"For years " +
                $"{EnumerableToString(years)}, months {EnumerableToString(months)} " +
                $"and days {EnumerableToString(days)} the result shall be" +
                $" {EnumerableToString(expectedResult)} but it was " +
                $"'{EnumerableToString(result)}'");
        }

        [Test]
        public void BuildDatesShallWorkCorrectly2()
        {
            var years = new[] { 1564, 1891 };
            var months = new[] { 2, 12 };
            var days = new[] { 9, 10 };
            var result = Zip.BuildDates(years, months, days);
            var expectedResult = new[] { new DateTime(1564, 2, 9), new DateTime(1891, 12, 10) };

            Assert.AreEqual(expectedResult, result, $"For years " +
                $"{EnumerableToString(years)}, months {EnumerableToString(months)} " +
                $"and days {EnumerableToString(days)} the result shall be " +
                $"{EnumerableToString(expectedResult)} but it was " +
                $"'{EnumerableToString(result)}'");
        }
    }
}
