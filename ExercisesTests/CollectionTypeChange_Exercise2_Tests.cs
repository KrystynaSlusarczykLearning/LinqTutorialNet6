using Exercises;
using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class CollectionTypeChange_Exercise2_Tests
    {
        [Test]
        public void ShallCreateLookupProperly()
        {
            var input = new int[] { 1, 2, 4, 5, 6, 7, 9 };

            var result = CollectionTypeChange.CreateLookupByDivisibilityBy2(input);
            var expectedResult1 = new int[] { 2, 4, 6 };
            var expectedResult2 = new int[] { 1, 5, 7, 9 };

            CollectionAssert.AreEqual(expectedResult1, result[true], 
                $"result[true] shall be {EnumerableToString(expectedResult1)} but it was" +
                $" {EnumerableToString(result[true])}");
            CollectionAssert.AreEqual(expectedResult2, result[false], 
                $"result[false] shall be {EnumerableToString(expectedResult2)} but it was" +
                $" {EnumerableToString(result[false])}");
        }
    }
}
