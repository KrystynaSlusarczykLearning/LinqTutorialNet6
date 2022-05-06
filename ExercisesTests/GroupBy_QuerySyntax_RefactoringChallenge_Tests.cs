using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using House = Exercises.GroupByQuerySyntax.House;

namespace ExercisesTests
{
    [TestFixture]
    public class GroupBy_QuerySyntax_RefactoringChallenge_Tests
    {
        [Test]
        public void TwoOwnersWithMultipleHouses()
        {
            var input = new House[]
            {
               new House(1, "Sea Cottage"),
               new House(1, "Mountain Lodge"),
               new House(2, "Old Cabin"),
               new House(3, "Valley Mansion"),
               new House(3, "Beach Villa")
            };

            var expectedResult = new[]
            {
              "Owner with ID 1 owns houses: Sea Cottage, Mountain Lodge",
              "Owner with ID 3 owns houses: Valley Mansion, Beach Villa"
            };

            var result = GroupByQuerySyntax.GetOwnersWithMultipleHouses(input);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(input)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void OneOwnerWithMultipleHouses()
        {
            var input = new House[]
            {
               new House(1, "Sea Cottage"),
               new House(1, "Mountain Lodge"),
               new House(1, "Old Cabin"),
               new House(3, "Valley Mansion"),
               new House(4, "Beach Villa")
            };

            var expectedResult = new[]
            {
              "Owner with ID 1 owns houses: Sea Cottage, Mountain Lodge, Old Cabin"
            };

            var result = GroupByQuerySyntax.GetOwnersWithMultipleHouses(input);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(input)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void TwoOwnersWithMultipleHouses_Refactored()
        {
            var input = new House[]
            {
               new House(1, "Sea Cottage"),
               new House(1, "Mountain Lodge"),
               new House(2, "Old Cabin"),
               new House(3, "Valley Mansion"),
               new House(3, "Beach Villa")
            };

            var expectedResult = new[]
            {
              "Owner with ID 1 owns houses: Sea Cottage, Mountain Lodge",
              "Owner with ID 3 owns houses: Valley Mansion, Beach Villa"
            };

            var result = GroupByQuerySyntax.GetOwnersWithMultipleHouses_Refactored(input);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(input)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void OneOwnerWithMultipleHouses_Refactored()
        {
            var input = new House[]
            {
               new House(1, "Sea Cottage"),
               new House(1, "Mountain Lodge"),
               new House(1, "Old Cabin"),
               new House(3, "Valley Mansion"),
               new House(4, "Beach Villa")
            };

            var expectedResult = new[]
            {
              "Owner with ID 1 owns houses: Sea Cottage, Mountain Lodge, Old Cabin"
            };

            var result = GroupByQuerySyntax.GetOwnersWithMultipleHouses_Refactored(input);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(input)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

    }
}
