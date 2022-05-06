using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Any
    {
        //Coding Exercise 1
        public static bool IsAnyNumberNegative(IEnumerable<int> numbers)
        {
            return numbers.Any(number => number < 0);
        }

        //Coding Exercise 2
        public static bool AreThereAnyBigCats(IEnumerable<Pet> pets)
        {
            return pets.Any(pet => pet.PetType == PetType.Cat && pet.Weight > 2);
        }

        //Refactoring challenge
        public static bool AreAllNamesValid_Refactored(string[] names)
        {
            return !names.Any(name =>
                char.IsLower(name[0]) ||
                name.Length < 2 ||
                name.Length > 25);
        }

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
