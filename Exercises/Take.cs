using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Take
    {
        //Coding Exercise 1
        /*
        Implement the TakeSome method, which returns a certain part of the collection,
        according to this algorithm:
            *if there are less than 10 elements in the collection, 
                it returns 3 elements (or all of them, if there are less than 3 elements 
                in the collection)
            *if there are 10 or more, but less than 100 elements in the collection, 
                it returns 30 elements (or all of them, if there are less than 30 
                elements in the collection)
            *if there are 100 or more elements, it returns all elements
         */
        public static IEnumerable<int> TakeSome(IEnumerable<int> numbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
         Implement the GetGivenPercentOfHeaviestPets method, which given 
        a collection of pets and a percent, shall return this percent of the pets 
        who are heaviest.

        For example:
            *for pets with weights {20, 10, 40, 5, 3, 16} and 50 percent, 
                the result collection should contain those pets who weigh 40, 20, 16 
                kilograms. We take 3 heaviest pets because 50% of the pets are 3 pets
            *for pets with weights {50, 5, 6, 25} and 30 percent, the result collection 
                should contain a single pet that weighs 50 kilograms. 
                We only want the single, heaviest pet, because 30% of 4 is 1.2, 
                which we floor down to 1

        The order of the result collection does not matter.
         */
        public static IEnumerable<Pet> GetGivenPercentOfHeaviestPets(
            IEnumerable<Pet> pets, int percent)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<DateTime> GetDatesBeforeXXCentury_Refactored(
            IEnumerable<DateTime> dates)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<DateTime> GetDatesBeforeXXCentury(
            IEnumerable<DateTime> dates)
        {
            var result = new List<DateTime>();
            foreach (var date in dates)
            {
                if (date.Year < 1901)
                {
                    result.Add(date);
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        public class Pet
        {
            public string Name { get; }
            public float Weight { get; }

            public Pet(string name, float weight)
            {
                Name = name;
                Weight = weight;
            }

            public override string ToString()
            {
                return $" Name: {Name}, Weight: {Weight}";
            }
        }
    }
}
