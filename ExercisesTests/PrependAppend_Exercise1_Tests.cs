using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class PrependAppend_Exercise1_Tests
    {
        [Test]
        public void WithoutMarkers()
        {
            var words = new[] { "AAA", "BBB" };
            var result = PrependAppend.AddStartAndEndMarkers(words);
            var expectedResult = new[] { "START", "AAA", "BBB", "END" };

            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({wordsAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void WithBothMarkers()
        {
            var words = new[] { "START", "AAA", "BBB", "END" };
            var result = PrependAppend.AddStartAndEndMarkers(words);
            var expectedResult = new[] { "START", "AAA", "BBB", "END" };

            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({wordsAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void WithStartOnly()
        {
            var words = new[] { "START", "AAA", "BBB" };
            var result = PrependAppend.AddStartAndEndMarkers(words);
            var expectedResult = new[] { "START", "AAA", "BBB", "END" };

            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({wordsAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void WithEndOnly()
        {
            var words = new[] { "AAA", "BBB", "END" };
            var result = PrependAppend.AddStartAndEndMarkers(words);
            var expectedResult = new[] { "START", "AAA", "BBB", "END" };

            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({wordsAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void WithStartAndEndInOtherPlacesInTheCollection()
        {
            var words = new[] { "AAA", "START", "END", "BBB", "START" };
            var result = PrependAppend.AddStartAndEndMarkers(words);
            var expectedResult = new[] { "START", "AAA", "START", "END", "BBB", "START", "END" };

            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({wordsAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }
    }
}
