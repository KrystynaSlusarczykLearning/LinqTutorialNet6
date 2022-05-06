using Exercises;
using NUnit.Framework;
using System.Collections.Generic;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class SelectMany_Exercise1_Tests
    {
        [Test]
        public void ShallBuildCartesianProductCorrectly()
        {
            var numbers = new HashSet<int> { 1, 2, 5 };

            var result = SelectMany.BuildCartesianProduct(numbers);

            var expectedResult = new[]
            {
              "1,1", "1,2", "1,5", "2,1", "2,2", "2,5", "5,1", "5,2", "5,5"
            };

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For input (1,2,5) the result shall be " +
                $"{EnumerableToString(expectedResult)} but it was " +
                $"{EnumerableToString(result)}");
        }
    }
}
