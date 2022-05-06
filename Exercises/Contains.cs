using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Contains
    {
        //Coding Exercise 1
        /*
        Using LINQ, implement the IsAppointmentDateAvailable method. 
        This method takes two parameters: 
            *date of an appointment, and 
            *existingAppointmentDates, 
                which is a collection of dates that are already taken. 
        This method should return true only if the date is not amongst the 
        existingAppointmentDates.
        For example, for the following existingAppointmentDates:
        new DateTime(2022, 1, 11),
        new DateTime(2022, 1, 12)
        ...and the date parameter equal to new DateTime(2022, 1, 10), 
        the result shall be true, because the date is not present in 
        the existingAppointmentDates.
        On the other hand, for the following existingAppointmentDates:
        new DateTime(2022, 1, 11),
        new DateTime(2022, 1, 10)
        ...and the date parameter equal to new DateTime(2022, 1, 10), 
        the result shall be false, because the date is present in 
        the existingAppointmentDates.*/
        public static bool IsAppointmentDateAvailable(
            DateTime date, IEnumerable<DateTime> existingAppointmentDates)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
        Implement the CountFriendsOf method. This method takes the friend parameter and 
        a collection of people. We want to count all those people, who have 
        the friend amongst their friends.
        For example, in this case, the result of the method should be 3 
        because there are 3 people who have friend in their Friends collection:

        var friend = new Friend();
            var otherFriend = new Friend();
            var people = new List<Person>
            {
                new Person("John", new [] {friend}),
                new Person("Mary", new [] {friend, otherFriend}),
                new Person("Jack", new [] {friend, otherFriend}),
                new Person("Martin", new [] {otherFriend})
            };
         */
        public static int CountFriendsOf(Friend friend, IEnumerable<Person> people)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static bool ContainsBannedWords_Refactored(
            IEnumerable<string> words, IEnumerable<string> bannedWords)
        {
            //TODO your code goes here
            throw new NotImplementedException();
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
