using Exercises;
using NUnit.Framework;
using System.Collections.Generic;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class CollectionTypeChange_Exercise1_Tests
    {
        [Test]
        public void ParseToNumbersAndStoreInDictionaryShallWorkCorrectly()
        {
            var input = new string[] { "aaa", "1", "3", "bbb", "bbb" };
            var result = CollectionTypeChange.ParseToNumbersAndStoreInDictionary(input);
            var expectedResult = new Dictionary<string, int?>
            {
                ["aaa"] = null,
                ["1"] = 1,
                ["3"] = 3,
                ["bbb"] = null,
            };

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT " +
                $"{EnumerableToString(input)} the RESULT shall be " +
                $"{DictionaryToString(expectedResult)} BUT IT WAS " +
                $"{DictionaryToString(result)}");
        }

        [Test]
        public void ParseToNumbersAndStoreInDictionaryShallWorkCorrectlyForSingleElement()
        {
            var input = new string[] { "3", "ARR" };
            var result = CollectionTypeChange.ParseToNumbersAndStoreInDictionary(input);
            var expectedResult = new Dictionary<string, int?>
            {
                ["3"] = 3,
                ["ARR"] = null
            };

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT " +
                $"{EnumerableToString(input)} the RESULT shall be " +
                $"{DictionaryToString(expectedResult)} BUT IT WAS " +
                $"{DictionaryToString(result)}");
        }
    }
}
