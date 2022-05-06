using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using HogwartsHouse = Exercises.JoinQuerySyntax.HogwartsHouse;
using HogwartsStudent = Exercises.JoinQuerySyntax.HogwartsStudent;
using HogwartsSubject = Exercises.JoinQuerySyntax.HogwartsSubject;

namespace ExercisesTests
{
    [TestFixture]
    public class Join_QuerySyntax_RefactoringChallenge_Tests
    {
        [Test]
        public void GetSubjectsOfStudentsShallWorkCorrectly1()
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
               new HogwartsStudent{HouseId = 4, Name = "Draco", SubjectsIds = new int[] {1}},
               new HogwartsStudent{HouseId = 2, Name = "Cedric", SubjectsIds = new int[] {2,3}},
               new HogwartsStudent{HouseId = 3, Name = "Luna", SubjectsIds = new int[] {1,2,3}},
           };

            var subjects = new HogwartsSubject[]
            {
               new HogwartsSubject{Id = 1, Name = "Potions"},
               new HogwartsSubject{Id = 2, Name = "Charms"},
               new HogwartsSubject{Id = 3, Name = "Herbology"},
            };

            var expectedResult = new[]
            {
              "Draco from house Slytherin studies Potions",
              "Cedric from house Hufflepuff studies Charms",
              "Cedric from house Hufflepuff studies Herbology",
              "Luna from house Ravenclaw studies Potions",
              "Luna from house Ravenclaw studies Charms",
              "Luna from house Ravenclaw studies Herbology"
            };

            var result = JoinQuerySyntax.GetSubjectsOfStudents(students, subjects, houses);

            CollectionAssert.AreEqual(expectedResult, result, $"For STUDENTS {EnumerableToString(students)} and HOUSES {EnumerableToString(houses)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void GetSubjectsOfStudentsShallWorkCorrectly2()
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
               new HogwartsStudent{HouseId = 1, Name = "Harry", SubjectsIds = new int[] {1,2}},
               new HogwartsStudent{HouseId = 2, Name = "Cedric", SubjectsIds = new int[] {2,3}},
               new HogwartsStudent{HouseId = 3, Name = "Luna", SubjectsIds = new int[] {1,3}},
           };

            var subjects = new HogwartsSubject[]
            {
               new HogwartsSubject{Id = 1, Name = "Potions"},
               new HogwartsSubject{Id = 2, Name = "Charms"},
               new HogwartsSubject{Id = 3, Name = "Herbology"},
            };

            var expectedResult = new[]
            {
              "Harry from house Gryffindor studies Potions",
              "Harry from house Gryffindor studies Charms",
              "Cedric from house Hufflepuff studies Charms",
              "Cedric from house Hufflepuff studies Herbology",
              "Luna from house Ravenclaw studies Potions",
              "Luna from house Ravenclaw studies Herbology"
            };

            var result = JoinQuerySyntax.GetSubjectsOfStudents(students, subjects, houses);

            CollectionAssert.AreEqual(expectedResult, result, $"For STUDENTS {EnumerableToString(students)} and HOUSES {EnumerableToString(houses)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void GetSubjectsOfStudentsShallWorkCorrectly1_Refactored()
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
               new HogwartsStudent{HouseId = 4, Name = "Draco", SubjectsIds = new int[] {1}},
               new HogwartsStudent{HouseId = 2, Name = "Cedric", SubjectsIds = new int[] {2,3}},
               new HogwartsStudent{HouseId = 3, Name = "Luna", SubjectsIds = new int[] {1,2,3}},
           };

            var subjects = new HogwartsSubject[]
            {
               new HogwartsSubject{Id = 1, Name = "Potions"},
               new HogwartsSubject{Id = 2, Name = "Charms"},
               new HogwartsSubject{Id = 3, Name = "Herbology"},
            };

            var expectedResult = new[]
            {
              "Draco from house Slytherin studies Potions",
              "Cedric from house Hufflepuff studies Charms",
              "Cedric from house Hufflepuff studies Herbology",
              "Luna from house Ravenclaw studies Potions",
              "Luna from house Ravenclaw studies Charms",
              "Luna from house Ravenclaw studies Herbology"
            };

            var result = JoinQuerySyntax.GetSubjectsOfStudents_Refactored(students, subjects, houses);

            CollectionAssert.AreEqual(expectedResult, result, $"For STUDENTS {EnumerableToString(students)} and HOUSES {EnumerableToString(houses)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void GetSubjectsOfStudentsShallWorkCorrectly2_Refactored()
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
               new HogwartsStudent{HouseId = 1, Name = "Harry", SubjectsIds = new int[] {1,2}},
               new HogwartsStudent{HouseId = 2, Name = "Cedric", SubjectsIds = new int[] {2,3}},
               new HogwartsStudent{HouseId = 3, Name = "Luna", SubjectsIds = new int[] {1,3}},
           };

            var subjects = new HogwartsSubject[]
            {
               new HogwartsSubject{Id = 1, Name = "Potions"},
               new HogwartsSubject{Id = 2, Name = "Charms"},
               new HogwartsSubject{Id = 3, Name = "Herbology"},
            };

            var expectedResult = new[]
            {
              "Harry from house Gryffindor studies Potions",
              "Harry from house Gryffindor studies Charms",
              "Cedric from house Hufflepuff studies Charms",
              "Cedric from house Hufflepuff studies Herbology",
              "Luna from house Ravenclaw studies Potions",
              "Luna from house Ravenclaw studies Herbology"
            };

            var result = JoinQuerySyntax.GetSubjectsOfStudents_Refactored(students, subjects, houses);

            CollectionAssert.AreEqual(expectedResult, result, $"For STUDENTS {EnumerableToString(students)} and HOUSES {EnumerableToString(houses)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }
    }
}
