using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Single
    {
        //Coding Exercise 1
        /*
         Implement the GetTheOnlyUpperCaseWord method, which given a collection 
         of strings:
            *will return the only upper case string, if only one is present
            *will return null if no upper case string is present
            *will throw an InvalidOperationException if two or more upper case 
               strings are present.
         For example:
            *for words {"aaa", "BBB", "CcC"} the result will be "BBB"
            *for words {"aaa", "bbB", "CcC"} the result will be null
            *for words {"aaa", "BBB", "CcC", "DDD"} InvalidOperationException 
                will be thrown
         */
        public static string GetTheOnlyUpperCaseWord(IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        /*
        Implement the GetSingleElementCollection method, which given a nested collection
        of integers will return the only collection which contains only a single element. 
        
        For example, for numberCollections parameter like this:
            *numberCollections[0] = {1,2,3}
            *numberCollections[1] = {4}
            *numberCollections[2] = {5,6}
        ...the result shall be numberCollections[1], because it is the only 
        single-element collection in the input parameter

        If there is no single-element list present, or there is more than one list 
        like that, an InvalidOperationException should be thrown.

        For example, for numberCollections parameter like this:
            *numberCollections[0] = {1,2,3}
            *numberCollections[1] = {5,6}
        ...InvalidOperationException should be thrown, 
        because there is no single-element collection here.

        For example, for numberCollections parameter like this:
            *numberCollections[0] = {1,2,3}
            *numberCollections[1] = {4}
            *numberCollections[2] = {5,6}
            *numberCollections[3] = {7}

        ...InvalidOperationException should be thrown, 
        because there are two single-element collections here.
         */
        //Coding Exercise 2
        public static IEnumerable<int> GetSingleElementCollection(
            IEnumerable<IEnumerable<int>> numberCollections)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static DateTime? GetSingleDay_Refactored(
            IEnumerable<DateTime> dates, DayOfWeek dayOfWeek)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static DateTime? GetSingleDay(
            IEnumerable<DateTime> dates, DayOfWeek dayOfWeek)
        {
            var count = 0;
            DateTime? result = null;
            foreach (var date in dates)
            {
                if (date.DayOfWeek == dayOfWeek)
                {
                    result = date;
                    count++;
                }
            }
            if (count == 1)
            {
                return result;
            }
            return null;
        }

        public enum PetType
        {
            Cat,
            Dog,
            Fish
        }

        public class Pet
        {
            public int Id { get; }
            public string Name { get; }
            public PetType PetType { get; }
            public float Weight { get; }

            public Pet(int id, string name, PetType petType, float weight)
            {
                Id = id;
                Name = name;
                PetType = petType;
                Weight = weight;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Type: {PetType}, Weight: {Weight}";
            }
        }
    }
}
