using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class SelectManyQuerySyntax
    {
        //Coding Exercise 1
        /*
        Using LINQ's query syntax, implement the GetStudentMarksInfo method, 
        which given a collection of students will return a collection of strings, 
        where each string contains student's name and a single mark, 
        ordered by student's name first, and then by the mark.

        For example, for the following students:
            *Jane Smith with null Marks
            *Brandon Gray with empty Marks
            *John Smith with Marks {6}
            *Martin Brown with Marks {4,5}
            *Amelia Green with Marks {2, 4, 4}
        
        ...the result shall be:
            *"Amelia Green: 2"
            *"Amelia Green: 4"
            *"Amelia Green: 4"
            *"John Smith: 6"
            *"Martin Brown: 4"
            *"Martin Brown: 5"
        
        As you can see, the students with null or empty marks should not be listed at all.
        */
        public static IEnumerable<string> GetStudentMarksInfo(
            IEnumerable<Student> students)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
         Using LINQ's query syntax, implement the SelectAllCombinationsWithSumBelow100 
        method, which given two collections of integers will select all pairs of numbers
        from the first and second collection, whose sum is less than 100.

        For example, for numbers1 {1, 60} and numbers2 {98, 82, 7}, 
        the result shall be the following collection of Tuple<int,int>:
            1, 98
            1, 82
            1, 7
            60, 7
        
        Remember, a Tuple is simply a container for two or more values 
        that can be of different types. 
        Tuple<int, int> simply holds two ints within. 
        To create a tuple holding numbers 5 and 6 you can simply call 
        "new Tuple<int,int>(5,6)".
        
        The order of the result collection does not matter.
         */
        public static IEnumerable<Tuple<int, int>>
            SelectAllCombinationsWithSumBelow100(
                IEnumerable<int> numbers1,
                IEnumerable<int> numbers2)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string>
            GetDivisorsInfo_Refactored(
                IEnumerable<int> numbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
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
