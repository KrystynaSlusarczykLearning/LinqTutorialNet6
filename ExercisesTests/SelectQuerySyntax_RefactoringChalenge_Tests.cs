using Exercises;
using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Student = Exercises.SelectQuerySyntax.Student;

namespace ExercisesTests
{
    [TestFixture]
    public class SelectQuerySyntax_RefactoringChalenge_Tests
    {
        [Test]
        public void GetBestStudentInfo_ShallWorkCorrectly1()
        {
            var students = new[]
            {
              new Student {Name = "Jane Smith", Marks = new int[0]},
              new Student {Name = "John Smith", Marks = new [] {6}},
              new Student {Name = "Martin Brown", Marks = new [] {4,5}},
              new Student {Name = "Amelia Green", Marks = new [] {2, 4, 4}},
            };

            var expectedResult = "Best mark was earned by John Smith and it is 6";

            var result = SelectQuerySyntax.GetBestStudentInfo(students);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(students)} the RESULT shall be '{expectedResult}' BUT IT WAS '{result}'");
        }

        [Test]
        public void GetBestStudentInfo_ShallWorkCorrectly2()
        {
            var students = new[]
            {
              new Student {Name = "Jane Smith", Marks = new int[0]},
              new Student {Name = "John Smith", Marks = new [] {3,4,}},
              new Student {Name = "Martin Brown", Marks = new [] {4,5}},
              new Student {Name = "Amelia Green", Marks = new [] {2, 4, 4}},
            };

            var expectedResult = "Best mark was earned by Martin Brown and it is 5";

            var result = SelectQuerySyntax.GetBestStudentInfo(students);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(students)} the RESULT shall be '{expectedResult}' BUT IT WAS '{result}'");
        }

        [Test]
        public void GetBestStudentInfo_Refactored_ShallWorkCorrectly1()
        {
            var students = new[]
            {
              new Student {Name = "Jane Smith", Marks = new int[0]},
              new Student {Name = "John Smith", Marks = new [] {6}},
              new Student {Name = "Martin Brown", Marks = new [] {4,5}},
              new Student {Name = "Amelia Green", Marks = new [] {2, 4, 4}},
            };

            var expectedResult = "Best mark was earned by John Smith and it is 6";

            var result = SelectQuerySyntax.GetBestStudentInfo_Refactored(students);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT " +
                $"{EnumerableToString(students)} the RESULT shall be '{expectedResult}' " +
                $"BUT IT WAS '{result}'");
        }

        [Test]
        public void GetBestStudentInfo_Refactored_ShallWorkCorrectly2()
        {
            var students = new[]
            {
              new Student {Name = "Jane Smith", Marks = new int[0]},
              new Student {Name = "John Smith", Marks = new [] {3,4,}},
              new Student {Name = "Martin Brown", Marks = new [] {4,5}},
              new Student {Name = "Amelia Green", Marks = new [] {2, 4, 4}},
            };

            var expectedResult = "Best mark was earned by Martin Brown and it is 5";

            var result = SelectQuerySyntax.GetBestStudentInfo_Refactored(students);

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For INPUT {EnumerableToString(students)} the RESULT shall be " +
                $"'{expectedResult}' BUT IT WAS '{result}'");
        }

        [Test]
        public void EmptyStudents()
        {
            var students = new Student[]
            {
            };


            var result = SelectQuerySyntax.GetBestStudentInfo(students);

            CollectionAssert.AreEqual(null, result, $"For EMPTY INPUT the RESULT " +
                $"shall be null BUT IT WAS '{result}'");
        }

        [Test]
        public void EmptyStudents_Refactored()
        {
            var students = new Student[]
            {
            };


            var result = SelectQuerySyntax.GetBestStudentInfo_Refactored(students);

            CollectionAssert.AreEqual(null, result, $"For EMPTY INPUT the RESULT shall " +
                $"be null BUT IT WAS '{result}'");
        }
    }
}
