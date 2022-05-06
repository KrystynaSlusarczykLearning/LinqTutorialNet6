using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Sum
    {
        //Coding Exercise 1
        public static int TotalLength(IEnumerable<string> words)
        {
            return words.Sum(word => word.Length);
        }

        //Coding Exercise 2
        public static double AverageSum(
            IEnumerable<IEnumerable<int>> collectionsOfNumbers)
        {
            return collectionsOfNumbers.Average(
                singleCollection => singleCollection.Sum());
        }

        //Refactoring challenge
        public static bool HasAnyStudentSumOfMarksLargerThan100_Refactored(
            IEnumerable<Student> students)
        {
            return students.Any(student => student.Marks.Sum() > 100);
        }

        //do not modify this method
        public static bool HasAnyStudentSumOfMarksLargerThan100(
            IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                var sumOfMarks = 0;
                foreach (var mark in student.Marks)
                {
                    sumOfMarks += mark;
                }
                if (sumOfMarks > 100)
                {
                    return true;
                }
            }
            return false;
        }

        public class Student
        {
            public IEnumerable<int> Marks { get; set; }
        }
    }
}
