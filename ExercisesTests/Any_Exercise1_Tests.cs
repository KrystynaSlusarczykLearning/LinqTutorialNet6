using Exercises;
using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class Any_Exercise1_Tests
    {
        [Test]
        public void WithNegativeNumbers()
        {
            var input = new[] { 10, -1, 1, 12 };
            Assert.True(
                Any.IsAnyNumberNegative(new[] { 10, -1, 1, 12 }),
                $"The result should be True for numbers: {EnumerableToString(input)}");
        }

        [Test]
        public void WithoutNegativeNumbers()
        {
            var input = new[] { 10, 1, 12 };

            Assert.False(Any.IsAnyNumberNegative(new[] { 10, 1, 12 }),
            $"The result should be False for numbers: {EnumerableToString(input)}");
        }
    }
}
