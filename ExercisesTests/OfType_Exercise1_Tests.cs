using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace ExercisesTests
{
    [TestFixture]
    public class OfType_Exercise1_Tests
    {
        [Test]
        public void IntegerIsPresent()
        {
            var input = new object[]
            {
                null,
                "hello",
                1,
                2
            };

            var result = OfType.GetTheFirstInteger(input);
            Assert.AreEqual(1, result, $"Expected result for input (null, 'hello', 1, 2) is 1, but was {result}");
        }

        [Test]
        public void IntegerNotIsPresent()
        {
            var input = new object[]
            {
                null,
                "hello",
                new List<int>()
            };

            var result = OfType.GetTheFirstInteger(input);
            Assert.AreEqual(null, result, $"Expected result for input (null, 'hello', new List<int>()) is null (because no integer is there), but was {result}");
        }
    }
}
