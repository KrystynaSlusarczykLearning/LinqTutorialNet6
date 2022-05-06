using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class CollectionTypeChange
    {
        //Coding Exercise 1
        /*
         Implement the ParseToNumbersAndStoreInDictionary method, 
        which given a collection of words will return a dictionary where each 
        of the words is the key, and the value is either an integer parsed from this 
        string or null if parsing was unsuccessful. 

        For example, for input collection {"aaa", "1", "3", "bbb", "bbb"} 
        the result shall be:       
            ["aaa"] = null,    
            ["1"] = 1,        
            ["3"] = 3,        
            ["bbb"] = null
        
        Please note that the string "bbb" occurred twice in the input collection,
        but it occurs only once in the dictionary (the dictionary keys must be unique).
         */
        public static Dictionary<string, int?> ParseToNumbersAndStoreInDictionary(
            IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
         Implement the CreateLookupByDivisibilityBy2 method, which given a collection of
        numbers will create a Lookup with the key being a boolean saying 
        if the number is divisible by 2, and the value will be all numbers 
        for whom this boolean says if they are divisible by 2.

        For example, for input {1,2,4,5,6,7,9}, the result shall be 
        a Lookup with two keys and the following values:        
            [true] = {2,4,6}        
            [false] = {1,5,7,9}
        */
        public static ILookup<bool, int> CreateLookupByDivisibilityBy2(
            IEnumerable<int> input)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static Dictionary<string, double>
             GetStudentsAverageMarks_Refactored(
                 IEnumerable<Student> students)
        {
            //TODO your code goes here
            throw new NotImplementedException();
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
