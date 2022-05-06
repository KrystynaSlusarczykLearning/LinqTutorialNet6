using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using System;

namespace ExercisesTests
{
    [TestFixture]
    public class OrderBy_QuerySyntax_RefactoringChallenge_Tests
    {
        [Test]
        public void FirstTest()
        {
            var numbers = new[] {
                new DateTime(2019, 10, 11),
                new DateTime(2020, 10, 11),
                new DateTime(2021, 10, 11),
            };

            var expectedResult = new[] {
                new DateTime(2020, 10, 11),
                new DateTime(2021, 10, 11),
                new DateTime(2019, 10, 11),
            };

            var result = OrderByQuerySyntax.OrderDatesByDayOfWeek(numbers);

            CollectionAssert.AreEqual(expectedResult, result, $"For input " +
                $"{EnumerableToString(numbers)} the result shall be" +
                $" {EnumerableToString(expectedResult)} but it was" +
                $" '{EnumerableToString(result)}'");
        }

        [Test]
        public void OrderDatesByDayOfWeekShallWorkCorrectly2()
        {
            var numbers = new[] {
                new DateTime(2018, 10, 11),
                new DateTime(2017, 10, 11),
                new DateTime(2016, 10, 11),
            };

            var expectedResult = new[] {
                new DateTime(2016, 10, 11),
                new DateTime(2017, 10, 11),
                new DateTime(2018, 10, 11),
            };

            var result = OrderByQuerySyntax.OrderDatesByDayOfWeek(numbers);

            CollectionAssert.AreEqual(expectedResult, result, $"For input " +
                $"{EnumerableToString(numbers)} the result shall be " +
                $"{EnumerableToString(expectedResult)} but it was " +
                $"'{EnumerableToString(result)}'");
        }

        [Test]
        public void OrderDatesByDayOfWeekShallWorkCorrectly1_Refactored()
        {
            var numbers = new[] {
                new DateTime(2019, 10, 11),
                new DateTime(2020, 10, 11),
                new DateTime(2021, 10, 11),
            };

            var expectedResult = new[] {
                new DateTime(2020, 10, 11),
                new DateTime(2021, 10, 11),
                new DateTime(2019, 10, 11),
            };

            var result = OrderByQuerySyntax.OrderDatesByDayOfWeek_Refactored(numbers);

            CollectionAssert.AreEqual(expectedResult, result, $"For input " +
                $"{EnumerableToString(numbers)} the result shall be " +
                $"{EnumerableToString(expectedResult)} but it was " +
                $"'{EnumerableToString(result)}'");
        }

        [Test]
        public void OrderDatesByDayOfWeekShallWorkCorrectly2_Refactored()
        {
            var numbers = new[] {
                new DateTime(2018, 10, 11),
                new DateTime(2017, 10, 11),
                new DateTime(2016, 10, 11),
            };

            var expectedResult = new[] {
                new DateTime(2016, 10, 11),
                new DateTime(2017, 10, 11),
                new DateTime(2018, 10, 11),
            };

            var result = OrderByQuerySyntax.OrderDatesByDayOfWeek_Refactored(numbers);

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For input {EnumerableToString(numbers)} the result shall be " +
                $"{EnumerableToString(expectedResult)} but it was " +
                $"'{EnumerableToString(result)}'");
        }
    }
}
