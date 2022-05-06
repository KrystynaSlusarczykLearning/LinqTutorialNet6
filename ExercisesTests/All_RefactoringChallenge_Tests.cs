using Exercises;
using NUnit.Framework;
using System.Collections.Generic;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class All_RefactoringChallenge_Tests
    {
        [Test]
        public void WordsOfTheSameLengthEmptyList_Refactored()
        {
            var words = new List<string> { };

            Assert.True(All.AreAllWordsOfTheSameLength_Refactored(words),
                $"The test failed because the result was False, " +
                $"and for an empty input List it should be True");
        }

        [Test]
        public void WordsOfTheSameLengthEmptyList()
        {
            var words = new List<string> { };
            Assert.True(All.AreAllWordsOfTheSameLength(words),
                $"The test failed because the result was False, " +
                $"and for empty input List it should be True");
        }

        [Test]
        public void WordsOfTheSameLength_Refactored()
        {
            var words = new List<string> { "bee", "fox", "jay" };
            Assert.True(All.AreAllWordsOfTheSameLength_Refactored(words),
                $"The test failed because the result was False, " +
                $"and all those words are of the same length: {EnumerableToString(words)}");
        }

        [Test]
        public void WordsOfTheSameLength()
        {
            var words = new List<string> { "bee", "fox", "jay" };
            Assert.True(All.AreAllWordsOfTheSameLength(words),
                $"The test failed because the result was False, " +
                $"and all those words are of the same length: {EnumerableToString(words)}");
        }

        [Test]
        public void WordsOfDifferentLengths_Refactored()
        {
            var words = new List<string> { "bee", "whale", "jay" };
            Assert.False(All.AreAllWordsOfTheSameLength_Refactored(words),
                $"The test failed because the result was True, " +
                $"and those words are not of the same length: {EnumerableToString(words)}");
        }

        [Test]
        public void WordsOfDifferentLengths()
        {
            var words = new List<string> { "bee", "whale", "jay" };
            Assert.False(All.AreAllWordsOfTheSameLength(words),
                $"The test failed because the result was True, " +
                $"and those words are not of the same length: {EnumerableToString(words)}");
        }
    }
}
