using Exercises;
using NUnit.Framework;
using System.Linq;

namespace ExercisesTests
{
    [TestFixture]
    public class Where_Exercise2_Tests
    {
        [Test]
        public void ShallExcludeNonNumberedWord()
        {
            var words = new[] { "1.AAA", "2.BBB", "invalidWord", "4.DDD" };
            var expectedWords = new[] { "1.AAA", "2.BBB", "4.DDD" };
            var expectedResultAsString = string.Join(", ", expectedWords);

            var wordsAsString = string.Join(", ", words);
            var result = Where.GetProperlyIndexedWords(words);
            var resultAsString = result.Any() ? string.Join(", ", result) : "empty";
            Assert.AreEqual(expectedWords, result, $"The input collection was: {wordsAsString}, the result was {resultAsString}, expectedResult is: {expectedResultAsString}");
        }

        [Test]
        public void ShallExcludeWordsAfterMissingIndex()
        {
            var words = new[] { "1.AAA", "2.BBB", "4.DDD" };
            var expectedWords = new[] { "1.AAA", "2.BBB" };
            var expectedResultAsString = string.Join(", ", expectedWords);

            var wordsAsString = string.Join(", ", words);
            var result = Where.GetProperlyIndexedWords(words);
            var resultAsString = result.Any() ? string.Join(", ", result) : "empty";
            Assert.AreEqual(expectedWords, result, $"The input collection was: {wordsAsString}, the result was {resultAsString}, expectedResult is: {expectedResultAsString}");
        }

        [Test]
        public void ShallIncludeOneWord_IfOtherInvalidOrWronglyIndexed()
        {
            var words = new[] { "0.AAA", "2.BBB", "invalidWord", "5.DDD" };
            var expectedWords = new[] { "2.BBB" };
            var expectedResultAsString = string.Join(", ", expectedWords);

            var wordsAsString = string.Join(", ", words);
            var result = Where.GetProperlyIndexedWords(words);
            var resultAsString = result.Any() ? string.Join(", ", result) : "empty";
            Assert.AreEqual(expectedWords, result, $"The input collection was: {wordsAsString}, the result was {resultAsString}, expectedResult is: {expectedResultAsString}");
        }
    }
}
