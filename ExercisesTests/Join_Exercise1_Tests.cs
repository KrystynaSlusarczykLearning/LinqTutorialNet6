using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Person = Exercises.Join.Person;
using House = Exercises.Join.House;
using Exercises;

namespace ExercisesTests
{
    [TestFixture]
    public class Join_Exercise1_Tests
    {
        [Test]
        public void GetHouseOwnersDataShallWorkCorrectly()
        {
            var people = new Person[]
            {
              new Person(1, "John Smith"),
              new Person(2, "Stephanie Green"),
              new Person(3, "Martin Brown")
            };

            var houses = new House[]
            {
              new House(2, "Hilltop Mansion, 234 Maple Road"),
              new House(3, "Beach Farm, 10 Seaside Street"),
            };
            var result = Join.GetHouseOwnersData(people, houses);
            var expectedResult = new[]
            {
                "Person: (Id:1), John Smith owns no house",
                "Person: (Id:2), Stephanie Green owns Hilltop Mansion, 234 Maple Road",
                "Person: (Id:3), Martin Brown owns Beach Farm, 10 Seaside Street"
            };

            CollectionAssert.AreEquivalent(expectedResult, result, $"For PEOPLE {EnumerableToString(people)}, and HOUSES  {EnumerableToString(houses)}  the RESULT shall be {EnumerableToString(expectedResult)}, BUT IT WAS {EnumerableToString(result)}");
        }

        [Test]
        public void GetHouseOwnersDataShallWorkCorrectly_WhenOwnerHasMultipleHouses()
        {
            var people = new Person[]
            {
              new Person(1, "John Smith"),
              new Person(2, "Stephanie Green"),
              new Person(3, "Martin Brown")
            };

            var houses = new House[]
            {
              new House(2, "White Cottage, 18 Miners Overlook"),
              new House(3, "Hilltop Mansion, 234 Maple Road"),
              new House(3, "Beach Farm, 10 Seaside Street"),
            };
            var result = Join.GetHouseOwnersData(people, houses);
            var expectedResult = new[]
            {
                "Person: (Id:1), John Smith owns no house",
                "Person: (Id:2), Stephanie Green owns White Cottage, 18 Miners Overlook",
                "Person: (Id:3), Martin Brown owns Hilltop Mansion, 234 Maple Road",
                "Person: (Id:3), Martin Brown owns Beach Farm, 10 Seaside Street"
            };

            CollectionAssert.AreEquivalent(expectedResult, result, $"For PEOPLE {EnumerableToString(people)}, and HOUSES  {EnumerableToString(houses)}  the RESULT shall be {EnumerableToString(expectedResult)}, BUT IT WAS {EnumerableToString(result)}");
        }

    }
}
