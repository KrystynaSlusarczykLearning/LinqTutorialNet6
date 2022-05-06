using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using System;

namespace ExercisesTests
{
    [TestFixture]
    public class Zip_Exercise2_Tests
    {
        [Test]
        public void GetDaysDifferencesBetweenDatesShallWorkCorrectly1()
        {
            var dates = new[] {
                new DateTime(1899, 1, 1),
                new DateTime(1899, 4, 12),
                new DateTime(1899, 12, 31)};

            var result = Zip.GetDaysDifferencesBetweenDates(dates);
            var expectedResult = new[] {
                "It's been 101 days between 1899-01-01 and 1899-04-12",
                "It's been 263 days between 1899-04-12 and 1899-12-31",
            };

            Assert.AreEqual(expectedResult, result, $"For dates {EnumerableToString(dates)} the result shall be {EnumerableToString(expectedResult)} but it was '{EnumerableToString(result)}'");
        }

        [Test]
        public void GetDaysDifferencesBetweenDatesShallWorkCorrectly2()
        {
            var dates = new[] {
                new DateTime(1899, 1, 1),
                new DateTime(1914, 4, 12),
                new DateTime(1929, 12, 31),
                new DateTime(1956, 2, 3) };

            var result = Zip.GetDaysDifferencesBetweenDates(dates);
            var expectedResult = new[] {
                "It's been 5579 days between 1899-01-01 and 1914-04-12",
                "It's been 5742 days between 1914-04-12 and 1929-12-31",
                "It's been 9530 days between 1929-12-31 and 1956-02-03"
            };

            Assert.AreEqual(expectedResult, result, $"For dates " +
                $"{EnumerableToString(dates)} the result shall be " +
                $"{EnumerableToString(expectedResult)} but it was " +
                $"'{EnumerableToString(result)}'");
        }

        [Test]
        public void EmptyDates()
        {
            var dates = new DateTime[] { };

            var result = Zip.GetDaysDifferencesBetweenDates(dates);
            var expectedResult = new string[] {
            };

            Assert.AreEqual(expectedResult, result, $"For empty dates the result " +
                $"shall be empty, but it was '{EnumerableToString(result)}'");
        }

        [Test]
        public void OneDate()
        {
            var dates = new DateTime[] { new DateTime(1899, 12, 31) };

            var result = Zip.GetDaysDifferencesBetweenDates(dates);
            var expectedResult = new string[] {
            };

            Assert.AreEqual(expectedResult, result, 
                $"For single-date input the result shall be empty, but it was " +
                $"'{EnumerableToString(result)}'");
        }
    }
}
