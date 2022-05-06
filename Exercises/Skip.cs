using System;
using System.Collections.Generic;

namespace Exercises
{
    public static class Skip
    {
        //Coding Exercise 1
        /*
        Let's define a Student class. A student has a collection of Marks, 
        which are numbers. Implement the CalculateAverageMark method, 
        which will calculate the average mark for a student, 
        but it will ignore the lowest and the highest mark. 
        Let's assume a student with less than 3 marks has an average mark of 0.

        For example:
            *John has the following marks: 3,4,6,6,2,5. 
                We want to ignore one highest mark (6) and one lowest mark (2). 
                That means, we want to calculate the average of 3,4,6,5, which is 4.5
        
        Assume the marks of the student are not null.
         */
        public static double CalculateAverageMark(Student student)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
        Using LINQ, implement the GetWordsBetweenStartAndEnd method which given 
        a list of words, will return all words that lay between words "START" and "END". 

        For example:
            *for words {"aaa", "START", "bbb", "ccc", "END", "ddd"} 
                the result shall be { "bbb", "ccc"}
            *for words {"aaa", "START", "END", "ddd"} the result shall be empty
            
        The result shall also be empty if any of those conditions are met:
            *"START" or "END" words are not present in this collection, 
                or they occur more than once
        "START" is placed after "END"
        
        That means, the result shall be empty for all of those collections:
            *{"aaa", "START", "bbb", "ccc",  "ddd"} - because END is not present
            *{"aaa",  "bbb", "ccc",  "ddd", "END"} - because START is not present
            *{"aaa",  "START", "ccc",  "START", "END"} - because START occurs twice
            *{"aaa",  "START", "ccc",  "END ", "END"} - because END occurs twice
            *{"aaa",  "END ", "ccc",  "START"} - because START is placed after END
         */
        public static IEnumerable<string> GetWordsBetweenStartAndEnd(List<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<int> GetAllAfterFirstDividableBy100_Refactored(
            IEnumerable<int> numbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<int> GetAllAfterFirstDividableBy100(IEnumerable<int> numbers)
        {
            var result = new List<int>();
            bool startAdding = false;
            foreach (var number in numbers)
            {
                if (!startAdding && number % 100 == 0)
                {
                    startAdding = true;
                }
                if (startAdding)
                {
                    result.Add(number);
                }
            }
            return result;
        }

        public class Student
        {
            public IEnumerable<int> Marks { get; set; }
        }
    }
}
