using Exercises;
using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class All_Exercise1_Tests
    {
        [Test]
        public void NotAllAreDivisibleBy10()
        {
            var input = new[] { 10, 11, 12 };
            Assert.False(All.AreAllNumbersDivisibleBy10(input),
                $"Test failed for numbers {EnumerableToString(input)}, " +
                $"because the AreAllNumbersDivisibleBy10 method result was True," +
                $" and 11 and 12 are not divisible by 10");
        }

        [Test]
        public void AllAreDivisibleBy10()
        {
            var input = new[] { 10, 20, 30 };
            Assert.True(All.AreAllNumbersDivisibleBy10(input),
                $"Test failed for numbers {EnumerableToString(input)}, " +
                $"because the AreAllNumbersDivisibleBy10 method result was False, " +
                $"and they are all divisible by 10");
        }
    }
}
