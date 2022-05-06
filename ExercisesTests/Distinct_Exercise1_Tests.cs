using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class Distinct_Exercise1_Tests
    {
        [Test]
        public void AllAreUniqe()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            var result = Distinct.AreAllUnique(input);
            Assert.True(result, $"All elements of (1,2,3,4,5) are unique," +
                $" but the result was False");
        }

        [Test]
        public void NotAllAreUniqe()
        {
            var input = new int[] { 1, 2, 3, 4, 4, 5 };
            var result = Distinct.AreAllUnique(input);
            Assert.False(result, $"Not all elements of (1,2,3,4,4,5) are unique" +
                $" (4 is duplicated), but the result was True");
        }
    }
}
