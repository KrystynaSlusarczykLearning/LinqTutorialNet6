using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using HogwartsHouse = Exercises.JoinQuerySyntax.HogwartsHouse;
using HogwartsStudent = Exercises.JoinQuerySyntax.HogwartsStudent;

namespace ExercisesTests
{
    [TestFixture]
    public class Join_QuerySyntax_Exercise2_Tests
    {
        [Test]
        public void GetHousesAndStudentsInfoShallWorkCorrectly1()
        {
            var houses = new HogwartsHouse[]
            {
               new HogwartsHouse{Id = 1, Name = "Gryffindor"},
               new HogwartsHouse{Id = 2, Name = "Hufflepuff"},
               new HogwartsHouse{Id = 3, Name = "Ravenclaw"},
               new HogwartsHouse{Id = 4, Name = "Slytherin"},
            };

            var students = new HogwartsStudent[]
           {
               new HogwartsStudent{HouseId = 1, Name = "Harry"},
               new HogwartsStudent{HouseId = 2, Name = "Cedric"},
               new HogwartsStudent{HouseId = 3, Name = "Luna"},
               new HogwartsStudent{HouseId = 1, Name = "Ron"},
               new HogwartsStudent{HouseId = 3, Name = "Padma"},
           };

            var expectedResult = new[]
            {
              "House name: Gryffindor, student: Harry",
              "House name: Gryffindor, student: Ron",
              "House name: Hufflepuff, student: Cedric",
              "House name: Ravenclaw, student: Luna",
              "House name: Ravenclaw, student: Padma",
              "House name: Slytherin, student: no students"
            };

            var result = JoinQuerySyntax.GetHousesAndStudentsInfo(students, houses);

            CollectionAssert.AreEqual(expectedResult, result, $"For STUDENTS " +
                $"{EnumerableToString(students)} and HOUSES " +
                $"{EnumerableToString(houses)} the RESULT shall be " +
                $"'{EnumerableToString(expectedResult)}' BUT IT WAS " +
                $"'{EnumerableToString(result)}'");
        }

        [Test]
        public void GetHousesAndStudentsInfoShallWorkCorrectly2()
        {
            var houses = new HogwartsHouse[]
            {
               new HogwartsHouse{Id = 1, Name = "Gryffindor"},
               new HogwartsHouse{Id = 2, Name = "Hufflepuff"},
               new HogwartsHouse{Id = 3, Name = "Ravenclaw"},
               new HogwartsHouse{Id = 4, Name = "Slytherin"},
            };

            var students = new HogwartsStudent[]
           {
               new HogwartsStudent{HouseId = 2, Name = "Cedric"},
               new HogwartsStudent{HouseId = 3, Name = "Luna"},
               new HogwartsStudent{HouseId = 3, Name = "Padma"},
               new HogwartsStudent{HouseId = 4, Name = "Draco"},
           };

            var expectedResult = new[]
            {
              "House name: Gryffindor, student: no students",
              "House name: Hufflepuff, student: Cedric",
              "House name: Ravenclaw, student: Luna",
              "House name: Ravenclaw, student: Padma",
              "House name: Slytherin, student: Draco"
            };

            var result = JoinQuerySyntax.GetHousesAndStudentsInfo(students, houses);

            CollectionAssert.AreEqual(expectedResult, result, $"For STUDENTS {EnumerableToString(students)} and HOUSES {EnumerableToString(houses)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }
    }
}
