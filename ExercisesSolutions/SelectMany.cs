using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class SelectMany
    {
        //Coding Exercise 1
        public static IEnumerable<string> BuildCartesianProduct(
            HashSet<int> numbers)
        {
            return numbers.SelectMany(
                number1 => numbers, (number1, number2) =>
                $"{number1},{number2}");
        }

        //Coding Exercise 2
        public static IEnumerable<string> BestMarksAndStudents(
            IEnumerable<Student> students)
        {
            return students.SelectMany(student => student.Marks,
                (student, mark) => new { Student = student, Mark = mark })
                .OrderByDescending(studentMarkPair => studentMarkPair.Mark)
                .ThenBy(studentMarkPair => studentMarkPair.Student.Name)
                .Take(5)
                .Select(studentMarkPair => 
                    $"{studentMarkPair.Student.Name}: {studentMarkPair.Mark}");
        }

        //Refactoring challenge
        public static Dictionary<string, double> SegmentsLengths_Refactored(
            IEnumerable<Point> starts, IEnumerable<Point> ends)
        {
            return starts.SelectMany(
                start => ends, (start, end) =>
                new {
                    Start = start,
                    End = end,
                    Length = SegmentLength(start, end)
                })
                .ToDictionary(
                    segmentData =>
                        $"Start: ({segmentData.Start})," +
                        $" End: ({segmentData.End})",
                    segmentData => segmentData.Length);
        }

        //do not modify this method
        public static Dictionary<string, double> SegmentsLengths(
            IEnumerable<Point> starts, IEnumerable<Point> ends)
        {
            var result = new Dictionary<string, double>();
            foreach (var startPoint in starts)
            {
                foreach (var endPoint in ends)
                {
                    var length = SegmentLength(startPoint, endPoint);
                    var key = $"Start: ({startPoint}), End: ({endPoint})";
                    result[key] = length;
                }
            }
            return result;
        }

        public static double SegmentLength(Point start, Point end)
        {
            return Math.Sqrt((Math.Pow(start.X - end.X, 2) + Math.Pow(start.Y - end.Y, 2)));
        }

        public class Student
        {
            public string Name { get; set; }
            public IEnumerable<int> Marks { get; set; }

            public override string ToString()
            {
                return $"{Name} with marks ({string.Join(",", Marks)})";
            }
        }

        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public override string ToString()
            {
                return $"X: {X}, Y: {Y}";
            }
        }
    }
}
