using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class OrderBy_Exercise2_Tests
    {
        [Test]
        public void EvenShallBeBeforeOdd1()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expected = new[] { 6, 4, 2, 7, 5, 3, 1 };
            var result = OrderBy.FirstEvenThenOddDescending(numbers);
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void EvenShallBeBeforeOdd2()
        {
            var numbers = new[] { 1, 2, 3, 4 };
            var expected = new[] { 4, 2, 3, 1 };
            var result = OrderBy.FirstEvenThenOddDescending(numbers);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
