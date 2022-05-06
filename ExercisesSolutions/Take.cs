using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Take
    {
        //Coding Exercise 1
        public static IEnumerable<int> TakeSome(IEnumerable<int> numbers)
        {
            return numbers.Count() < 10 ?
                numbers.Take(3) :
                numbers.Count() < 100 ? numbers.Take(30) : numbers;
        }

        //Coding Exercise 2
        public static IEnumerable<Pet> GetGivenPercentOfHeaviestPets(
            IEnumerable<Pet> pets, int percent)
        {
            return pets
                .OrderByDescending(pet => pet.Weight)
                .Take(pets.Count() * percent / 100);
        }

        //Refactoring challenge
        public static IEnumerable<DateTime> GetDatesBeforeXXCentury_Refactored(
            IEnumerable<DateTime> dates)
        {
            return dates.TakeWhile(date => date.Year < 1901);
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
