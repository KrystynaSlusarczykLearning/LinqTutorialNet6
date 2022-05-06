using Exercises;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using static ExercisesTests.Utilities.TestUtilities;
using Student = Exercises.CollectionTypeChange.Student;

namespace ExercisesTests
{
    [TestFixture]
    public class CollectionTypeChange_RefactoringChallenge_Tests
    {
        [Test]
        public void ShallGetStudentsAverageMarksProperly()
        {
            var students = new List<Student>
            {
              new Student{FirstName = "John", LastName = "Smith",DateOfBirth = new DateTime(1990, 4, 5), Marks = new [] {4,4,5}},
              new Student{FirstName = "Jane", LastName = "Doe",DateOfBirth = new DateTime(1986, 5, 9), Marks = new int [] {}},
              new Student{FirstName = "Francis", LastName = "Brown",DateOfBirth = new DateTime(1991, 4, 1), Marks = new [] {4,6,5}}
            };

            var result = CollectionTypeChange.GetStudentsAverageMarks(students);
            var expectedResult = new Dictionary<string, double>
            {
                [FormatStudent(students[0])] = 4.3333f,
                [FormatStudent(students[1])] = 0f,
                [FormatStudent(students[2])] = 5f
            };

            Assert.That(result, Is.EqualTo(expectedResult).AsCollection.Within(0.1),
                $"For students {EnumerableToString(students)} the result shall be " +
                $"{DictionaryToString(expectedResult)} but it was " +
                $"{DictionaryToString(result)}");
        }

        [Test]
        public void ShallGetStudentsAverageMarksProperlyt_Refactored()
        {
            var students = new List<Student>
            {
              new Student{FirstName = "John", LastName = "Smith",DateOfBirth = new DateTime(1990, 4, 5), Marks = new [] {4,4,5}},
              new Student{FirstName = "Jane", LastName = "Doe",DateOfBirth = new DateTime(1986, 5, 9), Marks = new int [] {}},
              new Student{FirstName = "Francis", LastName = "Brown",DateOfBirth = new DateTime(1991, 4, 1), Marks = new [] {4,6,5}}
            };

            var result = CollectionTypeChange.GetStudentsAverageMarks_Refactored(students);
            var expectedResult = new Dictionary<string, double>
            {
                [FormatStudent(students[0])] = 4.3333f,
                [FormatStudent(students[1])] = 0f,
                [FormatStudent(students[2])] = 5f
            };

            Assert.That(result, Is.EqualTo(expectedResult).AsCollection.Within(0.1), $"For students {EnumerableToString(students)} the result shall be {DictionaryToString(expectedResult)} but it was {DictionaryToString(result)}");
        }


        private string FormatStudent(Student student)
        {
            return $"{student.FirstName} " +
                   $"{student.LastName} born on" +
                   $" {student.DateOfBirth.ToString("d")}";
        }
    }
}
