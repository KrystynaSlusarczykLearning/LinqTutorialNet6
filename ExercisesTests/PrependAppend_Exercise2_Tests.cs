using Exercises;
using NUnit.Framework;
using System;

namespace ExercisesTests
{
    [TestFixture]
    public class PrependAppend_Exercise2_Tests
    {
        [Test]
        public void DuplicatesAtBothStartAndEnd()
        {
            var numbers = new[] { 2, 2, 2, 5, 6, 6, 6, 7, 7, 7 };
            var result = PrependAppend.RemoveDuplicatesFromStartAndEnd(numbers);
            var expectedResult = new[] { 2, 5, 6, 6, 6, 7 };

            var numbersAsString = string.Join(", ", numbers);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({numbersAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void DuplicatesAtEnd()
        {
            var numbers = new[] { 2, 5, 6, 6, 6, 7, 7, 7 };
            var result = PrependAppend.RemoveDuplicatesFromStartAndEnd(numbers);
            var expectedResult = new[] { 2, 5, 6, 6, 6, 7 };

            var numbersAsString = string.Join(", ", numbers);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({numbersAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void AllAreTheSame()
        {
            var numbers = new[] { 2, 2, 2, 2 };
            var result = PrependAppend.RemoveDuplicatesFromStartAndEnd(numbers);
            var expectedResult = new[] { 2 };

            var numbersAsString = string.Join(", ", numbers);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({numbersAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void EmptyInput()
        {
            try
            {
                var numbers = new int[] { };
                var result = PrependAppend.RemoveDuplicatesFromStartAndEnd(numbers);
                var expectedResult = new int[] { };

                var numbersAsString = string.Join(", ", numbers);
                var expectedResultAsString = string.Join(", ", expectedResult);
                var resultAsString = string.Join(", ", result);

                CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({numbersAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
            }
            catch (InvalidOperationException ex)
            {
                Assert.Fail($"For empty collection the result shall be empty collection, but an exception was thrown. Exception message: {ex.Message}");
            }
        }

        [Test]
        public void OneElementInput()
        {
            try
            {
                var numbers = new int[] { 1 };
                var result = PrependAppend.RemoveDuplicatesFromStartAndEnd(numbers);
                var expectedResult = new int[] { 1 };

                var numbersAsString = string.Join(", ", numbers);
                var expectedResultAsString = string.Join(", ", expectedResult);
                var resultAsString = string.Join(", ", result);

                CollectionAssert.AreEqual(expectedResult, result, $"For input collection ({numbersAsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");

            }
            catch (InvalidOperationException ex)
            {
                Assert.Fail($"For a single-element collection the result shall be the input collection, but an exception was thrown. Exception message: {ex.Message}");
            }
        }
    }
}
