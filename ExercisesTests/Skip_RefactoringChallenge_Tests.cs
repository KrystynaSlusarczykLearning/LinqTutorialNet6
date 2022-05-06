using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class Skip_RefactoringChallenge_Tests
    {
        [Test]
        public void ShallOmitAllBeforeFirstDividableBy100()
        {
            var numbers = new[] { 1, 2, 100, 5, 6, 200, 300 };
            var result = Skip.GetAllAfterFirstDividableBy100(numbers);
            var expectedResult = new[] { 100, 5, 6, 200, 300 };

            var numbersAsString = string.Join(", ", numbers);
            var resultAsString = string.Join(", ", result);
            var expectedResultAsString = string.Join(", ", expectedResult);
            CollectionAssert.AreEqual(expectedResult, result, $"The test failed, because for numbers ({numbersAsString}) the expected result is ({expectedResultAsString}), but it was ({resultAsString})");
        }

        [Test]
        public void ShallOmitAllBeforeFirstDividableBy100_Refactored()
        {
            var numbers = new[] { 1, 2, 100, 5, 6, 200, 300 };
            var result = Skip.GetAllAfterFirstDividableBy100_Refactored(numbers);
            var expectedResult = new[] { 100, 5, 6, 200, 300 };
            var numbersAsString = string.Join(", ", numbers);
            var resultAsString = string.Join(", ", result);
            var expectedResultAsString = string.Join(", ", expectedResult);
            CollectionAssert.AreEqual(expectedResult, result, $"The test failed, because for numbers ({numbersAsString}) the expected result is ({expectedResultAsString}), but it was ({resultAsString})");
        }

        [Test]
        public void NoDividablesBy100()
        {
            var numbers = new[] { 1, 2 };
            var result = Skip.GetAllAfterFirstDividableBy100(numbers);
            var expectedResult = new int[] { };
            var numbersAsString = string.Join(", ", numbers);
            var resultAsString = string.Join(", ", result);
            CollectionAssert.AreEqual(expectedResult, result, $"The test failed, because for numbers ({numbersAsString}) the expected result is empty, but it was ({resultAsString})");
        }

        [Test]
        public void NoDividablesBy100_Refactored()
        {
            var numbers = new[] { 1, 2 };
            var result = Skip.GetAllAfterFirstDividableBy100_Refactored(numbers);
            var expectedResult = new int[] { };
            var numbersAsString = string.Join(", ", numbers);
            var resultAsString = string.Join(", ", result);
            CollectionAssert.AreEqual(expectedResult, result, $"The test failed, because for numbers ({numbersAsString}) the expected result is empty, but it was ({resultAsString})");
        }
    }
}
