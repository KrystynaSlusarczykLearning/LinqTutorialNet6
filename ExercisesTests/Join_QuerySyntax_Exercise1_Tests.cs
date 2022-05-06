using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using HogwartsHouse = Exercises.JoinQuerySyntax.HogwartsHouse;
using HogwartsStudent = Exercises.JoinQuerySyntax.HogwartsStudent;

namespace ExercisesTests
{
    [TestFixture]
    public class Join_QuerySyntax_Exercise1_Tests
    {
        [Test]
        public void GetStudentsInfoShallWorkCorrectly1()
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
               new HogwartsStudent{HouseId = 4, Name = "Draco"},
               new HogwartsStudent{HouseId = 2, Name = "Cedric"},
               new HogwartsStudent{HouseId = 3, Name = "Luna"},
               new HogwartsStudent{HouseId = 1, Name = "Ron"},
               new HogwartsStudent{HouseId = 3, Name = "Padma"},
           };

            var expectedResult = new[]
            {
              "Harry from house Gryffindor",
              "Ron from house Gryffindor",
              "Cedric from house Hufflepuff",
              "Luna from house Ravenclaw",
              "Padma from house Ravenclaw",
              "Draco from house Slytherin",
            };

            var result = JoinQuerySyntax.GetStudentsInfo(students, houses);

            CollectionAssert.AreEqual(expectedResult, result, $"For STUDENTS {EnumerableToString(students)} and HOUSES {EnumerableToString(houses)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void GetStudentsInfoShallWorkCorrectly2()
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
               new HogwartsStudent{HouseId = 4, Name = "Draco"},
               new HogwartsStudent{HouseId = 2, Name = "Cedric"},
               new HogwartsStudent{HouseId = 3, Name = "Luna"},
               new HogwartsStudent{HouseId = 4, Name = "Lucius"},
           };

            var expectedResult = new[]
            {
              "Harry from house Gryffindor",
              "Cedric from house Hufflepuff",
              "Luna from house Ravenclaw",
              "Draco from house Slytherin",
              "Lucius from house Slytherin",
            };

            var result = JoinQuerySyntax.GetStudentsInfo(students, houses);

            CollectionAssert.AreEqual(expectedResult, result, $"For STUDENTS {EnumerableToString(students)} and HOUSES {EnumerableToString(houses)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }
    }
}
