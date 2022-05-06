using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;

namespace ExercisesTests
{
    [TestFixture]
    public class Where_QuerySyntax_RefactoringChallenge_Tests
    {
        [Test]
        public void FindWordsWithSubstringShallWorkCorrectly1()
        {
            var words = new[] {
                "racoon",
                "raven",
                "lion",
                "crane",
                "sardine"
            };

            var expectedResult = new[] {
                "crane",
                "racoon",
                "raven",
            };

            var result = WhereQuerySyntax.FindWordsWithSubstring("ra", words);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(words)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void FindWordsWithSubstringShallWorkCorrectly2()
        {
            var words = new[] {
                "trout",
                "heron",
                "rhinoceros",
                "duck",
                "tiger"
            };

            var expectedResult = new[] {
                "heron",
                "rhinoceros",
                "trout",
            };

            var result = WhereQuerySyntax.FindWordsWithSubstring("ro", words);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(words)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void FindWordsWithSubstringShallWorkCorrectly1_Refactored()
        {
            var words = new[] {
                "racoon",
                "raven",
                "lion",
                "crane",
                "sardine"
            };

            var expectedResult = new[] {
                "crane",
                "racoon",
                "raven",
            };

            var result = WhereQuerySyntax.FindWordsWithSubstring_Refactored("ra", words);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(words)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void FindWordsWithSubstringShallWorkCorrectly2_Refactored()
        {
            var words = new[] {
                "trout",
                "heron",
                "rhinoceros",
                "duck",
                "tiger"
            };

            var expectedResult = new[] {
                "heron",
                "rhinoceros",
                "trout",
            };

            var result = WhereQuerySyntax.FindWordsWithSubstring_Refactored("ro", words);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(words)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }
    }
}
