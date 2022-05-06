using Exercises;
using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Student = Exercises.SelectMany.Student;

namespace ExercisesTests
{
    [TestFixture]
    public class SelectMany_Exercise2_Tests
    {
        [Test]
        public void ShallBuildBestMarksAndStudentsCorrectly()
        {
            var students = new[]
            {
                new Student {Name = "Lucy", Marks = new [] {3,6,2,6}},
                new Student {Name = "Tom", Marks = new [] {4,5}},
                new Student {Name = "Alice", Marks = new [] {3,3,5}},
                new Student {Name = "Brian", Marks = new [] {2,3,3}},
            };
            var result = SelectMany.BestMarksAndStudents(students);
            var expectedResult = new[] {
                "Lucy: 6",
                "Lucy: 6",
                "Alice: 5",
                "Tom: 5",
                "Tom: 4"
            };

            CollectionAssert.AreEqual(expectedResult, result, $"For students {EnumerableToString(students)} the result shall be {EnumerableToString(expectedResult)} but it was {EnumerableToString(result)}");
        }
    }
}
