using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Person = Exercises.Join.Person;
using House = Exercises.Join.House;
using Exercises;
using System.Collections.Generic;

namespace ExercisesTests
{
    [TestFixture]
    public class Join_RefactoringChallenge_Tests
    {
        [Test]
        public void GetHousesDataShallWorkProperly1()
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
            var result = Join.GetHousesData(people, houses);
            var expectedResult = new Dictionary<House, Person>
            {
                [houses[0]] = people[1],
                [houses[1]] = people[2],
                [houses[2]] = people[2],
            };

            CollectionAssert.AreEquivalent(expectedResult, result, $"For PEOPLE {EnumerableToString(people)}, and HOUSES  {EnumerableToString(houses)}  the RESULT shall be {DictionaryToString(expectedResult)}, BUT IT WAS {DictionaryToString(result)}");
        }

        [Test]
        public void GetHousesDataShallWorkProperly2()
        {
            var people = new Person[]
            {
              new Person(1, "John Smith"),
              new Person(2, "Stephanie Green"),
              new Person(3, "Martin Brown")
            };

            var houses = new House[]
            {
              new House(2, "White Cottage"),
              new House(3, "Hilltop Mansion"),
              new House(3, "Beach Farm"),
            };
            var result = Join.GetHousesData_Refactored(people, houses);
            var expectedResult = new Dictionary<House, Person>
            {
                [houses[0]] = people[1],
                [houses[1]] = people[2],
                [houses[2]] = people[2],
            };

            CollectionAssert.AreEquivalent(expectedResult, result, $"For PEOPLE {EnumerableToString(people)}, and HOUSES  {EnumerableToString(houses)}  the RESULT shall be {DictionaryToString(expectedResult)}, BUT IT WAS {DictionaryToString(result)}");
        }
    }
}
