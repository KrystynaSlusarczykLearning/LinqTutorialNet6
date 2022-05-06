using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;

namespace ExercisesTests
{
    [TestFixture]
    public class GroupBy_QuerySyntax_Exercise1_Tests
    {
        [Test]
        public void GroupByFirstDigitShallWorkCorrectly1()
        {
            var numbers = new[]
            {
               1, 11, 44, 4, 62, 672, 921
            };

            var expectedResult = new[]
            {
              "FirstDigit: 1, numbers: 1,11",
              "FirstDigit: 4, numbers: 44,4",
              "FirstDigit: 6, numbers: 62,672",
              "FirstDigit: 9, numbers: 921"
            };

            var result = GroupByQuerySyntax.GroupByFirstDigit(numbers);

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For INPUT {EnumerableToString(numbers)} the RESULT shall be " +
                $"'{EnumerableToString(expectedResult)}' BUT IT WAS " +
                $"'{EnumerableToString(result)}'");
        }

        [Test]
        public void GroupByFirstDigitShallWorkCorrectly2()
        {
            var numbers = new[]
            {
               9, 91, 9713, 994
            };

            var expectedResult = new[]
            {
              "FirstDigit: 9, numbers: 9,91,9713,994",
            };

            var result = GroupByQuerySyntax.GroupByFirstDigit(numbers);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT " +
                $"{EnumerableToString(numbers)} the RESULT shall be " +
                $"'{EnumerableToString(expectedResult)}' BUT IT WAS " +
                $"'{EnumerableToString(result)}'");
        }

    }
}
