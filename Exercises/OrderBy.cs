using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class OrderBy
    {
        //Coding Exercise 1
        /*
         Using LINQ, implement the OrderFromLongestToShortest method, which takes 
        a collection of strings, and returns those strings ordered from 
        longest to shortest.
        For example, for {"bb", "a", "ccc"} the result should be {"ccc", "bb", "a"}
         */
        public static IEnumerable<string> OrderFromLongestToShortest(
            IEnumerable<string> words)
        {
            // Below is wrong but initially passed; added a parameterized test to cover the false positive
            // return words.OrderByDescending(a => a);
            
            return words.OrderByDescending(x => x.Length); // x is a string
        }

        //Coding Exercise 2
        /*
         Using LINQ, implement the FirstEvenThenOddDescending method, 
         which orders numbers like this:
            *first, the even numbers
            *then, the odd numbers
         Then the numbers should be ordered descending. 
         For example, for numbers {1,2,3,4,5,6,7} the result should be: {6,4,2,7,5,3,1}.
         */
        public static IEnumerable<int> FirstEvenThenOddDescending(
            IEnumerable<int> numbers)
        {
            var n1 = numbers.OrderBy(num => num);  // lesser comes before greater 
            var f1 = numbers.OrderBy(num => num%2 == 0); // odd numbers come first

            return numbers.OrderByDescending(num => num%2 == 0).ThenByDescending(num => num);
        }


/*     TODO: Do the above with comparator method
 * private bool CompareEven(IEnumerable<int>)
        { 
            return 
        } */

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<DateTime> OrderByMonth_Refactored(List<DateTime> dates)
        {
            return dates.OrderBy(d => d.Month);
        }

        //do not modify this method
        public static IEnumerable<DateTime> OrderByMonth(List<DateTime> dates)
        {
            dates.Sort((left, right) =>
            {
                return left.Month.CompareTo(right.Month);
            });
            return dates;
        }
    }
}
