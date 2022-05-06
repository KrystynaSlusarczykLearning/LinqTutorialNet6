using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class OrderByQuerySyntax
    {
        //Coding Exercise 1
        /*
        Implement the OrderFromLongestToShortest method, which given a collection of 
        TimeSpans will order them from longest to shortest. Use LINQ's query syntax.

        For example, for the following timespans:
            *TimeSpan.FromSeconds(93)
            *TimeSpan.FromSeconds(5)
            *TimeSpan.FromSeconds(16)
        
        ...the result shall be:
            *TimeSpan.FromSeconds(93)
            *TimeSpan.FromSeconds(16)
            *TimeSpan.FromSeconds(5)
         */
        public static IEnumerable<TimeSpan>
            OrderFromLongestToShortest(
                IEnumerable<TimeSpan> timeSpans)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
        Implement the OrderPoints method using LINQ's query syntax. 
        This method shall order points first by X, and then by Y.

        For example, for the following points:
            *X=10, Y = 7
            *X=10, Y =5
            *X=10, Y = 6
            *X=7, Y = 6
            *X=11, Y = 5
        
        ...the result shall be:
            *X=7, Y = 6
            *X=10, Y = 5
            *X=10, Y = 6
            *X=10, Y = 7
            *X=11, Y = 5
        
        As you can see there are 3 points with X=10, so those points are ordered by Y 
        in the result.
         */
        public static IEnumerable<Point> OrderPoints(
             IEnumerable<Point> points)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<DateTime>
            OrderDatesByDayOfWeek_Refactored(
                IEnumerable<DateTime> dates)
        {
            //TODO your code goes here
            throw new NotImplementedException();
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
