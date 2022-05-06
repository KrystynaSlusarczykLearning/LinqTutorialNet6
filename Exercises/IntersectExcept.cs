using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class IntersectExcept
    {
        //Coding Exercise 1
        /*
         Implement the CountCommonWords method, which given two collections of strings 
        will return the count of the words that belong to both of those collections. 
        Please note that the casing of the words does not matter.

        For example, for the following collections:
            *{"aaa", "BBB", "CCC"}
            *{"aaa", "ccc", "DDD"}

        The result shall be 2 because there are two words that occur in both collections:
        "aaa" and "ccc". As we said, it doesn't matter if "ccc" is lower case in one 
        collection and upper case in the other.
         */
        public static int CountCommonWords(
            IEnumerable<string> words1,
            IEnumerable<string> words2)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
         Implement the GetExclusiveNumbers method, which given two collections of numbers,
        will return an ordered collection consisting of those numbers, that only 
        occurred in one of those collections.

        For example, for the following input:
            *{1,2,3,4,5,6}
            *{9,8,7,6,5}
        
        The result shall be {1,2,3,4,7,8,9} because those are the numbers that are 
        exclusive for one collection only.
         */
        public static IEnumerable<int> GetExclusiveNumbers(
            IEnumerable<int> numbers1,
            IEnumerable<int> numbers2)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string>
            GetRoutesInfo_Refactored(
                Route route1, Route route2)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string> GetRoutesInfo(
           Route route1, Route route2)
        {
            var result = new List<string>();
            var sharedPoints = new List<RoutePoint>();
            foreach (var routePoint1 in route1.RoutePoints)
            {
                foreach (var routePoint2 in route2.RoutePoints)
                {
                    if (routePoint1.Equals(routePoint2))
                    {
                        if (!sharedPoints.Contains(routePoint1))
                        {
                            sharedPoints.Add(routePoint1);
                            result.Add($"Shared point " +
                            $"{routePoint1.Name}" +
                            $" at {routePoint1.Point}");
                        }
                    }
                }
            }
            foreach (var routePoint in route1.RoutePoints)
            {
                if (!sharedPoints.Contains(routePoint))
                {
                    result.Add(
                        $"Unshared point " +
                        $"{routePoint.Name}" +
                        $" at {routePoint.Point}");
                }
            }
            foreach (var routePoint in route2.RoutePoints)
            {
                if (!sharedPoints.Contains(routePoint))
                {
                    result.Add(
                        $"Unshared point " +
                        $"{routePoint.Name}" +
                        $" at {routePoint.Point}");
                }
            }

            return result;
        }

        public class Route
        {
            public IEnumerable<RoutePoint> RoutePoints { get; }
            public Route(IEnumerable<RoutePoint> routePoints)
            {
                RoutePoints = routePoints;
            }

            public override string ToString()
            {
                return $"RoutePoints: ({string.Join("; ", RoutePoints)})";
            }
        }
        public struct RoutePoint
        {
            public string Name { get; }
            public Point Point { get; }
            public RoutePoint(string name, Point point)
            {
                Name = name;
                Point = point;
            }
            public override string ToString()
            {
                return $"{Name} ({Point})";
            }
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
