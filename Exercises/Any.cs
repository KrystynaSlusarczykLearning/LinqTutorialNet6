using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Any
    {
        //Coding Exercise 1
        //Using LINQ, implement the IsAnyNumberNegative method that checks
        //if any number in the collection is smaller than 0.
        public static bool IsAnyNumberNegative(IEnumerable<int> numbers)
        {
            //TODO you code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        //Using LINQ, implement the AreThereAnyBigCats method, which will check
        //if in the collection of Pets there is a cat that weighs over 2 kilos.
        public static bool AreThereAnyBigCats(IEnumerable<Pet> pets)
        {
            //TODO you code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static bool AreAllNamesValid_Refactored(string[] names)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static bool AreAllNamesValid(string[] names)
        {
            foreach (var name in names)
            {
                if (char.IsLower(name[0]))
                {
                    return false;
                }
                if (name.Length < 2)
                {
                    return false;
                }
                if (name.Length > 25)
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
