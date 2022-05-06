using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Count
    {
        //Coding Exercise 1
        //Implement the CountAllLongWords method,
        //which will count all words longer than 10 letters.
        public static int CountAllLongWords(IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
         Using LINQ, implement the AreThereFewerOddThanEvenNumbers method, 
         which will check if in the collection of numbers 
         there are fewer odd than even numbers.
         For example:
         {2,3,4,5,6} -> will return true, because there are 3 even numbers (2,4,6) and 2 odd numbers (3,5)
         {3,4,5} ->  will return false, because there is 1 even number (4) and 2 odd numbers (3,5)
         {2,3,4,5} ->  will return false, because there are 2 even numbers (2,4) and 2 odd numbers (3,5)
         Remember, you can check if the number is even by using the modulo operation:
         number % 2 == 0 means the number is even
         number % 2 != 0 means the number is odd
         */
        public static bool AreThereFewerOddThanEvenNumbers(IEnumerable<int> numbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static bool IsAnySequenceTooLong_Refactored(IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static bool IsAnySequenceTooLong(IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
        {
            foreach (var numberSequence in numberSequences)
            {
                var count = 0;
                foreach (var number in numberSequence)
                {
                    ++count;
                }
                if (count > maxLength)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
