using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class PrependAppend_RefactoringChallenge_Tests
    {
        [Test]
        public void WithoutMarkers()
        {
            var words = new[] { "AAA", "BBB" };
            var result = PrependAppend.TrimSentenceAndChangeEndMarker(words);
            var expectedResult = new[] { "AAA", "BBB", "END" };

            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({wordsAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void WithEndMarker()
        {
            var words = new[] { "AAA", "BBB", "The end", "CCC" };
            var result = PrependAppend.TrimSentenceAndChangeEndMarker(words);
            var expectedResult = new[] { "AAA", "BBB", "END" };

            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({wordsAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void EmptyCollection()
        {
            var words = new string[] { };
            var result = PrependAppend.TrimSentenceAndChangeEndMarker(words);
            var expectedResult = new[] { "END" };

            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For an empty input collection the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void WithoutMarkers_Refactored()
        {
            var words = new[] { "AAA", "BBB" };
            var result = PrependAppend.TrimSentenceAndChangeEndMarker_Refactored(words);
            var expectedResult = new[] { "AAA", "BBB", "END" };

            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({wordsAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void WithEndMarker_Refactored()
        {
            var words = new[] { "AAA", "BBB", "The end", "CCC" };
            var result = PrependAppend.TrimSentenceAndChangeEndMarker_Refactored(words);
            var expectedResult = new[] { "AAA", "BBB", "END" };

            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({wordsAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void EmptyCollection_Refactored()
        {
            var words = new string[] { };
            var result = PrependAppend.TrimSentenceAndChangeEndMarker_Refactored(words);
            var expectedResult = new[] { "END" };

            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For an empty input collection the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }
    }
}
