using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Count
    {
        //Coding Exercise 1
        public static int CountAllLongWords(IEnumerable<string> words)
        {
            return words.Count(word => word.Length > 10);
        }

        //Coding Exercise 2
        public static bool AreThereFewerOddThanEvenNumbers(
            IEnumerable<int> numbers)
        {
            return numbers.Count(number => number % 2 == 0) >
                numbers.Count(number => number % 2 != 0);
        }

        //Refactoring challenge
        public static bool IsAnySequenceTooLong_Refactored(
            IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
        {
            return numberSequences.Any(
                numberSequence => numberSequence.Count() > maxLength);
        }

        //do not modify this method
        public static bool IsAnySequenceTooLong(
            IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
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
