using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Contains
    {
        //Coding Exercise 1
        public static bool IsAppointmentDateAvailable(
            DateTime date, IEnumerable<DateTime> existingAppointmentDates)
        {
            return !existingAppointmentDates.Contains(date);
        }

        //Coding Exercise 2
        public static int CountFriendsOf(Friend friend, IEnumerable<Person> people)
        {
            return people.Count(person => person.Friends.Contains(friend));
        }

        //Refactoring challenge
        public static bool ContainsBannedWords_Refactored(
            IEnumerable<string> words, IEnumerable<string> bannedWords)
        {
            return words.Any(word => bannedWords.Contains(word));
        }

        //do not modify this method
        public static bool ContainsBannedWords(
            IEnumerable<string> words, IEnumerable<string> bannedWords)
        {
            foreach (var word in words)
            {
                foreach (var bannedWord in bannedWords)
                {
                    if (word == bannedWord)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public class Person
        {
            public string Name { get; }
            public IEnumerable<Friend> Friends { get; }

            public Person(string name, IEnumerable<Friend> friends)
            {
                Name = name;
                Friends = friends;
            }
        }

        public class Friend
        {
            public string Name { get; }
        }
    }
}
