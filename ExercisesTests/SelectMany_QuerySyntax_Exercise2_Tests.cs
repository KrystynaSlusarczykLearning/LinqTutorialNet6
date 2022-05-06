using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using System;

namespace ExercisesTests
{
    [TestFixture]
    public class SelectMany_QuerySyntax_Exercise2_Tests
    {
        [Test]
        public void SelectAllCombinationsWithSumBelow100ShallWorkCorrectly1()
        {
            var numbers1 = new[]
            {
              1, 30, 42
            };

            var numbers2 = new[]
            {
              99, 82, 7
            };

            var expectedResult = new[]
            {
              new Tuple<int,int>(1,82),
              new Tuple<int,int>(1,7),
              new Tuple<int,int>(30, 7),
              new Tuple<int,int>(42, 7),
            };

            var result = SelectManyQuerySyntax.SelectAllCombinationsWithSumBelow100(numbers1, numbers2);

            CollectionAssert.AreEquivalent(expectedResult, result, $"For NUMBERS1 {EnumerableToString(numbers1)} and NUMBERS2 {EnumerableToString(numbers2)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void SelectAllCombinationsWithSumBelow100ShallWorkCorrectly2()
        {
            var numbers1 = new[]
            {
              1, 60
            };

            var numbers2 = new[]
            {
              98, 82, 7
            };

            var expectedResult = new[]
            {
              new Tuple<int,int>(1,98),
              new Tuple<int,int>(60, 7),
              new Tuple<int,int>(1, 7),
              new Tuple<int,int>(1, 82),
            };

            var result = SelectManyQuerySyntax.SelectAllCombinationsWithSumBelow100(numbers1, numbers2);

            CollectionAssert.AreEquivalent(expectedResult, result, $"For NUMBERS1 {EnumerableToString(numbers1)} and NUMBERS2 {EnumerableToString(numbers2)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }
    }
}
