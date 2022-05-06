using Exercises;
using NUnit.Framework;
using System;

namespace ExercisesTests
{
    [TestFixture]
    public class Select_RefactoringChallenge_Tests
    {
        [Test]
        public void ShallGetTotalDurationOfSongsCorrectly()
        {
            var input = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";
            var result = Select.TotalDurationOfSongs(input);
            var expectedResult = new TimeSpan(0, 38, 23);

            Assert.AreEqual(expectedResult, result, $"For input \"{input}\" the " +
                $"result shall be {expectedResult} but it was {result}");
        }

        [Test]
        public void ShallGetTotalDurationOfSongsCorrectly_Refactored()
        {
            var input = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";
            var result = Select.TotalDurationOfSongs_Refactored(input);
            var expectedResult = new TimeSpan(0, 38, 23);

            Assert.AreEqual(expectedResult, result, $"For input \"{input}\" the " +
                $"result shall be {expectedResult} but it was {result}");
        }

        [Test]
        public void EmptyInput()
        {
            var input = "";
            var result = Select.TotalDurationOfSongs(input);
            var expectedResult = new TimeSpan();

            Assert.AreEqual(expectedResult, result, $"For an empty input the " +
                $"result shall be {expectedResult} but it was {result}");
        }

        [Test]
        public void EmptyInput_Refactored()
        {
            var input = "";
            var result = Select.TotalDurationOfSongs_Refactored(input);
            var expectedResult = new TimeSpan();

            Assert.AreEqual(expectedResult, result, $"For an empty input the " +
                $"result shall be {expectedResult} but it was {result}");
        }
    }
}
