using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;

namespace ExercisesTests
{
    [TestFixture]
    public class SelectMany_QuerySyntax_RefactoringChallenge_Tests
    {
        [Test]
        public void SixAndOne()
        {
            var numbers = new[]
            {
               6, 1
            };

            var expectedResult = new[]
            {
              "Number 1 is divisible by 1",
              "Number 6 is divisible by 1",
              "Number 6 is divisible by 2",
              "Number 6 is divisible by 3",
              "Number 6 is divisible by 6"
            };

            var result = SelectManyQuerySyntax.GetDivisorsInfo(numbers);

            CollectionAssert.AreEqual(expectedResult, result,
                $"For INPUT {EnumerableToString(numbers)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }
        [Test]
        public void FourAndFifteen()
        {
            var numbers = new[]
            {
                4, 15
            };

            var expectedResult = new[]
            {
              "Number 4 is divisible by 1",
              "Number 4 is divisible by 2",
              "Number 4 is divisible by 4",
              "Number 15 is divisible by 1",
              "Number 15 is divisible by 3",
              "Number 15 is divisible by 5",
              "Number 15 is divisible by 15"
            };

            var result = SelectManyQuerySyntax.GetDivisorsInfo(numbers);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(numbers)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void SixAndOne_Refactored()
        {
            var numbers = new[]
            {
                6, 1
            };

            var expectedResult = new[]
            {
              "Number 1 is divisible by 1",
              "Number 6 is divisible by 1",
              "Number 6 is divisible by 2",
              "Number 6 is divisible by 3",
              "Number 6 is divisible by 6"
            };

            var result = SelectManyQuerySyntax.GetDivisorsInfo_Refactored(numbers);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(numbers)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }
        [Test]
        public void FourAndFifteen_Refactored()
        {
            var numbers = new[]
            {
                4, 15
            };

            var expectedResult = new[]
            {
              "Number 4 is divisible by 1",
              "Number 4 is divisible by 2",
              "Number 4 is divisible by 4",
              "Number 15 is divisible by 1",
              "Number 15 is divisible by 3",
              "Number 15 is divisible by 5",
              "Number 15 is divisible by 15"
            };

            var result = SelectManyQuerySyntax.GetDivisorsInfo_Refactored(numbers);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(numbers)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }
    }
}
