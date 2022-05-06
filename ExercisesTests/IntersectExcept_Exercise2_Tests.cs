using Exercises;
using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class IntersectExcept_Exercise2_Tests
    {
        [Test]
        public void SomeNumbersAreExclusive()
        {
            var numbers1 = new[] { 1, 2, 3, 4, 5, 6 };
            var numbers2 = new[] { 9, 8, 7, 6, 5 };
            var expectedResult = new int[] { 1, 2, 3, 4, 7, 8, 9 };
            var result = IntersectExcept.GetExclusiveNumbers(numbers1, numbers2);

            Assert.AreEqual(expectedResult, result, $"For numbers1 {EnumerableToString(numbers1)} and numbers2 {EnumerableToString(numbers2)} the result shall be {EnumerableToString(expectedResult)}, but it was {EnumerableToString(result)}");
        }

        [Test]
        public void AllNumbersAreExclusive()
        {
            var numbers1 = new[] { 40, 20 };
            var numbers2 = new[] { 30, 10 };
            var expectedResult = new int[] { 10, 20, 30, 40 };
            var result = IntersectExcept.GetExclusiveNumbers(numbers1, numbers2);

            Assert.AreEqual(expectedResult, result, $"For numbers1 {EnumerableToString(numbers1)} and numbers2 {EnumerableToString(numbers2)} the result shall be {EnumerableToString(expectedResult)}, but it was {EnumerableToString(result)}");
        }

        [Test]
        public void EmptyCollections()
        {
            var numbers1 = new int[0];
            var numbers2 = new int[0];
            var expectedResult = new int[0];
            var result = IntersectExcept.GetExclusiveNumbers(numbers1, numbers2);

            Assert.AreEqual(expectedResult, result, $"For empty input collections the result shall be empty, but it was {EnumerableToString(result)}");
        }
    }
}
