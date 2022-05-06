using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace ExercisesTests
{
    [TestFixture]
    public class Average_RefactoringChallenge_Tests
    {
        [Test]
        public void NullInput_Refactored()
        {
            var result = Average.CalculateAverageHeight_Refactored(null, 0);
            Assert.AreEqual(0, result, $"For null input the result should be 0, but it was {result}");
        }

        [Test]
        public void NullInput()
        {
            var result = Average.CalculateAverageHeight(null, 0);
            Assert.AreEqual(0, result, $"For null input the result should be 0, but it was {result}");
        }

        [Test]
        public void EmptyInput_Refactored()
        {
            var result = Average.CalculateAverageHeight_Refactored(new List<float?>(), 0);
            Assert.AreEqual(0, result, $"For empty input the result should be 0, but it was {result}");
        }

        [Test]
        public void EmptyNullInput()
        {
            var result = Average.CalculateAverageHeight(new List<float?>(), 0);
            Assert.AreEqual(0, result, $"For empty input the result should be 0, but it was {result}");
        }

        [Test]
        public void DefaultShouldBeUsed_Refactored()
        {
            var result = Average.CalculateAverageHeight_Refactored(new List<float?> { null, 10 }, 0);
            Assert.AreEqual(5, result, $"For input (10, null) and default 0, the result should be 5, but it was {result}");
        }

        [Test]
        public void DefaultShouldBeUsed()
        {
            var result = Average.CalculateAverageHeight(new List<float?> { null, 10 }, 0);
            Assert.AreEqual(5, result, $"For input (10, null) and default 0, the result should be 5, but it was {result}");
        }
    }
}
