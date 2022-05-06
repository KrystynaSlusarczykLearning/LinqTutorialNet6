using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Distinct
    {
        //Coding Exercise 1
        /*
         Implement the AreAllUnique method, which will check if all elements of 
        a collection are unique.

        For example:
            *for numbers 1,2,3,4 the result shall be true because no number is duplicated
            *for strings AAA, BBB, BBB, CCC the result shall be false 
                because BBB is duplicated
         */
        public static bool AreAllUnique<T>(IEnumerable<T> collection)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
         Implement the GetCollectionWithMostDuplicates method, which given 
        a collection of collections will return the collection with 
        the most duplicates in it. 
        If a couple of collections have the same count of duplicates, 
        the shortest should be returned. 
        If the collections parameter is empty, the result shall be null.

        Let's consider the following collections:        
            *{1,2,3,4} - it has 0 duplicates        
            *{1,2,3,3,4,4,4} - it has 3 duplicates: 
                one 3 is a duplicate, and two 4s are duplicates       
            *{1,2,3,3,4,4,4,5,6,7} - it has 3 duplicates: one 3 is a duplicate, 
                and two 4s are duplicates
        
        The result shall be the second collection, because it has the most duplicates, 
        and it is the shortest of two collections with 3 duplicates
         */
        public static IEnumerable<T> GetCollectionWithMostDuplicates<T>(
            IEnumerable<IEnumerable<T>> collections)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string> GetWordsShorterThan5Letters_Refactored(
            IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string> GetWordsShorterThan5Letters(
            IEnumerable<string> words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                if (word.Length < 5 && !result.Contains(word))
                {
                    result.Add(word);
                }
            }
            return result;
        }
    }
}
