using Exercises;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Student = Exercises.Average.Student;

namespace ExercisesTests
{
    [TestFixture]
    public class Average_Exercise2_Tests
    {
        [Test]
        public void EmptyStudents()
        {
            var students = new List<Student>
            {

            };
            try
            {
                var result = Average.MaxAverageOfMarks(students);
                Assert.AreEqual(0, result, $"For empty collection of students, the result shall be 0");
            }
            catch (Exception ex)
            {
                Assert.Fail($"For empty collection of students, the result shall be 0. Exception message: {ex.Message}");
            }
        }

        [Test]
        public void NonEmptyStudents()
        {
            var students = new List<Student>
            {
                new Student {Marks = new List<int> {4,5,5}},
                new Student {Marks = new List<int> {5,6,5}},
                new Student {Marks = new List<int> {4,4,5}},
            };
            try
            {
                var result = Average.MaxAverageOfMarks(students);
                Assert.AreEqual(5.333, result, 0.1, $"For students with marks (4,5,5), (5,6,5), (4,4,5) max average mark is 5.33");
            }
            catch (Exception ex)
            {
                Assert.Fail($"For students with marks (4,5,5), (5,6,5), (4,4,5) max average mark is 5.33. Exception message: {ex.Message}");
            }
        }

        [Test]
        public void NonEmpty_NoMarks()
        {
            var students = new List<Student>
            {
                new Student {Marks = new List<int> {}},
            };
            try
            {
                var result = Average.MaxAverageOfMarks(students);
                Assert.AreEqual(0, result, 0.1, $"If no student has any marks, the result shall be 0.");
            }
            catch (Exception ex)
            {
                Assert.Fail($"If no student has any marks, the result shall be 0. Exception message: {ex.Message}");
            }
        }
    }
}
