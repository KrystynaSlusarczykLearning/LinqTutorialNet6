using NUnit.Framework;
using Contains = Exercises.Contains;

namespace ExercisesTests
{
    [TestFixture]
    public class Contains_RefactoringChallenge_Tests
    {
        [Test]
        public void ContainsBannedWords()
        {
            var bannedWords = new[] { "lollipop", "octopus", "badger" };
            var words = new[] { "hello", "octopus" };
            var wordsAsString = string.Join(", ", words);
            var bannedWordsAsString = string.Join(", ", bannedWords);
            var result = Contains.ContainsBannedWords(words, bannedWords);
            Assert.True(result, $"The test failed because the method result was False, yet words \"{wordsAsString}\" contain one or more of the banned words ({bannedWordsAsString})");
        }

        [Test]
        public void ContainsBannedWords_Refactored()
        {
            var bannedWords = new[] { "lollipop", "octopus", "badger" };
            var words = new[] { "hello", "octopus" };
            var wordsAsString = string.Join(", ", words);
            var bannedWordsAsString = string.Join(", ", bannedWords);
            var result = Contains.ContainsBannedWords_Refactored(words, bannedWords);
            Assert.True(result, $"The test failed because the method result was False, yet words \"{wordsAsString}\" contain one or more of the banned words ({bannedWordsAsString})");
        }

        [Test]
        public void DoNotContainBannedWords()
        {
            var bannedWords = new[] { "lollipop", "octopus", "badger" };
            var words = new[] { "hello", "there" };
            var wordsAsString = string.Join(", ", words);
            var bannedWordsAsString = string.Join(", ", bannedWords);
            var result = Contains.ContainsBannedWords(words, bannedWords);
            Assert.False(result, $"The test failed because the method result was True, yet words \"{wordsAsString}\" do not contain any of the banned words ({bannedWordsAsString})");
        }

        [Test]
        public void DoNotContainBannedWords_Refactored()
        {
            var bannedWords = new[] { "lollipop", "octopus", "badger" };
            var words = new[] { "hello", "there" };
            var wordsAsString = string.Join(", ", words);
            var bannedWordsAsString = string.Join(", ", bannedWords);
            var result = Contains.ContainsBannedWords_Refactored(words, bannedWords);
            Assert.False(result, $"The test failed because the method result was True, yet words \"{wordsAsString}\" do not contain any of the banned words ({bannedWordsAsString})");
        }
    }
}
