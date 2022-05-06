using Exercises;
using NUnit.Framework;
using System.Collections.Generic;
using MonthlySnowFallData = Exercises.Average.MonthlySnowFallData;
using SnowFallData = Exercises.Average.SnowFallData;

namespace ExercisesTests
{
    [TestFixture]
    public class Average_Exercise1_Tests
    {
        [Test]
        public void NullSnowFallData()
        {
            var result = Average.AverageSnowFall(null);
            Assert.Null(result, $"For null SnowFallData the result should be null");
        }

        [Test]
        public void NullMonths()
        {
            var snowFallData = new SnowFallData();
            var result = Average.AverageSnowFall(snowFallData);
            Assert.Null(result, $"For null MonthlySnowFallDataItems the result should be null");
        }

        [Test]
        public void EmptyMonths()
        {
            var snowFallData = new SnowFallData()
            {
                MonthlySnowFallDataItems = new List<MonthlySnowFallData>()
            };
            var result = Average.AverageSnowFall(snowFallData);
            Assert.Null(result, $"For empty MonthkySnowFallDataItems the result should be null");
        }

        [Test]
        public void NonEmptyData()
        {
            var snowFallData = new SnowFallData()
            {
                MonthlySnowFallDataItems = new List<MonthlySnowFallData>
                {

                    new MonthlySnowFallData {SnowfallInCentimeters = 11},
                    new MonthlySnowFallData {SnowfallInCentimeters = 22},
                    new MonthlySnowFallData {SnowfallInCentimeters = 10},
                    new MonthlySnowFallData {SnowfallInCentimeters = 9},
                    new MonthlySnowFallData {SnowfallInCentimeters = 5},
                    new MonthlySnowFallData {SnowfallInCentimeters = 0},
                    new MonthlySnowFallData {SnowfallInCentimeters = 0},
                    new MonthlySnowFallData {SnowfallInCentimeters = 1},
                    new MonthlySnowFallData {SnowfallInCentimeters = 5},
                    new MonthlySnowFallData {SnowfallInCentimeters = 18},
                    new MonthlySnowFallData {SnowfallInCentimeters = 19},
                    new MonthlySnowFallData {SnowfallInCentimeters = 32},
                }
            };
            var result = Average.AverageSnowFall(snowFallData);
            Assert.AreEqual(11, result, $"For snowfall of values 11, 22, 10, 9, 5, 0, 0, 1, 5, 18, 19, 32 the average should be 11");
        }
    }
}
