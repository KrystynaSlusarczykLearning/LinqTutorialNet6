using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Skip
    {
        //Coding Exercise 1
        public static double CalculateAverageMark(Student student)
        {
            return student.Marks.Count() > 2 ?
                student.Marks.OrderBy(mark => mark)
                .Skip(1)
                .SkipLast(1)
                .Average() :
                0;
        }

        //Coding Exercise 2       
        public static IEnumerable<string> GetWordsBetweenStartAndEnd(List<string> words)
        {
            var isValidCollection =
                words.Count(word => word == "START") == 1 &&
                words.Count(word => word == "END") == 1 &&
                words.IndexOf("START") < words.IndexOf("END");

            return isValidCollection ?
                words.SkipWhile(word => word != "START").Skip(1).TakeWhile(word => word != "END") :
                new string[0];
        }

        //Refactoring challenge
        public static IEnumerable<int> GetAllAfterFirstDividableBy100_Refactored(
            IEnumerable<int> numbers)
        {
            return numbers.SkipWhile(number => number % 100 != 0);
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
