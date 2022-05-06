using Exercises;
using NUnit.Framework;
namespace ExercisesTests
{
    [TestFixture]
    public class FirstLast_Exercise1_Tests
    {
        [TestFixture]
        public class FirstTestSuite
        {
            public void NameIsPresent()
            {
                var words = new[] { "abc", "K", "MArtin", "John", "Jack", "bbb" };
                var result = FirstLast.FindFirstNameInTheCollection(words);
                Assert.AreEqual("John", result, $"The first name in the collection (abc, K, MArtin, John, Jack, bbb) is John");
            }

            [Test]
            public void NameIsNotPresent()
            {
                var words = new[] { "abc", "K", "bbb" };
                var result = FirstLast.FindFirstNameInTheCollection(words);
                Assert.AreEqual(null, result, $"No word in the collection (abc, K, bbb) is a valid name");
            }
        }
    }
}
