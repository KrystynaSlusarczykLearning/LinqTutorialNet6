using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class ElementAt_RefactoringChallenge_Tests
    {
        [Test]
        public void IsEmptyAtIndex()
        {
            var words = new[] { "aaa", null, "bbb" };
            var result = ElementAt.IsEmptyAtIndex(words, 1);
            Assert.True(result, $"For the collection (aaa, null, bbb) the value at index 1 is null or empty");
        }

        [Test]
        public void IsEmptyAtIndex_Refactored()
        {
            var words = new[] { "aaa", null, "bbb" };
            var result = ElementAt.IsEmptyAtIndex_Refactored(words, 1);
            Assert.True(result, $"For the collection (aaa, null, bbb) the value at index 1 is null or empty");
        }

        [Test]
        public void IsNotEmptyAtIndex()
        {
            var words = new[] { "aaa", "bbb", "ccc" };
            var result = ElementAt.IsEmptyAtIndex(words, 1);
            Assert.False(result, $"For the collection (aaa, bbb, ccc) the value at index 1 is not empty");
        }

        [Test]
        public void IsNotEmptyAtIndex_Refactored()
        {
            var words = new[] { "aaa", "bbb", "ccc" };
            var result = ElementAt.IsEmptyAtIndex_Refactored(words, 1);
            Assert.False(result, $"For the collection (aaa, bbb, ccc) the value at index 1 is not empty");
        }

        [Test]
        public void InvalidIndex()
        {
            var words = new[] { "aaa", "bbb", "ccc" };
            var result = ElementAt.IsEmptyAtIndex(words, -1);
            Assert.True(result, $"For the collection (aaa, bbb, ccc) the index -1 is not valid, and in this case we want to return True");
        }

        [Test]
        public void InvalidIndex_Refactored()
        {
            var words = new[] { "aaa", "bbb", "ccc" };
            var result = ElementAt.IsEmptyAtIndex_Refactored(words, -1);
            Assert.True(result, $"For the collection (aaa, bbb, ccc) the index -1 is not valid, and in this case we want to return True");
        }
    }
}
