using Exercises;
using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class GeneratingNewCollection_RefactoringChallenge_Tests
    {
        [Test]
        public void NonEmpty()
        {
            var result = GeneratingNewCollection.DoubleLetters(3);
            var expectedResult = new[] { "AA", "AB", "AC", "BA", "BB", "BC", "CA", "CB", "CC" };

            CollectionAssert.AreEqual(expectedResult, result, $"For 3 first letters, the result shall be {EnumerableToString(expectedResult)} but it was {EnumerableToString(result)}");
        }

        [Test]
        public void NonEmpty_Refactored()
        {
            var result = GeneratingNewCollection.DoubleLetters_Refactored(3);
            var expectedResult = new[] { "AA", "AB", "AC", "BA", "BB", "BC", "CA", "CB", "CC" };

            CollectionAssert.AreEqual(expectedResult, result, $"For 3 first letters, the result shall be {EnumerableToString(expectedResult)} but it was {EnumerableToString(result)}");
        }

        [Test]
        public void Empty()
        {
            var result = GeneratingNewCollection.DoubleLetters(0);
            var expectedResult = new string[0];

            CollectionAssert.AreEqual(expectedResult, result, $"For 0 first letters, the result shall be empty, but it was {EnumerableToString(result)}");
        }

        [Test]
        public void Empty_Refactored()
        {
            var result = GeneratingNewCollection.DoubleLetters_Refactored(0);
            var expectedResult = new string[0];

            CollectionAssert.AreEqual(expectedResult, result, $"For 0 first letters, the result shall be empty, but it was {EnumerableToString(result)}");
        }
    }
}
