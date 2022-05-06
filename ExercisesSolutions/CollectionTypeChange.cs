using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class CollectionTypeChange
    {
        //Coding Exercise 1
        public static Dictionary<string, int?> ParseToNumbersAndStoreInDictionary(
            IEnumerable<string> words)
        {
            return words.Distinct().ToDictionary(
                 word => word,
                 word => {
                     int parsingResult;

                     return int.TryParse(word, out parsingResult) ?
                     parsingResult :
                     (int?)null;
                 });
        }

        //Coding Exercise 2
        public static ILookup<bool, int> CreateLookupByDivisibilityBy2(
            IEnumerable<int> input)
        {
            return input
                .ToLookup(
                number => number % 2 == 0,
                number => number);
        }

        //Refactoring challenge
        public static Dictionary<string, double>
             GetStudentsAverageMarks_Refactored(
                 IEnumerable<Student> students)
        {
            return students.ToDictionary(
                student => $"{student.FirstName} {student.LastName} born on" +
                    $" {student.DateOfBirth.ToString("d")}",
                student => student.Marks.Any() ? student.Marks.Average() : 0);
        }

        //do not modify this method
        public static Dictionary<string, double>
            GetStudentsAverageMarks(
                IEnumerable<Student> students)
        {
            var result = new Dictionary<string, double>();
            foreach (var student in students)
            {
                var studentData = $"{student.FirstName} " +
                    $"{student.LastName} born on" +
                    $" {student.DateOfBirth.ToString("d")}";

                var marksSum = 0;
                foreach (var mark in student.Marks)
                {
                    marksSum += mark;
                }
                var marksCount = student.Marks.Count();
                var averageMark = marksCount == 0 ?
                    0 :
                    marksSum / (float)marksCount;
                result[studentData] = averageMark;
            }
            return result;
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public IEnumerable<int> Marks { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}, {DateOfBirth.ToString("d")}, Marks = {string.Join(", ", Marks)}";
            }
        }
    }
}
