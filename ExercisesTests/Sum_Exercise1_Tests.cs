using Exercises;
using NUnit.Framework;
using System.Collections.Generic;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class Sum_Exercise1_Tests
    {
        [Test]
        public void ForWordsLittleBrownFox_TheResultShallBe14()
        {
            var words = new List<string> { "little", "brown", "fox" };
            var result = Sum.TotalLength(words);
            var expectedResult = 14;
            Assert.AreEqual(expectedResult, result, 
                $"For INPUT {EnumerableToString(words)} the RESULT shall be " +
                $"{expectedResult} but IT WAS {result}");

        }

        [Test]
        public void ForEmptyWordsResultShallBeZero()
        {
            var words = new List<string> { };
            var result = Sum.TotalLength(words);
            var expectedResult = 0;
            Assert.AreEqual(expectedResult, result, 
                $"For EMPTY INPUT the RESULT shall be {expectedResult} " +
                $"but IT WAS {result}");
        }
    }
}
