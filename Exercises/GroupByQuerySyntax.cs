using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class GroupByQuerySyntax
    {
        //Coding Exercise 1
        /*
         Using LINQ's query syntax, implement the GroupByFirstDigit method, 
        which given a collection of numbers will group them by the first digit, 
        and return a collection of strings with information about each group.

        For example, for numbers {1, 11, 44, 4, 62, 672, 921} the result shall be:
            "FirstDigit: 1, numbers: 1,11",
            "FirstDigit: 4, numbers: 44,4",
            "FirstDigit: 6, numbers: 62,672",
            "FirstDigit: 9, numbers: 921"
         */
        public static IEnumerable<string> GroupByFirstDigit(IEnumerable<int> numbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
        Using LINQ's query syntax, implement the GroupByDayOfWeek method, 
        which given a collection of dates will return a Dictionary<DayOfWeek, DateTime>,
        where the day of the week will be the key, and the latest date with this 
        day of the week will be the value.

        For example, for the following dates:
            *new DateTime(2021, 10, 17) (Sunday)
            *new DateTime(2021, 10, 10) (Sunday)
            *new DateTime(2021, 10, 24) (Sunday)
            *new DateTime(2021, 10, 11) (Monday)
            *new DateTime(2021, 10, 4) (Monday)
        
        ...the result will be the following dictionary:        
            *[DayOfWeek.Sunday] = new DateTime(2021, 10, 24)
            *[DayOfWeek.Monday] = new DateTime(2021, 10, 11)
        
        Please note that those dates have been selected as values because for 
        given days of the week they are the latest dates.
         */
        public static Dictionary<DayOfWeek, DateTime> GroupByDayOfWeek(
            IEnumerable<DateTime> dates)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string> GetOwnersWithMultipleHouses_Refactored(
            IEnumerable<House> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string>
            GetOwnersWithMultipleHouses(
                IEnumerable<House> houses)
        {
            var ownersHouses = new Dictionary<int, List<House>>();
            foreach (var house in houses)
            {
                if (!ownersHouses.ContainsKey(house.OwnerId))
                {
                    ownersHouses[house.OwnerId] = new List<House>();
                }
                ownersHouses[house.OwnerId].Add(house);
            }

            var result = new List<string>();
            foreach (var keyValue in ownersHouses)
            {
                if (keyValue.Value.Count > 1)
                {
                    result.Add(
                        $"Owner with ID {keyValue.Key} " +
                        $"owns houses: " +
                        $"{string.Join(", ", keyValue.Value)}");
                }
            }
            return result;
        }

        public class House
        {
            public int OwnerId { get; }
            public string Address { get; }

            public House(int ownerId, string address)
            {
                OwnerId = ownerId;
                Address = address;
            }

            public override string ToString()
            {
                return $"{Address}";
            }
        }
    }
}
