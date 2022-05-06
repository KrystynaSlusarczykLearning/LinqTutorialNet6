using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class ElementAt
    {
        //Coding Exercise 1
        /*
        Using LINQ, implement the IsTheNumberAtIndexTheLargest method. 
        This method should check if the number at the given index is 
        the largest number in the collection. 
        For example, IsTheNumberAtIndexTheLargest (new int[] {1,2,4,4}, 0) 
            should return false, because the number at index 0 is 1, 
            and it is not the largest in this collection.
        If there are other numbers equally large, the result should be true. 
        For example, IsTheNumberAtIndexTheLargest (new int[] {1,2,4,4}, 3) 
            should return true, because the number at index 3 has a value of 4, 
            and it is one of the largest numbers in the collection.
        If no such index is present in the collection, the method should return false.
         */
        public static bool IsTheNumberAtIndexTheLargest(
            IEnumerable<int> numbers, int index)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
         Using LINQ, implement the FormatPetDataAtIndex method, which takes 
        a collection of pets and an index, and does the following:
            *if the index is valid and the pet at this index is not null, 
                the result should be "Pet name: NAME" where NAME is the name of this pet
            *otherwise, the result should be "Pet data is missing for index INDEX" 
                where INDEX is the index we tried to access
         */
        public static string FormatPetDataAtIndex(
            IEnumerable<Pet> pets, int index)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static bool IsEmptyAtIndex_Refactored(IEnumerable<string> words, int index)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static bool IsEmptyAtIndex(IEnumerable<string> words, int index)
        {
            var array = words.ToArray();
            if (index < 0 || index >= array.Length)
            {
                return true;
            }
            if (string.IsNullOrEmpty(array[index]))
            {
                return true;
            }
            return false;
        }

        public class Pet
        {
            public string Name { get; set; }
        }
    }
}
