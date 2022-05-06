using Exercises;
using NUnit.Framework;
using System.Collections.Generic;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class GeneratingNewCollection_Exercise1_Tests
    {
        [Test]
        public void ShallGet5EvesStartingOn1900Correctly()
        {
            var result = GeneratingNewCollection.NewYearsEvesSince(1900, 5);
            var expectedResult = new Dictionary<int, string>
            {
                [1900] = "Monday",
                [1901] = "Tuesday",
                [1902] = "Wednesday",
                [1903] = "Thursday",
                [1904] = "Saturday"
            };

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For initial year 1900 and 5 years in total, " +
                $"the days of week of the New Year's Eve were " +
                $"({DictionaryToString(expectedResult)}) but the result is " +
                $"({DictionaryToString(result)})");
        }
    }
}
