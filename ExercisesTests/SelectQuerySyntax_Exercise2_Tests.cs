using Exercises;
using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using House = Exercises.SelectQuerySyntax.House;

namespace ExercisesTests
{
    [TestFixture]
    public class SelectQuerySyntax_Exercise2_Tests
    {
        [Test]
        public void GetShortAddresses_ShallWorkCorrectly1()
        {
            var houses = new[]
            {
              new House("123 Old Road"),
              new House("Pelican Town, 2 Willow Lane, Stardew Valley Borough"),
              new House("Rocky Village, 22 Hill Road, Shadow Glen Borough"),
            };

            var expectedResult = new[] {
              "123 Old Road",
              "2 Willow Lane",
              "22 Hill Road"
            };

            var result = SelectQuerySyntax.GetShortAddresses(houses);

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For INPUT {EnumerableToString(houses)} the RESULT shall be " +
                $"'{EnumerableToString(expectedResult)}' BUT IT WAS " +
                $"'{EnumerableToString(result)}'");
        }

        [Test]
        public void GetShortAddresses_ShallWorkCorrectly2()
        {
            var houses = new[]
            {
              new House("Maple Town, 123 Old Road, South Slope Borough"),
              new House("41 Beach Road"),
              new House("Oak Village, 12 Forest Alley, North Lake Borough"),
              new House("4 River Path"),
            };

            var expectedResult = new[] {
              "123 Old Road",
              "41 Beach Road",
              "12 Forest Alley",
              "4 River Path",
            };

            var result = SelectQuerySyntax.GetShortAddresses(houses);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT " +
                $"{EnumerableToString(houses)} the RESULT shall be " +
                $"'{EnumerableToString(expectedResult)}' BUT IT WAS " +
                $"'{EnumerableToString(result)}'");
        }
    }
}
