using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using System;

namespace ExercisesTests
{
    [TestFixture]
    public class Aggregate_RefactoringChallenge_Tests
    {
        [Test]
        public void NIs5()
        {
            var input = 5;
            var result = Aggregate.Fibonacci(input);
            var expectedResult = new[] { 0, 1, 1, 2, 3 };
            Assert.AreEqual(expectedResult, result, $"For N='{input}' the Fibonacci sequence shall be '{EnumerableToString(expectedResult)}' but it was '{EnumerableToString(result)}'");
        }

        [Test]
        public void NIs10()
        {
            var input = 10;
            var result = Aggregate.Fibonacci(input);
            var expectedResult = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            Assert.AreEqual(expectedResult, result, $"For N='{input}' the Fibonacci sequence shall be '{EnumerableToString(expectedResult)}' but it was '{EnumerableToString(result)}'");
        }

        [Test]
        public void NIs1()
        {
            var input = 1;
            var result = Aggregate.Fibonacci(input);
            var expectedResult = new[] { 0 };
            Assert.AreEqual(expectedResult, result, $"For N='{input}' the Fibonacci sequence shall be '{EnumerableToString(expectedResult)}' but it was '{EnumerableToString(result)}'");
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void InvalidN(int input)
        {
            Assert.Throws<ArgumentException>(() => Aggregate.Fibonacci(input), $"For N='{input}' the ArgumentException shall be thrown");
        }

        [Test]
        public void NIs5_Refactored()
        {
            var input = 5;
            var result = Aggregate.Fibonacci_Refactored(input);
            var expectedResult = new[] { 0, 1, 1, 2, 3 };
            Assert.AreEqual(expectedResult, result, $"For N='{input}' the Fibonacci sequence shall be '{EnumerableToString(expectedResult)}' but it was '{EnumerableToString(result)}'");
        }

        [Test]
        public void NIs10_Refactored()
        {
            var input = 10;
            var result = Aggregate.Fibonacci_Refactored(input);
            var expectedResult = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            Assert.AreEqual(expectedResult, result, $"For N='{input}' the Fibonacci sequence shall be '{EnumerableToString(expectedResult)}' but it was '{EnumerableToString(result)}'");
        }

        [Test]
        public void NIs1_Refactored()
        {
            var input = 1;
            var result = Aggregate.Fibonacci_Refactored(input);
            var expectedResult = new[] { 0 };
            Assert.AreEqual(expectedResult, result, $"For N='{input}' the Fibonacci sequence shall be '{EnumerableToString(expectedResult)}' but it was '{EnumerableToString(result)}'");
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void InvalidN_Refactored(int input)
        {
            Assert.Throws<ArgumentException>(() => Aggregate.Fibonacci_Refactored(input), $"For N='{input}' the ArgumentException shall be thrown");
        }
    }
}
