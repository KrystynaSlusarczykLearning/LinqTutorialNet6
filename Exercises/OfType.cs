using System;
using System.Collections.Generic;

namespace Exercises
{
    public static class OfType
    {
        //Coding Exercise 1
        //Implement the GetTheFirstInteger method, which given a collection of objects,
        //will return the first integer from this collection.
        //If no integer is present, it shall return null.
        public static int? GetTheFirstInteger(IEnumerable<object> objects)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        //Implement the AreAllStringsUpperCase method which will check if all strings
        //present in the objects collection are upper case.
        //If there is no string at all in this collection, the result should be true.
        public static bool AreAllStringsUpperCase(IEnumerable<object> objects)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static DateTime? GetTheLatestDate_Refactored(IEnumerable<object> objects)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static DateTime? GetTheLatestDate(IEnumerable<object> objects)
        {
            DateTime? lastDate = null;
            foreach (var obj in objects)
            {
                var dateTime = obj as DateTime?;
                if (dateTime != null)
                {
                    if (lastDate == null || lastDate < dateTime)
                    {
                        lastDate = dateTime;
                    }
                }
            }
            return lastDate;
        }
    }
}
