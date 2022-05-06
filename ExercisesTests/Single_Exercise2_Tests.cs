using NUnit.Framework;
using System;
using System.Collections.Generic;
using Single = Exercises.Single;

namespace ExercisesTests
{
    [TestFixture]
    public class Single_Exercise2_Tests
    {

        [Test]
        public void SingleElementCollectionIsPresent()
        {
            var input = new List<List<int>>
            {
              new List<int> {1,2,3},
              new List<int> {4},
              new List<int> {5,6}
            };
            var result = Single.GetSingleElementCollection(input);
            Assert.AreEqual(input[1], result, $"There is one single-element collection (4) in collections (1,2,3), (4), (5,6)");
        }

        [Test]
        public void MoreThanOneSingleElementCollectionIsPresent()
        {
            var input = new List<List<int>>
            {
              new List<int> {1,2,3},
              new List<int> {4},
              new List<int> {5,6},
              new List<int> {7},
            };
            Assert.Throws<InvalidOperationException>(() => Single.GetSingleElementCollection(input), $"There are more than one single-element collectiosn  in collections (1,2,3), (4), (5,6), (7). InvalidOperationException was expected, but it was not thrown.");
        }

        [Test]
        public void SingleElementCollectionIsNotPresent()
        {
            var input = new List<List<int>>
            {
              new List<int> {1,2,3},
              new List<int> {5,6}
            };
            Assert.Throws<InvalidOperationException>(() => Single.GetSingleElementCollection(input), $"There is no single-element collection  in collections (1,2,3), (5,6). InvalidOperationException was expected, but it was not thrown.");
        }
    }
}
