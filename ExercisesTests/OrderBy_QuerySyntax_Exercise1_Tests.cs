using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using System;
using System.Collections.Generic;

namespace ExercisesTests
{
    [TestFixture]
    public class OrderBy_QuerySyntax_Exercise1_Tests
    {
        [Test]
        public void OrderFromLongestToShortestShallWorkCorrectly1()
        {
            var timespans = new List<TimeSpan>
            {
                TimeSpan.FromSeconds(93),
                TimeSpan.FromSeconds(10),
                TimeSpan.FromSeconds(16),
                TimeSpan.FromSeconds(71),
            };

            var expectedResult = new List<TimeSpan>
            {
                TimeSpan.FromSeconds(93),
                TimeSpan.FromSeconds(71),
                TimeSpan.FromSeconds(16),
                TimeSpan.FromSeconds(10),
            };

            var result = OrderByQuerySyntax.OrderFromLongestToShortest(timespans);

            CollectionAssert.AreEqual(expectedResult, result, $"For input " +
                $"{EnumerableToString(timespans)} the result shall be " +
                $"{EnumerableToString(expectedResult)} but it was " +
                $"'{EnumerableToString(result)}'");
        }

        [Test]
        public void OrderFromLongestToShortestShallWorkCorrectly2()
        {
            var timespans = new List<TimeSpan>
            {
                TimeSpan.FromSeconds(93),
                TimeSpan.FromSeconds(5),
                TimeSpan.FromSeconds(16),
            };

            var expectedResult = new List<TimeSpan>
            {
                TimeSpan.FromSeconds(93),
                TimeSpan.FromSeconds(16),
                TimeSpan.FromSeconds(5),
            };

            var result = OrderByQuerySyntax.OrderFromLongestToShortest(timespans);

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For input {EnumerableToString(timespans)} the result shall be " +
                $"{EnumerableToString(expectedResult)} but it was " +
                $"'{EnumerableToString(result)}'");
        }
    }
}
