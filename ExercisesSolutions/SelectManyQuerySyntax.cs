using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class SelectManyQuerySyntax
    {
        //Coding Exercise 1
        public static IEnumerable<string> GetStudentMarksInfo(
            IEnumerable<Student> students)
        {
            return from student in students
                   where student.Marks != null
                   from mark in student.Marks
                   orderby student.Name, mark
                   select $"{student.Name}: {mark}";
        }

        //Coding Exercise 2
        public static IEnumerable<Tuple<int, int>>
            SelectAllCombinationsWithSumBelow100(
                IEnumerable<int> numbers1,
                IEnumerable<int> numbers2)
        {
            return from number1 in numbers1
                   from number2 in numbers2
                   where
                    number1 + number2 < 100
                   select new Tuple<int, int>(number1, number2);
        }

        //Refactoring challenge
        public static IEnumerable<string>
            GetDivisorsInfo_Refactored(
                IEnumerable<int> numbers)
        {
            return from number in numbers
                   from divisor in GetDivisors(number)
                   orderby number, divisor
                   select $"Number {number} is " +
                   $"divisible by {divisor}";
        }

        //do not modify this method
        public static IEnumerable<string>
            GetDivisorsInfo(
                IEnumerable<int> numbers)
        {
            var orderedNumbers = numbers.ToList();
            orderedNumbers.Sort();
            var result = new List<string>();
            foreach (var number in orderedNumbers)
            {
                var divisors = GetDivisors(number).ToList();
                divisors.Sort();
                foreach (var divisor in divisors)
                {
                    result.Add(
                        $"Number {number} is " +
                        $"divisible by {divisor}");
                }
            }
            return result;
        }

        private static IEnumerable<int> GetDivisors(int number)
        {
            return from potentialDivisor in
                       Enumerable.Range(
                           1,
                           number)
                   where number % potentialDivisor == 0
                   select potentialDivisor;
        }

        public class Student
        {
            public string Name { get; set; }
            public IEnumerable<int> Marks { get; set; }

            public override string ToString()
            {
                var marks = Marks != null ? $"({string.Join(", ", Marks)})" : "null";
                return $"{Name} with marks: {marks})";
            }
        }
    }
}
