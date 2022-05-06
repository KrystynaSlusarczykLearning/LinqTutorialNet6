using NUnit.Framework;
using Exercises;

namespace ExercisesTests
{
    [TestFixture]
    public class ConcatUnion_Exercise2_Tests
    {
        [Test]
        public void FoxTest()
        {
            var input = "f_o!_!x";
            var result = ConcatUnion.CleanWord(input);
            var expectedResult = "fox_!";
            Assert.AreEqual(expectedResult, result, $"For input '{input}' the result shall be '{expectedResult}', but it was '{result}'");
        }

        [Test]
        public void DuckTest()
        {
            var input = "d_3uc(k))";
            var result = ConcatUnion.CleanWord(input);
            var expectedResult = "duck_3()";
            Assert.AreEqual(expectedResult, result, $"For input '{input}' the result shall be '{expectedResult}', but it was '{result}'");
        }

        [Test]
        public void EmptyInputTest()
        {
            var input = "";
            var result = ConcatUnion.CleanWord(input);
            var expectedResult = "";
            Assert.AreEqual(expectedResult, result, $"For an empty input the result shall be an empty string, but it was '{result}'");
        }
    }
}
