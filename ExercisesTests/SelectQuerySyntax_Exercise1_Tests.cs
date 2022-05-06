using Exercises;
using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class SelectQuerySyntax_Exercise1_Tests
    {
        [Test]
        public void GetAbsoluteValuesInfo_ShallWorkCorrectly1()
        {
            var numbers = new[] {
                -7, -3, 2, 8
            };

            var expectedResult = new[] {
                "|-7|=7",
                "|-3|=3",
                "|2|=2",
                "|8|=8",
            };

            var result = SelectQuerySyntax.GetAbsoluteValuesInfo(numbers);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(numbers)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void GetAbsoluteValuesInfo_ShallWorkCorrectly2()
        {
            var numbers = new[] {
                4, -3, 2, 22, -95
            };

            var expectedResult = new[] {
                "|4|=4",
                "|-3|=3",
                "|2|=2",
                "|22|=22",
                "|-95|=95",
            };

            var result = SelectQuerySyntax.GetAbsoluteValuesInfo(numbers);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(numbers)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }
    }
}
