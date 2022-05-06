using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class OrderByQuerySyntax
    {
        //Coding Exercise 1
        public static IEnumerable<TimeSpan>
            OrderFromLongestToShortest(
                IEnumerable<TimeSpan> timeSpans)
        {
            return from timeSpan in timeSpans
                   orderby timeSpan descending
                   select timeSpan;
        }

        //Coding Exercise 2
        public static IEnumerable<Point> OrderPoints(
             IEnumerable<Point> points)
        {
            return from point in points
                   orderby point.X, point.Y
                   select point;
        }

        //Refactoring challenge
        public static IEnumerable<DateTime>
            OrderDatesByDayOfWeek_Refactored(
                IEnumerable<DateTime> dates)
        {
            return from date in dates
                   orderby date.DayOfWeek
                   select date;
        }

        //do not modify this method
        public static IEnumerable<DateTime>
            OrderDatesByDayOfWeek(
                IEnumerable<DateTime> dates)
        {
            var result = dates.ToList();
            result.Sort((left, right) =>
            {
                return left.DayOfWeek.CompareTo(right.DayOfWeek);
            });
            return result;
        }

        //do not modify this method

        public struct Point
        {
            public double X { get; }
            public double Y { get; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"X: {X}, Y: {Y}";
            }
        }
    }
}
