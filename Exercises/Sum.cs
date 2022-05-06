using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Sum
    {
        //Coding Exercise 1
        /*
         Implement the TotalLength method, which given a collection of words will 
         calculate the sum of their lengths.
         For example, for words {"little", "brown", "fox"} the result shall be 
         14 because the lengths of those words are 6, 5, and 3, which sums up to 14.
         Assume the result is not null.
         */
        public static int TotalLength(IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
         Implement the AverageSum method, which given a nested collection of numbers 
        (so a collection of collections of numbers) will return the average sum 
        for those collections.
        For example, for the following input...
        {
            {1,2,3,2}, //sum is 8
            {1,5,6}, //sum is 12
            {2,2} //sum is 4
        }
        ...the result shall be 8 because the average sum is (8+12+4)/3 = 8.

        Assume the result is not null and non-empty.
         */
        public static double AverageSum(
            IEnumerable<IEnumerable<int>> collectionsOfNumbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static bool HasAnyStudentSumOfMarksLargerThan100_Refactored(
            IEnumerable<Student> students)
        {
            //TODO your code goes here
            throw new NotImplementedException();
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
