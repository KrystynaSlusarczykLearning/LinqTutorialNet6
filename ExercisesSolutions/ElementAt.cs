using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class ElementAt
    {
        //Coding Exercise 1
        public static bool IsTheNumberAtIndexTheLargest(
            IEnumerable<int> numbers, int index)
        {
            if (index < 0 || index >= numbers.Count())
            {
                return false;
            }
            return numbers.All(number => number <= numbers.ElementAt(index));

            //alternative solution
            //return numbers.Max() == numbers.ElementAt(index);
        }

        //Coding Exercise 2
        public static string FormatPetDataAtIndex(
            IEnumerable<Pet> pets, int index)
        {
            var pet = pets.ElementAtOrDefault(index);
            return pet == null ?
                $"Pet data is missing for index {index}" :
                $"Pet name: {pet.Name}";
        }

        //Refactoring challenge
        public static bool IsEmptyAtIndex_Refactored(IEnumerable<string> words, int index)
        {
            return string.IsNullOrEmpty(words.ElementAtOrDefault(index));
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
