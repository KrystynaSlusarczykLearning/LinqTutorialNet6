using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using Student = Exercises.SelectManyQuerySyntax.Student;

namespace ExercisesTests
{
    [TestFixture]
    public class SelectMany_QuerySyntax_Exercise1_Tests
    {
        [Test]
        public void GetStudentMarksInfoShallWorkCorrectly1()
        {
            var students = new[]
            {
              new Student {Name = "Jane Smith", Marks = new int[0]},
              new Student {Name = "John Smith", Marks = new [] {6}},
              new Student {Name = "Martin Brown", Marks = new [] {4,5}},
              new Student {Name = "Amelia Green", Marks = new [] {2, 4, 4}},
            };

            var expectedResult = new[]
            {
              "Amelia Green: 2",
              "Amelia Green: 4",
              "Amelia Green: 4",
              "John Smith: 6",
              "Martin Brown: 4",
              "Martin Brown: 5",
            };

            var result = SelectManyQuerySyntax.GetStudentMarksInfo(students);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(students)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void GetStudentMarksInfoShallWorkCorrectly2()
        {
            var students = new[]
            {
              new Student {Name = "Jane Smith", Marks = new [] {4,5}},
              new Student {Name = "John Smith", Marks = new [] {6, 2}},
              new Student {Name = "Martin Brown", Marks = null},
              new Student {Name = "Amelia Green", Marks = new [] {2}},
            };

            var expectedResult = new[]
            {
              "Amelia Green: 2",
              "Jane Smith: 4",
              "Jane Smith: 5",
              "John Smith: 2",
              "John Smith: 6",
            };

            var result = SelectManyQuerySyntax.GetStudentMarksInfo(students);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(students)} the RESULT shall be '{EnumerableToString(expectedResult)}' BUT IT WAS '{EnumerableToString(result)}'");
        }
    }
}
