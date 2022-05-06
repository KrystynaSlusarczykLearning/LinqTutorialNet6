using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using System;

namespace ExercisesTests
{
    [TestFixture]
    public class Aggregate_Exercise1_Tests
    {
        [Test]
        public void ShallCalculateTotalActivityDurationCorrectly1()
        {
            var input = new[] { 10, 50, 121 };
            var result = Aggregate.TotalActivityDuration(input);
            var expectedResult = TimeSpan.FromSeconds(181);
            Assert.AreEqual(expectedResult, result, $"For input '{EnumerableToString(input)}' the result shall be '{expectedResult}' but it was '{result}'");
        }

        [Test]
        public void ShallCalculateTotalActivityDurationCorrectly2()
        {
            var input = new[] { 20, 0, 10, 50, 121 };
            var result = Aggregate.TotalActivityDuration(input);
            var expectedResult = TimeSpan.FromSeconds(201);
            Assert.AreEqual(expectedResult, result, $"For input '{EnumerableToString(input)}' the result shall be '{expectedResult}' but it was '{result}'");
        }
    }
}
