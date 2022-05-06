using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class MinMax_Exercise2_Tests
    {
        [Test]
        public void TwoLArgestNumbers()
        {
            var numbers = new[] { 3, 2, 2, 4, 4, 0 };
            var numbersAsString = string.Join(", ", numbers);
            var result = MinMax.CountOfLargestNumbers(numbers);
            Assert.AreEqual(2, result, $"The test failed. " +
                $"The result for the list ({numbersAsString}) should be 2, but the result was {result}.");
        }

        [Test]
        public void OneLArgestNumber()
        {
            var numbers = new[] { 3, 2, 2, 4, 0 };
            var numbersAsString = string.Join(", ", numbers);
            var result = MinMax.CountOfLargestNumbers(numbers);
            Assert.AreEqual(1, result, $"The test failed. " +
                $"The result for the list ({numbersAsString}) should be 1, but the result was {result}.");
        }

        [Test]
        public void EmptyCollectionTest()
        {
            var numbers = new int[0];
            var result = MinMax.CountOfLargestNumbers(numbers);
            Assert.AreEqual(0, result, $"The test failed. " +
                $"The result for the empty list should be 0, but the result was {result}.");
        }
    }
}
