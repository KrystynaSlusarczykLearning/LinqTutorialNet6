using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Route = Exercises.IntersectExcept.Route;
using RoutePoint = Exercises.IntersectExcept.RoutePoint;
using Point = Exercises.IntersectExcept.Point;
using Exercises;

namespace ExercisesTests
{
    [TestFixture]
    public class IntersectExcept_RefactoringChallenge_Tests
    {
        [Test]
        public void GetRoutesInfo_ShallWordCorrectly()
        {
            var route1 = new Route(new[]
                {
                    new RoutePoint("Farmers Market", new Point(10, 20)),
                    new RoutePoint("Old Town", new Point(5, 25)),
                    new RoutePoint("Shoemakers Street", new Point(20, 20))
                });
            var route2 = new Route(new[]
                {
                    new RoutePoint("Crooked Street", new Point(15, 20)),
                    new RoutePoint("Old Town", new Point(5, 25)),
                });
            var result = IntersectExcept.GetRoutesInfo(route1, route2);
            var expectedResult = new[]
           {
              "Shared point Old Town at X: 5, Y: 25",
              "Unshared point Farmers Market at X: 10, Y: 20",
              "Unshared point Shoemakers Street at X: 20, Y: 20",
              "Unshared point Crooked Street at X: 15, Y: 20"
            };

            CollectionAssert.AreEquivalent(expectedResult, result, 
                $"For ROUTE1 {EnumerableToString(route1.RoutePoints)} and ROUTE2 " +
                $"{EnumerableToString(route2.RoutePoints)} the RESULT shall be" +
                $" {EnumerableToString(expectedResult)}, BUT IT WAS " +
                $"{EnumerableToString(result)}");
        }

        [Test]
        public void GetRoutesInfo_Refactored_ShallWordCorrectly()
        {
            var route1 = new Route(new[]
                {
                    new RoutePoint("Farmers Market", new Point(10, 20)),
                    new RoutePoint("Old Town", new Point(5, 25)),
                    new RoutePoint("Shoemakers Street", new Point(20, 20))
                });
            var route2 = new Route(new[]
                {
                    new RoutePoint("Crooked Street", new Point(15, 20)),
                    new RoutePoint("Old Town", new Point(5, 25)),
                });
            var result = IntersectExcept.GetRoutesInfo_Refactored(route1, route2);
            var expectedResult = new[]
            {
              "Shared point Old Town at X: 5, Y: 25",
              "Unshared point Farmers Market at X: 10, Y: 20",
              "Unshared point Shoemakers Street at X: 20, Y: 20",
              "Unshared point Crooked Street at X: 15, Y: 20"
            };

            CollectionAssert.AreEquivalent(expectedResult, result, 
                $"For ROUTE1 {EnumerableToString(route1.RoutePoints)} and ROUTE2 " +
                $"{EnumerableToString(route2.RoutePoints)} the RESULT shall be " +
                $"{EnumerableToString(expectedResult)}, BUT IT WAS " +
                $"{EnumerableToString(result)}");
        }

        public void EmptyTest()
        {
            var route1 = new Route(new RoutePoint[]
                {
                });
            var route2 = new Route(new RoutePoint[]
                {
                });
            var result = IntersectExcept.GetRoutesInfo(route1, route2);
            var expectedResult = new string[]
            {
            };

            CollectionAssert.AreEquivalent(expectedResult, result, 
                $"For empty route1 and empty route2  the result shall be empty," +
                $" but it was {EnumerableToString(result)}");
        }

        public void EmptyTest_Refactored()
        {
            var route1 = new Route(new RoutePoint[]
                {
                });
            var route2 = new Route(new RoutePoint[]
                {
                });
            var result = IntersectExcept.GetRoutesInfo_Refactored(route1, route2);
            var expectedResult = new string[]
            {
            };

            CollectionAssert.AreEquivalent(expectedResult, result, 
                $"For empty route1 and empty route2 the result shall be empty, " +
                $"but it was {EnumerableToString(result)}");
        }
    }
}
