using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;

namespace ExercisesTests
{
    [TestFixture]
    public class Zip_RefactoringChallenge_Tests
    {
        [Test]
        public void MakeListShallWorkCorrectly1()
        {
            var words = new[] { "a", "little", "duck", "swims", "in", "a", "pond" };

            var result = Zip.MakeList(words);
            var expectedResult = new[] {
                "A) a",
                "B) little",
                "C) duck",
                "D) swims",
                "E) in",
                "F) a",
                "G) pond"
            };

            CollectionAssert.AreEqual(expectedResult, result, $"For words {EnumerableToString(words)} the result shall be {EnumerableToString(expectedResult)} but it was '{EnumerableToString(result)}'");
        }

        [Test]
        public void MakeListShallWorkCorrectly2()
        {
            var words = new[] { "duck" };

            var result = Zip.MakeList(words);
            var expectedResult = new[] {
                "A) duck"
            };

            CollectionAssert.AreEqual(expectedResult, result, $"For words {EnumerableToString(words)} the result shall be {EnumerableToString(expectedResult)} but it was '{EnumerableToString(result)}'");
        }

        [Test]
        public void MakeListShallWorkCorrectly1_Refactored()
        {
            var words = new[] { "a", "little", "duck", "swims", "in", "a", "pond" };

            var result = Zip.MakeList_Refactored(words);
            var expectedResult = new[] {
                "A) a",
                "B) little",
                "C) duck",
                "D) swims",
                "E) in",
                "F) a",
                "G) pond"
            };

            CollectionAssert.AreEqual(expectedResult, result, $"For words {EnumerableToString(words)} the result shall be {EnumerableToString(expectedResult)} but it was '{EnumerableToString(result)}'");
        }

        [Test]
        public void MakeListShallWorkCorrectly2_Refactored()
        {
            var words = new[] { "duck" };

            var result = Zip.MakeList_Refactored(words);
            var expectedResult = new[] {
                "A) duck"
            };

            CollectionAssert.AreEqual(expectedResult, result, $"For words {EnumerableToString(words)} the result shall be {EnumerableToString(expectedResult)} but it was '{EnumerableToString(result)}'");
        }
    }
}
