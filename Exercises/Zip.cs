using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Zip
    {
        //Coding Exercise 1
        /*
         Imagine you work on a program which imports data stored in Excel spreadsheets. 
        There is a need to import dates, but each part of a date - year, month, and day -
        is stored in a separate column. The data from each column is imported into your
        program as a collection of integers.

        Implement the BuildDates method, which given collections of 
        years, months and days will build a collection of DateTimes. 
        The result shall be ordered from the oldest date to the newest.
        
        For example, for the following input:
            *years: {2020, 1990, 2010}
            *months: {3, 5, 1}
            *days {1, 5, 17}
        
        ...the following dates shall be returned
            *new DateTime(1990, 5, 5)
            *new DateTime(2010, 1, 17)
            *new DateTime(2020, 3, 1)
        
        Please assume the input is valid, which means:
            *all collections have the same length
            *all values are valid, which means valid dates can be built from them 
                (for example months range from 1 to 12)
         */
        public static IEnumerable<DateTime> BuildDates(
            IEnumerable<int> years,
            IEnumerable<int> months,
            IEnumerable<int> days)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
        Implement the GetDaysDifferencesBetweenDates method, which given an ordered 
        collection of dates will return a collection of strings with information on 
        how many days have passed between dates in the collection.

        For example, for the following dates:
            *new DateTime(1899, 1, 1),
            *new DateTime(1899, 4, 12)
            *new DateTime(1899, 12, 31)
        
        ...the result shall be:        
            *"It's been 101 days between 1899-01-01 and 1914-04-12"
            *"It's been 263 days between 1914-04-12 and 1929-12-31"
        
        To format dates to string, please use the date.ToString("yyyy-MM-dd") formatting.
         */
        public static IEnumerable<string>
            GetDaysDifferencesBetweenDates(
                IEnumerable<DateTime> dates)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string> MakeList_Refactored(IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string> MakeList(IEnumerable<string> words)
        {
            var result = new List<string>();
            char letter = 'A';
            foreach (var word in words)
            {
                result.Add($"{letter}) {word}");
                letter++;
            }
            return result;
        }
    }
}
