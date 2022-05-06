using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class ConcatUnion_RefactoringChallenge_Tests
    {
        [Test]
        public void GetPerfectSquaresTest()
        {
            var numbers1 = new int[] { 16, 99, 1, 3, 7, 9 };
            var numbers2 = new int[] { 16, 8, 64, 100, 25 };
            var expectedResult = new int[] { 1, 9, 16, 25, 64, 100 };

            var result = ConcatUnion.GetPerfectSquares(numbers1, numbers2);

            var numbers1AsString = string.Join(", ", numbers1);
            var numbers2AsString = string.Join(", ", numbers2);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collections ({numbers1AsString}) and ({numbers2AsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }

        [Test]
        public void GetPerfectSquaresTest_Refactored()
        {
            var numbers1 = new int[] { 16, 99, 1, 3, 7, 9 };
            var numbers2 = new int[] { 16, 8, 64, 100, 25 };
            var expectedResult = new int[] { 1, 9, 16, 25, 64, 100 };

            var result = ConcatUnion.GetPerfectSquares_Refactored(numbers1, numbers2);

            var numbers1AsString = string.Join(", ", numbers1);
            var numbers2AsString = string.Join(", ", numbers2);
            var expectedResultAsString = string.Join(", ", expectedResult);
            var resultAsString = string.Join(", ", result);

            CollectionAssert.AreEqual(expectedResult, result, $"For input collections ({numbers1AsString}) and ({numbers2AsString}) the result shall be ({expectedResultAsString}) but it is ({resultAsString})");
        }
    }
}
