using NUnit.Framework;
using Exercises;
using System;

namespace ExercisesTests
{
    [TestFixture]
    public class Aggregate_Exercise2_Tests
    {
        [Test]
        public void FiveCount()
        {
            var result = Aggregate.PrintAlphabet(5);
            var expectedResult = "a,b,c,d,e";
            Assert.AreEqual(expectedResult, result, $"For count 5 the result shall be '{expectedResult}' but it was '{result}'");
        }

        [Test]
        public void OneCount()
        {
            var result = Aggregate.PrintAlphabet(1);
            var expectedResult = "a";
            Assert.AreEqual(expectedResult, result, $"For count ` the result shall be '{expectedResult}' but it was '{result}'");
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(27)]
        public void InvalidCount(int count)
        {
            Assert.Throws<ArgumentException>(() => Aggregate.PrintAlphabet(count), $"For count {count} ArgumentException should be thrown");
        }
    }
}
