using System;
using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class Zip
    {
        //System.Linq.Enumerable.Zip
        public static void Run()
        {
            //Zip applies a specified function to
            //the corresponding elements of two sequences,
            //producing a sequence of the results.

            var numbers = new[] { 1, 2, 3, 4, 5 };
            var words = new[] { "The", "quick", "brown", "fox", "jumps" };
            var zipped = numbers.Zip(words,
                (number, word) => $"{number}. {word}");

            Printer.Print(zipped, nameof(zipped));

            //if the collections are of different lengths
            //the overflow will simply be ignored
            var moreNumbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var zipped2 = moreNumbers.Zip(words,
                (number, word) => $"{number}. {word}");

            Printer.Print(zipped2, nameof(zipped2));

            //let's say we want to zip two collections into a dictionary
            //we can use the result of the Zip function
            //which is a collection of tuples
            var countries = new[] { "United States", "Great Britain", "Poland" };
            var currencies = new[] { "USD", "GBP", "PLN" };
            var dictionary = countries.Zip(currencies).ToDictionary(
                pair => pair.First,
                pair => pair.Second);
            Printer.Print(dictionary, nameof(dictionary));

            //it is quite common to zip a collection with itself
            //let's say we have a list of Points on the map
            //created by some application tracking activity like running or cycling
            //let's find the distances between particular Points
            var points = new[]
            {
                new Point(10, 10),
                new Point(10, 11),
                new Point(11, 12),
                new Point(11, 14),
                new Point(12, 16)
            };
            //first, we will find pairs of points:
            //first and second
            //second and third
            //third and fourth etc.
            //and then we will calculate distances between those points
            var distances = points.Zip(
                points.Skip(1),
                (point1, point2) => GetDistance(point1, point2));
            Printer.Print(distances, nameof(distances));
        }

        private static double GetDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + 
                Math.Pow((point2.Y - point1.Y), 2));
        }

        class Point
        {
            public int X { get; }
            public int Y { get; }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
