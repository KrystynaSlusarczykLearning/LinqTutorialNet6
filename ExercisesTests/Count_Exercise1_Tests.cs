using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class Count_Exercise1_Tests
    {
        [Test]
        public void Exactly10Letters()
        {
            var words = new[] { "aaaaabbbbb", "abc" };
            var wordsAsString = string.Join(", ", words);
            var result = Count.CountAllLongWords(words);
            Assert.AreEqual(result, 0, $"Test failed, because there are 0 words " +
                $"longer than 10 letters in the {wordsAsString} collection " +
                $"(aaaaabbbbb is exactly 10 letters long)");
        }

        [Test]
        public void OneWordLongerThan10Letters()
        {
            var words = new[] { "aaaaabbbbbc", "abc" };
            var wordsAsString = string.Join(", ", words);
            var result = Count.CountAllLongWords(words);
            Assert.AreEqual(result, 1, $"Test failed, because there is 1 word " +
                $"longer than 10 letters in the {wordsAsString} collection " +
                $"(aaaaabbbbbc is exactly 11 letters long)");
        }

        [Test]
        public void TwoWordsLongerThan10Letters()
        {
            var words = new[] { "aaaaabbbbbc", "aaaaabbbbbccccc", "abc" };
            var wordsAsString = string.Join(", ", words);
            var result = Count.CountAllLongWords(words);
            Assert.AreEqual(result, 2, $"Test failed, because there are 2 " +
                $"words longer than 10 letters in the {wordsAsString} collection");
        }
    }
}
