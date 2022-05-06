using Exercises;
using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class IntersectExcept_Exercise1_Tests
    {
        [Test]
        public void TwoCommonWords()
        {
            var words1 = new[] { "aaa", "BBB", "CCC" };
            var words2 = new[] { "aaa", "ccc", "DDD" };
            var expectedResult = 2;
            var result = IntersectExcept.CountCommonWords(words1, words2);

            Assert.AreEqual(expectedResult, result, $"For words1 {EnumerableToString(words1)} and words2 {EnumerableToString(words2)} the result shall be {expectedResult}, but it was {result}");
        }

        [Test]
        public void ThreeCommonWords()
        {
            var words1 = new[] { "aaa", "BBB", "CCC", "FFF" };
            var words2 = new[] { "aaa", "ccc", "DDD", "eee", "fFf", };
            var expectedResult = 3;
            var result = IntersectExcept.CountCommonWords(words1, words2);

            Assert.AreEqual(expectedResult, result, $"For words1 {EnumerableToString(words1)} and words2 {EnumerableToString(words2)} the result shall be {expectedResult}, but it was {result}");
        }

        [Test]
        public void EmptyCollections()
        {
            var words1 = new string[0];
            var words2 = new string[0];
            var expectedResult = 0;
            var result = IntersectExcept.CountCommonWords(words1, words2);

            Assert.AreEqual(expectedResult, result, $"For empty input collections the result shall be {expectedResult}, but it was {result}");
        }
    }
}
