using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class OfType_Exercise2_Tests
    {
        [Test]
        public void AllStringAreUpperCase()
        {
            var input = new object[]
            {
                null,
                "HELLO",
                1,
                "THERE"
            };

            var result = OfType.AreAllStringsUpperCase(input);
            Assert.True(result, $"Expected result for input (null, 'HELLO', 1, 'THERE') is true, but was {result}");
        }

        [Test]
        public void NotAllStringAreUpperCase()
        {
            var input = new object[]
            {
                null,
                "HELLO",
                1,
                "there"
            };

            var result = OfType.AreAllStringsUpperCase(input);
            Assert.False(result, $"Expected result for input (null, 'HELLO', 1, 'there') is false, but was {result}");
        }

        [Test]
        public void NoStrings()
        {
            var input = new object[]
            {
                null,
                1
            };

            var result = OfType.AreAllStringsUpperCase(input);
            Assert.True(result, $"Expected result for input (null, 1) is true, but was {result}. If there is no string at all in this collection, the result should be true.");
        }
    }
}
