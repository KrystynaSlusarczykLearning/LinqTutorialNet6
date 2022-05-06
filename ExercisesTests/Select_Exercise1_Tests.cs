using Exercises;
using NUnit.Framework;
using System;
using static ExercisesTests.Utilities.TestUtilities;
namespace ExercisesTests
{
    [TestFixture]
    public class Select_Exercise1_Tests
    {
        [Test]
        public void ShallGetAllNumbersAndTryParseStringsToInts()
        {
            var input = new object[] { "1", 3, "abc", new DateTime(2020, 1, 2), true, "10" };

            var result = Select.GetNumbers(input);

            var expectedResult = new int[] { 1, 3, 10 };

            CollectionAssert.AreEqual(expectedResult, result, $"For input collection " +
                $"{EnumerableToString(input)} the result shall be " +
                $"{EnumerableToString(expectedResult)} but it was " +
                $"{EnumerableToString(result)}");
        }
    }
}
