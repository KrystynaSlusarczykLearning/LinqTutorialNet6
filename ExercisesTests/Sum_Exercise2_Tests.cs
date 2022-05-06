using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace ExercisesTests
{
    [TestFixture]
    public class Sum_Exercise2_Tests
    {
        [Test]
        public void AverageSumShallWorkCorrectly()
        {
            var input = new List<List<int>>
           {
               new List<int> {1,2,3,2},
               new List<int> {1,5,6},
               new List<int> {2,2},
           };
            var result = Sum.AverageSum(input);
            var expectedResult = 8;
            Assert.AreEqual(expectedResult, result, 
                $"For INPUT ((1,2,3,2),(1,5,6),(2,2)) the RESULT shall be " +
                $"{expectedResult} but IT WAS {result}");
        }
    }
}
