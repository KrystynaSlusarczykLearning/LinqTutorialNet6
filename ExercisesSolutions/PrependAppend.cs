using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class PrependAppend
    {
        //Coding Exercise 1
        public static IEnumerable<string> AddStartAndEndMarkers(IEnumerable<string> words)
        {
            const string Start = "START";
            const string End = "END";

            var withStart = words.First() == Start ?
                                         words :
                                         words.Prepend(Start);

            return withStart.Last() == End ?
                    withStart :
                    withStart.Append(End);
        }

        //Coding Exercise 2
        public static IEnumerable<int> RemoveDuplicatesFromStartAndEnd(
            IEnumerable<int> numbers)
        {
            if (numbers.Count() < 2)
            {
                return numbers;
            }
            var firstNumber = numbers.First();
            var lastNumber = numbers.Last();

            return numbers
                .Where(number => number != firstNumber)
                .Prepend(firstNumber)
                .Where(number => number != lastNumber)
                .Append(lastNumber);
        }

        //Refactoring challenge
        public static IEnumerable<string> TrimSentenceAndChangeEndMarker_Refactored(
            IEnumerable<string> words)
        {
            return words.TakeWhile(word => word != "The end").Append("END");
        }

        //do not modify this method
        public static IEnumerable<string> TrimSentenceAndChangeEndMarker(IEnumerable<string> words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                if (word != "The end")
                {
                    result.Add(word);
                }
                else
                {
                    break;
                }
            }
            result.Add("END");
            return result;
        }
    }
}
