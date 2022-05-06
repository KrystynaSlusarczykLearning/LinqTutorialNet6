using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class Distinct_RefactoringChallenge_Tests
    {
        [Test]
        public void ShallGetWordsShorterThan5LettersWithoutDuplicates()
        {
            var words = new[]
            {
                "AAA", "BBB", "CCCCC", "AAA", "BBB", "CCCCC", "AAA", "CCC"
            };
            var result = Distinct.GetWordsShorterThan5Letters(words);
            var expectedResult = new[]
            {
                "AAA", "BBB", "CCC"
            };

            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({wordsAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void EmptyCollection()
        {
            var words = new string[]
            {
            };
            var result = Distinct.GetWordsShorterThan5Letters(words);
            var expectedResult = new string[]
            {
            };

            var resultAsString = result == null ? "null" : string.Join(", ", result);
            CollectionAssert.AreEqual(expectedResult, result, $"For an empty input collection the result shall be null, but it was ({resultAsString})");
        }

        [Test]
        public void ShallGetWordsShorterThan5LettersWithoutDuplicates_Refactored()
        {
            var words = new[]
            {
                "AAA", "BBB", "CCCCC", "AAA", "BBB", "CCCCC", "AAA", "CCC"
            };
            var result = Distinct.GetWordsShorterThan5Letters_Refactored(words);
            var expectedResult = new[]
            {
                "AAA", "BBB", "CCC"
            };

            var wordsAsString = string.Join(", ", words);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({wordsAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void EmptyCollection_Refactored()
        {
            var words = new string[]
            {
            };
            var result = Distinct.GetWordsShorterThan5Letters_Refactored(words);
            var expectedResult = new string[]
            {
            };

            var resultAsString = result == null ? "null" : string.Join(", ", result);
            CollectionAssert.AreEqual(expectedResult, result, $"For an empty input collection the result shall be null, but it was ({resultAsString})");
        }
    }
}
