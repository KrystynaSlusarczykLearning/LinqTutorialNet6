using Exercises;
using NUnit.Framework;
using System;

namespace ExercisesTests
{
    [TestFixture]
    public class Grouping_Exercise1_Tests
    {
        [TestCase("Bumblebee", 'b')]
        [TestCase("eebelbmuB", 'e')]
        [TestCase("toast", 't')]
        public void GetTheMostFrequentCharacterShallWorkCorrectly(string input, char? expectedResult)
        {
            var result = Grouping.GetTheMostFrequentCharacter(input);
            Assert.AreEqual(expectedResult, result, $"The most frequent character in the word '{input}' is '{expectedResult}', but the result was '{result}'");
        }

        [Test]
        public void EmptyString()
        {
            try
            {
                var result = Grouping.GetTheMostFrequentCharacter("");
                Assert.AreEqual(null, result, $"The result shall be null for an empty input, but it was '{result}'");
            }
            catch (Exception ex)
            {
                Assert.Fail($"The result shall be null for an empty input, but an expection was thrown. Exception message: {ex.Message}. (Did you possibly call the First method on an empty collection?)");
            }
        }
    }
}
