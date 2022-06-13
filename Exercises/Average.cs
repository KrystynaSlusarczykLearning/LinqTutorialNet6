using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Average
    {
        //Coding Exercise 1
        /*
        Let's define a class SnowFallData that holds the information about snowfall 
        in months of a given year. For example, for the year 2020, we could have:
            *20 centimeters of snowfall in January
            *25 centimeters  in February
            *5 centimeters  in March
            *0 centimeters  in April
            *etc.  
        Implement the AverageSnowFall method that will calculate the average snowfall 
        in centimeters for a given SnowFallData object. 
        This method should return null if the object is null, 
        or its monthly snowfall data is null or the count of MonthlySnowFallDataItems 
        is not 12 (one for each month).
        */
        public static float? AverageSnowFall(SnowFallData snowFallData)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
        Let's define a Student class. A student has a collection of Marks, 
        which are numbers. We could calculate the average mark for each student, 
        for example, if a student's marks are 3,4,5, 
        the average mark for this student is 4.

        Implement the MaxAverageOfMarks method, which will find the maximum average mark 
        for all students.
        For example, let's consider students:
            *Cathy has marks 4,4,6 which gives an average of 4.66
            *Martin has marks 5,5,5,3 which gives an average of 4.5
            *Bethy has marks of 6,5,5,3 which gives an average of 4.75
        For those students, the MaxAverageOfMarks method shall return 4.75, 
        as this is the maximum average mark.

        If the student list is empty, the method shall return 0. 
        If a student has no marks at all, we assume their average mark is 0.
         */
        public static double MaxAverageOfMarks(IEnumerable<Student> students)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static float CalculateAverageHeight_Refactored(
            List<float?> heights, float defaultIfNull)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static float CalculateAverageHeight(
            List<float?> heights, float defaultIfNull)
        {
            if (heights == null || heights.Count == 0)
            {
                return 0;
            }
            var sum = 0f;
            foreach (var height in heights)
            {
                if (height == null)
                {
                    sum += defaultIfNull;
                }
                else
                {
                    sum += height.Value;
                }
            }
            return sum / heights.Count;
        }

        public class Student
        {
            public IEnumerable<int> Marks { get; set; }
        }

        public class SnowFallData
        {
            public int Year { get; set; }
            public List<MonthlySnowFallData> MonthlySnowFallDataItems { get; set; }
        }

        public class MonthlySnowFallData
        {
            public int Month { get; set; }
            public float SnowfallInCentimeters { get; set; }
        }
    }
}
