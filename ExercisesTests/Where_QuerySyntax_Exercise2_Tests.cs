using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using System.Collections.Generic;
using Student = Exercises.WhereQuerySyntax.Student;

namespace ExercisesTests
{
    [TestFixture]
    public class Where_QuerySyntax_Exercise2_Tests
    {
        [Test]
        public void GetStudentsWhoNeedToStudyMoreShallWorkCorrectly1()
        {
            var students = new List<Student>
            {
                new Student {Name = "Stacey Brown", Marks = new int[0]},
                new Student {Name = "Jake Smith", Marks = new int[] {3, 5, 5}},
                new Student {Name = "Chris Miller", Marks = new int[]{2,3}},
                new Student {Name = "Anne Evans", Marks = new int[]{3, 3, 1}},
            };

            var expectedResult = new List<Student>
            {
                new Student {Name = "Stacey Brown", Marks = new int[0]},
                new Student {Name = "Chris Miller", Marks = new int[]{2,3}},
                new Student {Name = "Anne Evans", Marks = new int[]{3, 3, 1}},
            };

            var result = WhereQuerySyntax.GetStudentsWhoNeedToStudyMore(students);

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(students)} the RESULT shall be {EnumerableToString(expectedResult)} but IT WAS '{EnumerableToString(result)}'");
        }

        [Test]
        public void GetStudentsWhoNeedToStudyMoreShallWorkCorrectly2()
        {
            var students = new List<Student>
            {
                new Student {Name = "Jake Smith", Marks = new int[] {3, 5}},
                new Student {Name = "Chris Miller", Marks = new int[]{3,3}},
            };

            var expectedResult = new List<Student>
            {
            };

            var result = WhereQuerySyntax.GetStudentsWhoNeedToStudyMore(students);

            CollectionAssert.AreEqual(expectedResult, result, $"For input {EnumerableToString(students)} the result shall be empty but it was '{EnumerableToString(result)}'");
        }
    }
}
