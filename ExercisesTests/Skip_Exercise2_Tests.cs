using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace ExercisesTests
{
    [TestFixture]
    public class Skip_Exercise2_Tests
    {
        [Test]
        public void ValidCollection()
        {
            var words = new List<string> { "aaa", "START", "bbb", "ccc", "END", "ddd" };
            var expectedResult = new[] { "bbb", "ccc" };
            var result = Skip.GetWordsBetweenStartAndEnd(words);
            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);
            CollectionAssert.AreEqual(expectedResult, result, $"For words ({wordsAsString}), expected result is ({expectedResultAsString}), but the result is {resultAsString}");
        }

        [Test]
        public void ValidCollectionButNothingBetween()
        {
            var words = new List<string> { "aaa", "START", "END", "ddd" };
            var expectedResult = new string[] { };
            var result = Skip.GetWordsBetweenStartAndEnd(words);
            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);
            CollectionAssert.AreEqual(expectedResult, result, $"For words ({wordsAsString}), expected result is ({expectedResultAsString}), but the result is {resultAsString}");
        }

        [Test]
        public void NoEnd()
        {
            var words = new List<string> { "aaa", "START", "bbb", "ccc", "ddd" };
            var expectedResult = new string[] { };
            var result = Skip.GetWordsBetweenStartAndEnd(words);
            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);
            CollectionAssert.AreEqual(expectedResult, result, $"For words ({wordsAsString}), expected result is should be empty (because there is no END word in the collection), but the result is {resultAsString}");
        }

        [Test]
        public void NoStart()
        {
            var words = new List<string> { "aaa", "bbb", "ccc", "ddd", "END" };
            var expectedResult = new string[] { };
            var result = Skip.GetWordsBetweenStartAndEnd(words);
            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);
            CollectionAssert.AreEqual(expectedResult, result, $"For words ({wordsAsString}), expected result is should be empty (because there is no START word in the collection), but the result is {resultAsString}");
        }

        [Test]
        public void StartAfterEnd()
        {
            var words = new List<string> { "aaa", "END", "bbb", "ccc", "START", "ddd" };
            var expectedResult = new string[] { };
            var result = Skip.GetWordsBetweenStartAndEnd(words);
            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);
            CollectionAssert.AreEqual(expectedResult, result, $"For words ({wordsAsString}), expected result is should be empty (because START is after the END), but the result is {resultAsString}");
        }

        [Test]
        public void TwoStarts()
        {
            var words = new List<string> { "aaa", "START", "bbb", "ccc", "START", "ddd", "END" };
            var expectedResult = new string[] { };
            var result = Skip.GetWordsBetweenStartAndEnd(words);
            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);
            CollectionAssert.AreEqual(expectedResult, result, $"For words ({wordsAsString}), expected result is should be empty (because there are multiple START words), but the result is {resultAsString}");
        }

        [Test]
        public void TwoEnds()
        {
            var words = new List<string> { "aaa", "START", "bbb", "ccc", "END", "ddd", "END" };
            var expectedResult = new string[] { };
            var result = Skip.GetWordsBetweenStartAndEnd(words);
            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);
            CollectionAssert.AreEqual(expectedResult, result, $"For words ({wordsAsString}), expected result is should be empty (because there are multiple END words), but the result is {resultAsString}");
        }
    }
}
