using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class ElementAt_Exercise1_Tests
    {
        [Test]
        public void EmptyCollection()
        {
            Assert.False(ElementAt.IsTheNumberAtIndexTheLargest(new int[0], 0), 
                $"For an empty collection, the result shall be False");
        }

        [Test]
        public void IndexPresent_NumberIsNotTheLargest()
        {
            var input = new int[] { 1, 2, 3, 4 };

            Assert.False(ElementAt.IsTheNumberAtIndexTheLargest(input, 0), 
                $"Number at index 0 (value: 1) is not the largest in the collection 1,2,3,4");
        }

        [Test]
        public void NegativeIndex()
        {
            var input = new int[] { 1, 2, 4, 4 };

            Assert.False(ElementAt.IsTheNumberAtIndexTheLargest(input, -1), 
                $"For invalid index (in this case: -1) the result shall be False");
        }

        [Test]
        public void IndexPresent_NumberIsTheLargest()
        {
            var input = new int[] { 1, 2, 3, 4 };

            Assert.True(ElementAt.IsTheNumberAtIndexTheLargest(input, 3), 
                $"Number at index 3 (value: 4) is the largest in the collection 1,2,3,4");
        }
    }
}
