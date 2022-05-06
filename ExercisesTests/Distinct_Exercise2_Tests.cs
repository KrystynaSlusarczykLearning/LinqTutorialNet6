using Exercises;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ExercisesTests
{
    [TestFixture]
    public class Distinct_Exercise2_Tests
    {
        [Test]
        public void FirstTest()
        {
            var collections = new List<List<int>>
            {
              new List<int> {1,2,3,4},
              new List<int> {1,2,3,3,4,4,4},
              new List<int> {1,2,3,3,4,4,4,5,6,7},
            };

            var expectedResult = collections[1];
            var result = Distinct.GetCollectionWithMostDuplicates(collections);
            var resultAsString = string.Join(",", result);
            CollectionAssert.AreEqual(expectedResult, result, $"For input collections (1,2,3,4), (1,2,3,3,4,4,4), (1,2,3,3,4,4,4,5,6,7) the result collection shall be (1,2,3,3,4,4,4), but it was ({resultAsString})");
        }

        [Test]
        public void SecondTest()
        {
            var collections = new List<List<int>>
            {
              new List<int> {1,2,3,3,4,4,4},
              new List<int> {1,2,3,4},
              new List<int> {1,2,3,3,4,4,4,5,6,7},
              new List<int> {1,2,3,4,4,4,5,6,7},
            };

            var expectedResult = collections[0];
            var result = Distinct.GetCollectionWithMostDuplicates(collections);

            var resultAsString = string.Join(",", result);
            CollectionAssert.AreEqual(expectedResult, result, $"For input collections (1,2,3,3,4,4,4), (1,2,3,4), (1,2,3,3,4,4,4,5,6,7), (1,2,3,4,4,4,5,6,7) the result collection shall be (1,2,3,3,4,4,4), but it was ({resultAsString})");
        }

        [Test]
        public void EmptyCollection()
        {
            try
            {
                var collections = new List<List<int>>
                {
                };

                var result = Distinct.GetCollectionWithMostDuplicates(collections);
                var resultAsString = result == null ? "null" : string.Join(",", result);
                CollectionAssert.AreEqual(null, result, $"For an empty input collection the result shall be null, but it was ({resultAsString})");
            }
            catch (InvalidOperationException ex)
            {
                Assert.Fail($"For an empty input collection the result shall be null, but an exception was thrown: {ex.Message}");
            }
        }
    }
}
