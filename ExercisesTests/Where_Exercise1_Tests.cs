using Exercises;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Student = Exercises.Where.Student;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class Where_Exercise1_Tests
    {
        [Test]
        public void AllStudentsHaveGrades()
        {
            var students = new List<Student>
            {
                new Student {Name = "Cathy", Marks = new List<int> {4,4,6}},
                new Student {Name = "Martin", Marks = new List<int> {5,5,5,3}},
                new Student {Name = "Bethy", Marks = new List<int> {6,5,5,3}},
            };

            var result = Where.GetScholarshipCandidates(students);

            var expectedResult = new[] { students[0], students[2] };

            CollectionAssert.AreEqual(expectedResult, result,
                $"For INPUT {EnumerableToString(students)} the RESULT shall be " +
                $"{EnumerableToString(expectedResult)} but IT WAS " +
                $"{EnumerableToString(result)}");
        }

        [Test]
        public void NotAllStudentsHaveGrades()
        {
            var students = new List<Student>
            {
                new Student {Name = "Cathy", Marks = new List<int> {4,4,6}},
                new Student {Name = "Martin", Marks = new List<int> {5,5,5,3}},
                new Student {Name = "Bethy", Marks = new List<int> {}},
            };

            var result = Where.GetScholarshipCandidates(students);

            var expectedResult = new[] { students[0] };

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For INPUT {EnumerableToString(students)} the RESULT shall be " +
                $"{EnumerableToString(expectedResult)} but IT WAS " +
                $"{EnumerableToString(result)}");
        }

        [Test]
        public void NoMatchingStudent()
        {
            var students = new List<Student>
            {
                new Student {Name = "Cathy", Marks = new List<int> {4,4,3}},
                new Student {Name = "Martin", Marks = new List<int> {5,3,5,3}},
                new Student {Name = "Bethy", Marks = new List<int> {}},
            };

            var result = Where.GetScholarshipCandidates(students);

            Assert.AreEqual(0, result.Count(), 
                $"Expected collection count 0, but was {result.Count()}. " +
                $"No student from this collection has an average mark above 4.6: " +
                $"{EnumerableToString(students)}");
        }
    }
}
