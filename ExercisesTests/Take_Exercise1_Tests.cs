using NUnit.Framework;
using System.Linq;
using Exercises;

namespace ExercisesTests
{
    [TestFixture]
    public class Take_Exercise1_Tests
    {
        [Test]
        public void LessThan10()
        {
            var input = Enumerable.Range(0, 5);
            var result = Take.TakeSome(input);
            var expectedResult = input.Take(3);
            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT of size {input.Count()} EXPECTED the count of the result to be {expectedResult.Count()}, but IT WAS {result.Count()}");
        }

        [Test]
        public void LessThan100LessThan30()
        {
            var input = Enumerable.Range(0, 25);
            var result = Take.TakeSome(input);
            var expectedResult = input.Take(30);
            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT of size {input.Count()} EXPECTED the count of the result to be {expectedResult.Count()}, but IT WAS {result.Count()}");
        }

        [Test]
        public void LessThan100MoreThan30()
        {
            var input = Enumerable.Range(0, 50);
            var result = Take.TakeSome(input);
            var expectedResult = input.Take(30);
            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT of size {input.Count()} EXPECTED the count of the result to be {expectedResult.Count()}, but IT WAS {result.Count()}");
        }

        [Test]
        public void Exactly99()
        {
            var input = Enumerable.Range(0, 99);
            var result = Take.TakeSome(input);
            var expectedResult = input.Take(30);
            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT of size {input.Count()} EXPECTED the count of the result to be {expectedResult.Count()}, but IT WAS {result.Count()}");
        }

        [Test]
        public void Exactly100()
        {
            var input = Enumerable.Range(0, 100);
            var result = Take.TakeSome(input);
            var expectedResult = input.Take(100);
            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT of size {input.Count()} EXPECTED the count of the result to be {expectedResult.Count()}, but IT WAS {result.Count()}");
        }

        [Test]
        public void MoreThan100()
        {
            var input = Enumerable.Range(0, 125);
            var result = Take.TakeSome(input);
            var expectedResult = input;
            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT of size {input.Count()} EXPECTED the count of the result to be {expectedResult.Count()}, but IT WAS {result.Count()}");
        }
    }
}
