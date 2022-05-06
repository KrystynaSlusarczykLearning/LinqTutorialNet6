using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class OfType
    {
        //Coding Exercise 1
        public static int? GetTheFirstInteger(IEnumerable<object> objects)
        {
            return objects.OfType<int?>().FirstOrDefault();
        }

        //Coding Exercise 2
        public static bool AreAllStringsUpperCase(IEnumerable<object> objects)
        {
            return objects.OfType<string>().All(text => text.ToUpper() == text);
        }

        //Refactoring challenge
        public static DateTime? GetTheLatestDate_Refactored(IEnumerable<object> objects)
        {
            var dates = objects.OfType<DateTime>();
            return dates.Any() ? dates.Max() : (DateTime?)null;
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
