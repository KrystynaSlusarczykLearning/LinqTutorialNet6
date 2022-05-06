using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Single
    {
        //Coding Exercise 1
        public static string GetTheOnlyUpperCaseWord(IEnumerable<string> words)
        {
            return words.SingleOrDefault(word => word.ToUpper() == word);
        }

        //Coding Exercise 2
        public static IEnumerable<int> GetSingleElementCollection(
            IEnumerable<IEnumerable<int>> numberCollections)
        {
            return numberCollections.Single(collection => collection.Count() == 1);
        }

        //Refactoring challenge
        public static DateTime? GetSingleDay_Refactored(
            IEnumerable<DateTime> dates, DayOfWeek dayOfWeek)
        {
            return dates.Count(date => date.DayOfWeek == dayOfWeek) == 1 ?
                dates.Single(date => date.DayOfWeek == dayOfWeek) :
                (DateTime?)null;
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
