using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using Point = Exercises.OrderByQuerySyntax.Point;

namespace ExercisesTests
{
    [TestFixture]
    public class OrderBy_QuerySyntax_Exercise2_Tests
    {
        [Test]
        public void OrderPointsShallWorkCorrectly1()
        {
            var points = new[]
            {
              new Point(10, 7),
              new Point(10, 5) ,
              new Point(10, 6),
              new Point(7, 6) ,
              new Point(11, 5)
            };

            var expectedResult = new[]
            {
              new Point(7, 6) ,
              new Point(10, 5) ,
              new Point(10, 6),

              new Point(10, 7),
              new Point(11, 5)
            };

            var result = OrderByQuerySyntax.OrderPoints(points);

            CollectionAssert.AreEqual(expectedResult, result, $"For input " +
                $"{EnumerableToString(points)} the result shall be " +
                $"{EnumerableToString(expectedResult)} but it was " +
                $"'{EnumerableToString(result)}'");
        }

        [Test]
        public void OrderPointsShallWorkCorrectly2()
        {
            var points = new[]
            {
              new Point(10, 7),
              new Point(6, 5) ,
              new Point(2, 6),
            };

            var expectedResult = new[]
            {
              new Point(2, 6) ,
              new Point(6, 5) ,
              new Point(10, 7),
            };

            var result = OrderByQuerySyntax.OrderPoints(points);

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For input {EnumerableToString(points)} the result shall be " +
                $"{EnumerableToString(expectedResult)} but it was " +
                $"'{EnumerableToString(result)}'");
        }
    }
}
