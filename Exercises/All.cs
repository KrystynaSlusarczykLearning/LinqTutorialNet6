using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class All
    {
        //Coding Exercise 1
        //Use LINQ to implement the AreAllNumbersDivisibleBy10 method,
        //which checks if all numbers in the collection are divisible by 10.
        public static bool AreAllNumbersDivisibleBy10(int[] numbers)
        {
            return numbers.All(n => n % 10 == 0);
        }

        //Coding Exercise 2
        //Using LINQ, implement the AreAllPetsOfTheSameType method that checks
        //if all Pets in the collection are of the same PetType.
        public static bool AreAllPetsOfTheSameType(IEnumerable<Pet> pets)
        {
            //var firstPetType = pets.FirstOrDefault().PetType;
            //return pets.All(pet => pet.PetType == firstPetType);

            //return pets.All(pet => pet.PetType == PetType.Cat) 
            //    || pets.All(pet => pet.PetType == PetType.Dog)
            //    || pets.All(pet => pet.PetType == PetType.Fish);

            // Instructor has more extensible answer (if PetType enum changes)
            var allPetTypesArray = Enum.GetValues(typeof(PetType));
            var allPetTypes = allPetTypesArray.Cast<PetType>();

            var allPetsOfSameType = allPetTypes.Any(petType => pets.All(pet => pet.PetType == petType));

            return allPetsOfSameType;
        }

        //Refactoring challenge
        public static bool AreAllWordsOfTheSameLength_Refactored(List<string> words)
        {
            //var firstLength = words?.FirstOrDefault()?.Length;
            //return words.Count == 0 || words.All(word => word.Length == firstLength);

            // Better answer below. I hadn't noticed  input was a List; therefore I can address elements in the array
            //  All() will return true on an empty list!
            return words.All(w => w.Length == words[0].Length);
        }

        //do not modify this method
        public static bool AreAllWordsOfTheSameLength(List<string> words)
        {
            if (words.Count == 0 || words.Count == 1)
            {
                return true;
            }
            var length0 = words[0].Length;
            for (int i = 1; i < words.Count; ++i)
            {
                if (words[i].Length != length0)
                {
                    return false;
                }
            }
            return true;
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
