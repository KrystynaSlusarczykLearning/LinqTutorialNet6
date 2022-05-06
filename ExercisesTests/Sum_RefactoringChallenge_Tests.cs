using NUnit.Framework;
using System;
using System.Collections.Generic;
using Student = Exercises.Sum.Student;
using Exercises;

namespace ExercisesTests
{
    [TestFixture]
    public class Sum_RefactoringChallenge_Tests
    {
        [Test]
        public void StudentWithSumOfMarksAbove100Exists()
        {
            var students = new List<Student>
            {
                new Student {Marks = new List<int> {40, 50}},
                new Student {Marks = new List<int> {50}},
                new Student {Marks = new List<int> {40,40,50}},
            };

            try
            {
                var result = Sum.HasAnyStudentSumOfMarksLargerThan100(students);
                Assert.True(result, $"For students with marks (40, 50), (50), (40, 40, 50) there is a student with sum of marks larger than 100 (the third student)");
            }
            catch (Exception ex)
            {
                Assert.Fail($"For students with marks (40, 50), (50), (40, 40, 50) there is a student with sum of marks larger than 100 (the third student). An Exception was thrown during the code execution. Exception message: {ex.Message}");
            }
        }

        [Test]
        public void StudentWithSumOfMarksAbove100DoesNotExist()
        {
            var students = new List<Student>
            {
                new Student {Marks = new List<int> {40, 50}},
                new Student {Marks = new List<int> {50}},
                new Student {Marks = new List<int> {40,40}},
            };

            try
            {
                var result = Sum.HasAnyStudentSumOfMarksLargerThan100(students);
                Assert.False(result, $"For students with marks (40, 50), (50), (40, 40) there is no students with sum of marks larger than 100");
            }
            catch (Exception ex)
            {
                Assert.Fail($"For students with marks (40, 50), (50), (40, 40) there is no students with sum of marks larger than 100. An Exception was thrown during the code execution. Exception message: {ex.Message}");
            }
        }

        [Test]
        public void StudentWithSumOfMarksAbove100Exists_Refactored()
        {
            var students = new List<Student>
            {
                new Student {Marks = new List<int> {40, 50}},
                new Student {Marks = new List<int> {50}},
                new Student {Marks = new List<int> {40,40,50}},
            };

            try
            {
                var result = Sum.HasAnyStudentSumOfMarksLargerThan100_Refactored(students);
                Assert.True(result, $"For students with marks (40, 50), (50), (40, 40, 50) there is a student with sum of marks larger than 100 (the third student)");
            }
            catch (Exception ex)
            {
                Assert.Fail($"For students with marks (40, 50), (50), (40, 40, 50) there is a student with sum of marks larger than 100 (the third student). An Exception was thrown during the code execution. Exception message: {ex.Message}");
            }
        }

        [Test]
        public void StudentWithSumOfMarksAbove100DoesNotExist_Refactored()
        {
            var students = new List<Student>
            {
                new Student {Marks = new List<int> {40, 50}},
                new Student {Marks = new List<int> {50}},
                new Student {Marks = new List<int> {40,40}},
            };

            try
            {
                var result = Sum.HasAnyStudentSumOfMarksLargerThan100_Refactored(students);
                Assert.False(result, $"For students with marks (40, 50), (50), (40, 40) there is no students with sum of marks larger than 100");
            }
            catch (Exception ex)
            {
                Assert.Fail($"For students with marks (40, 50), (50), (40, 40) there is no students with sum of marks larger than 100. An Exception was thrown during the code execution. Exception message: {ex.Message}");
            }
        }
    }
}
