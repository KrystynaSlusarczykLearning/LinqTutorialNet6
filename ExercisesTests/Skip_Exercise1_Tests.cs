using Exercises;
using NUnit.Framework;
using Student = Exercises.Skip.Student;

namespace ExercisesTests
{
    [TestFixture]
    public class Skip_Exercise1_Tests
    {
        [Test]
        public void CalculateAverageMark()
        {
            var student = new Student
            {
                Marks = new int[] { 3, 4, 6, 6, 2, 5 }
            };
            var result = Skip.CalculateAverageMark(student);
            Assert.AreEqual(4.5, result, $"For student with marks 3,4,6,6,2,5 result shall be 4.5");
        }

        [Test]
        public void CalculateAverageMark_EmptyMarks()
        {
            var student = new Student
            {
                Marks = new int[] { }
            };
            var result = Skip.CalculateAverageMark(student);
            Assert.AreEqual(0, result, $"For student with no marks result shall be 0");
        }

        [Test]
        public void CalculateAverageMark_LessThan3Marks()
        {
            var student = new Student
            {
                Marks = new int[] { 2, 5 }
            };
            var result = Skip.CalculateAverageMark(student);
            Assert.AreEqual(0, result, $"For student with less than 3 marks result shall be 0");
        }
    }
}
