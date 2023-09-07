using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class OrderBy_Exercise1_Tests
    {
        [Test]
        public void ShallOrderFromLongestToShortest()
        {
            var words = new[] { "bb", "a", "ccc" };
            var result = OrderBy.OrderFromLongestToShortest(words);

            CollectionAssert.AreEqual(new[] { "ccc", "bb", "a" }, result);
            Assert.AreEqual("bb", words[0], "The order of the original collection should not be changed");
        }

        [Test]
        [TestCase(new[] { "bb", "a", "ccc" }, new[] { "ccc", "bb", "a" })]
        [TestCase(new[] { "bb", "aaaaa", "ccc" }, new[] { "aaaaa", "ccc", "bb" })]
        public void ShallOrderFromLongestToShortest_TCs(string[] words, string[] expectedResult)
        {
            var firstWord = words[0];
            var result = OrderBy.OrderFromLongestToShortest(words);

            CollectionAssert.AreEqual(expectedResult, result);
            Assert.AreEqual(firstWord, words[0], "The order of the original collection should not be changed");
        }


        [Test]
        public void ShallNotChangeAnything_IfAlreadyOrdered()
        {
            var words = new[] { "ccc", "bb", "a" };
            var result = OrderBy.OrderFromLongestToShortest(words);

            CollectionAssert.AreEqual(new[] { "ccc", "bb", "a" }, result);
            Assert.AreEqual("ccc", words[0], "The order of the original collection should not be changed");
        }
    }
}
