using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Select
    {
        //Coding Exercise 1
        public static IEnumerable<int> GetNumbers(IEnumerable<object> objects)
        {
            return objects.OfType<int>().Concat(
                objects.OfType<string>()
                .Select(text => {
                    int result;
                    return int.TryParse(text, out result) ? result : (int?)null;
                })
                .Where(nullableNumber => nullableNumber != null)
                .Select(nullableNumber => nullableNumber.Value))
                .OrderBy(number => number);
        }

        //Coding Exercise 2
        public static IEnumerable<Person> PeopleFromString(string input)
        {
            return input.Split(';')
               .Select(personData =>
               {
                   try
                   {
                       var split = personData.Split(',');
                       var fullName = split[0].Split(' ');
                       var firstName = fullName[0];
                       var lastName = fullName[1];
                       var dateOfBirth = DateTime.Parse(split[1]);

                       return new Person
                       {
                           FirstName = firstName,
                           LastName = lastName,
                           DateOfBirth = dateOfBirth
                       };
                   }
                   catch (Exception)
                   {
                       return null;
                   }
               })
               .Where(person => person != null);
        }

        //Refactoring challenge
        public static TimeSpan TotalDurationOfSongs_Refactored(string allSongsDuration)
        {
            return string.IsNullOrEmpty(allSongsDuration) ?
                new TimeSpan() :
                TimeSpan.FromSeconds(
                allSongsDuration.Split(',')
                .Select(songDurationAsString => TimeSpan.ParseExact(
                    songDurationAsString, @"m\:ss", null))
                .Sum(timeSpan => timeSpan.TotalSeconds));
        }

        //do not modify this method
        public static TimeSpan TotalDurationOfSongs(
            string allSongsDuration)
        {
            if (string.IsNullOrEmpty(allSongsDuration))
            {
                return new TimeSpan();
            }

            var durationStrings = allSongsDuration.Split(',');
            var totalDuration = 0d;
            foreach (var durationString in durationStrings)
            {
                var timeSpan = TimeSpan.ParseExact(
                    durationString, @"m\:ss", null);
                totalDuration += timeSpan.TotalSeconds;
            }

            return TimeSpan.FromSeconds(totalDuration);
        }

        public class Person : IEquatable<Person>
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName} born on {DateOfBirth.ToString("d")}";
            }

            public bool Equals(Person other)
            {
                return FirstName == other.FirstName &&
                       LastName == other.LastName &&
                       DateOfBirth == other.DateOfBirth;
            }
        }
    }
}
