using Exercises;
using NUnit.Framework;
using System;

namespace ExercisesTests
{
    [TestFixture]
    public class OfType_RefactoringChallenge_Tests
    {
        [Test]
        public void DateTimeIsPresent()
        {
            var input = new object[]
            {
                null,
                new DateTime(2020, 1, 10),
                1,
                "THERE",
                new DateTime(2020, 1, 15),
                new DateTime(2020, 1, 5),
            };

            var result = OfType.GetTheLatestDate(input);
            var expectedResult = new DateTime(2020, 1, 15);
            var resultAsString = result.HasValue ? result.Value.ToString("yyyy/MM/dd") : "null";
            Assert.AreEqual(expectedResult, result, $"Expected result for input (null, '2020/1/10', 1, 'THERE', 2020/1/15, 2020/1/5) is {expectedResult.ToString("yyyy/MM/dd")}, but was {resultAsString}");
        }

        [Test]
        public void DateTimeIsNotPresent()
        {
            var input = new object[]
            {
                null,
                1,
                "THERE"
            };

            var result = OfType.GetTheLatestDate(input);
            var resultAsString = result.HasValue ? result.Value.ToString("yyyy/MM/dd") : "null";
            Assert.Null(result, $"Expected result for input (null,  1, 'THERE') is null, but was {resultAsString}");
        }

        [Test]
        public void EmptyCollection()
        {
            var input = new object[]
            {
            };

            var result = OfType.GetTheLatestDate(input);
            var resultAsString = result.HasValue ? result.Value.ToString("yyyy/MM/dd") : "null";
            Assert.Null(result, $"Expected result for empty collection is null, but was {resultAsString}");
        }

        [Test]
        public void DateTimeIsPresent_Refactored()
        {
            var input = new object[]
            {
                null,
                new DateTime(2020, 1, 10),
                1,
                "THERE",
                new DateTime(2020, 1, 15),
                new DateTime(2020, 1, 5),
            };

            var result = OfType.GetTheLatestDate_Refactored(input);
            var expectedResult = new DateTime(2020, 1, 15);
            var resultAsString = result.HasValue ? result.Value.ToString("yyyy/MM/dd") : "null";
            Assert.AreEqual(expectedResult, result, $"Expected result for input (null, '2020/1/10', 1, 'THERE', 2020/1/15, 2020/1/5) is {expectedResult.ToString("yyyy/MM/dd")}, but was {resultAsString}");
        }

        [Test]
        public void DateTimeIsNotPresent_Refactored()
        {
            var input = new object[]
            {
                null,
                1,
                "THERE"
            };

            var result = OfType.GetTheLatestDate_Refactored(input);
            var resultAsString = result.HasValue ? result.Value.ToString("yyyy/MM/dd") : "null";
            Assert.Null(result, $"Expected result for input (null,  1, 'THERE') is null, but was {resultAsString}");
        }

        [Test]
        public void EmptyCollection_Refactored()
        {
            var input = new object[]
            {
            };

            var result = OfType.GetTheLatestDate_Refactored(input);
            var resultAsString = result.HasValue ? result.Value.ToString("yyyy/MM/dd") : "null";
            Assert.Null(result, $"Expected result for empty collection is null, but was {resultAsString}");
        }
    }
}
