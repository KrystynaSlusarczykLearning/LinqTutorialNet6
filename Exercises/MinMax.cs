using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class MinMax
    {
        //Coding Exercise 1
        /*
         Using LINQ, implement the LengthOfTheShortestWord method, 
        which will find the length of the shortest word in the words collection. 
        The returned type should be nullable int. 
        If the collection is empty, the result should be null.
        For example:
            *for words {"aaa", "bb", "c", "dddd"} the result should be 1, 
                because word "c" is the shortest word, and it has a length of 1
            *for an empty collection of words, the result shall be null       
         */
        public static int? LengthOfTheShortestWord(IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
         Using LINQ, implement the CountOfLargestNumbers method, 
         which will check how many numbers in the collection are equal to 
         the largest number in this collection. 
         For an empty collection, the result should be 0.
         For example:
            *for {3,2,2,4,4,0} the result will be 2. The largest number in the collection
               is four, and there are two fours in this collection
            *for {3,2,2,4,0} the result will be 1. The largest number in the collection 
               is four, and there is a single four in this collection
            *for {} the result will be 0
         */
        public static int CountOfLargestNumbers(IEnumerable<int> numbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static int CountOfDogsOfTheOwnerWithMostDogs_Refactored(
            IEnumerable<Person> owners)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static int CountOfDogsOfTheOwnerWithMostDogs(IEnumerable<Person> owners)
        {
            var maxDogCount = 0;
            foreach (var owner in owners)
            {
                var dogsCount = 0;
                foreach (var pet in owner.Pets)
                {
                    if (pet.PetType == PetType.Dog)
                    {
                        dogsCount++;
                    }
                }
                if (dogsCount > maxDogCount)
                {
                    maxDogCount = dogsCount;
                }
            }
            return maxDogCount;
        }

        public class Person
        {
            public int Id { get; }
            public string Name { get; }
            public IEnumerable<Pet> Pets;

            public Person(int id, string name, IEnumerable<Pet> pets)
            {
                Id = id;
                Name = name;
                Pets = pets;
            }
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
                return $"Id: {Id}, Name: {Name}, Type: {PetType}";
            }
        }

        public enum PetType
        {
            Cat,
            Dog,
            Fish
        }
    }
}
