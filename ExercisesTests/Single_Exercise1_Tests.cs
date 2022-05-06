using NUnit.Framework;
using System;
using System.Collections.Generic;
using Single = Exercises.Single;

namespace ExercisesTests
{
    [TestFixture]
    public class Single_Exercise1_Tests
    {
        [Test]
        public void SingleUppercaseWordIsPresent()
        {
            var words = new List<string> { "aaa", "BBB", "CcC" };
            var result = Single.GetTheOnlyUpperCaseWord(words);
            Assert.AreEqual("BBB", result, $"The only upper case word in (aaa, BBB, CcC) is BBB, but the result was {result}");
        }

        [Test]
        public void NoUppercaseWordIsPresent()
        {
            var words = new List<string> { "aaa", "bbB", "CcC" };
            var result = Single.GetTheOnlyUpperCaseWord(words);
            Assert.AreEqual(null, result, $"No word in (aaa, bbB, CcC) is upper case, so the result should be null, but the result was {result}");
        }

        [Test]
        public void MoreThanOneUppercaseWordIsPresent()
        {
            var words = new List<string> { "aaa", "BBB", "CcC", "DDD" };
            Assert.Throws<InvalidOperationException>(() => Single.GetTheOnlyUpperCaseWord(words), $"There two upper case words in (aaa, BBB, CcC, DDD) so an InvalidOperationException should be thrown");
        }
    }
}
