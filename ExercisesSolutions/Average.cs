using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Average
    {
        //Coding Exercise 1
        public static float? AverageSnowFall(SnowFallData snowFallData)
        {
            return (snowFallData != null &&
                    snowFallData.MonthlySnowFallDataItems != null &&
                    snowFallData.MonthlySnowFallDataItems.Count() == 12) ?
                snowFallData.MonthlySnowFallDataItems.Average(
                    snowFallDataItem => snowFallDataItem.SnowfallInCentimeters) :
                null;
        }

        //Coding Exercise 2
        public static double MaxAverageOfMarks(IEnumerable<Student> students)
        {
            return students.Any() ?
                students.Max(student => student.Marks.Any() ? student.Marks.Average() : 0) :
                0;
        }

        //Refactoring challenge
        public static float CalculateAverageHeight_Refactored(
            List<float?> heights, float defaultIfNull)
        {
            return heights == null || !heights.Any() ?
                0 :
                heights.Average(height => height ?? defaultIfNull);
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
