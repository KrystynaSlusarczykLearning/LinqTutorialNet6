using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class MinMax_Exercise1_Tests
    {
        [Test]
        public void ShortestWordHasLength1()
        {
            var words = new[] { "aaa", "bb", "c", "dddd" };
            var wordsAsString = string.Join(", ", words);
            var result = MinMax.LengthOfTheShortestWord(words);
            Assert.NotNull(result, $"The test failed. The shortest word in the list " +
                $"({wordsAsString}) has a length of 1, but the result was null.");
            var message = $"The test failed. The shortest word in the list " +
                $"({wordsAsString}) has a length of 1, but the result was {result}.";
            Assert.AreEqual(1, result.Value, message);
        }

        [Test]
        public void ShortestWordHasLength2()
        {
            var words = new[] { "aaa", "bb", "ccc", "dddd" };
            var wordsAsString = string.Join(", ", words);
            var result = MinMax.LengthOfTheShortestWord(words);
            Assert.NotNull(result, $"The test failed. The shortest word in the list " +
                $"({wordsAsString}) has a length of 2, but the result was null.");
            var message = $"The test failed. The shortest word in the list " +
                $"({wordsAsString}) has a length of 2, but the result was {result}.";
            Assert.AreEqual(2, result.Value, message);
        }

        [Test]
        public void EmptyCollection()
        {
            var words = new string[0];
            var result = MinMax.LengthOfTheShortestWord(words);
            var message = $"The test failed. " +
                $"The result shall be null for an empty collection";
            Assert.AreEqual(null, result, message);
        }
    }
}
