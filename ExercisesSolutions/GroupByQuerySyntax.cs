using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class GroupByQuerySyntax
    {
        //Coding Exercise 1
        public static IEnumerable<string> GroupByFirstDigit(IEnumerable<int> numbers)
        {
            return from number in numbers
                   group number by number.ToString()[0]
                    into groupsByFirstDigit
                   let groupedNumbers = string.Join(
                       ",",
                       from number in groupsByFirstDigit
                       select number)
                   select
                    $"FirstDigit: {groupsByFirstDigit.Key}, " +
                    $"numbers: {groupedNumbers}";
        }

        //Coding Exercise 2
        public static Dictionary<DayOfWeek, DateTime> GroupByDayOfWeek(
            IEnumerable<DateTime> dates)
        {
            return (from date in dates
                    group date by date.DayOfWeek
                   into groupedBeDaysOfWeek
                    select groupedBeDaysOfWeek)
                   .ToDictionary(
                grouping => grouping.Key,
                grouping => (from date in grouping orderby date select date).Last());
        }

        //Refactoring challenge
        public static IEnumerable<string> GetOwnersWithMultipleHouses_Refactored(
            IEnumerable<House> houses)
        {
            return from house in houses
                   group house by house.OwnerId
                   into housesGroupedByOwners
                   where housesGroupedByOwners.Count() > 1
                   select $"Owner with ID {housesGroupedByOwners.Key} owns houses: " +
                    $"{string.Join(", ", housesGroupedByOwners)}";
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
