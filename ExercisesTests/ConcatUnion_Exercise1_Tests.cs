using Exercises;
using NUnit.Framework;
using System;
using News = Exercises.ConcatUnion.News;
using Priority = Exercises.ConcatUnion.Priority;

namespace ExercisesTests
{
    [TestFixture]
    public class ConcatUnion_Exercise1_Tests
    {
        [Test]
        public void ShallSelectNewsProperly()
        {
            var news = new[]
            {
              new News{ PublishingDate = new DateTime(2021, 10, 3), Priority = Priority.Medium} ,
              new News{ PublishingDate = new DateTime(2021, 10, 2), Priority = Priority.High} ,
              new News{ PublishingDate = new DateTime(2021, 10, 1), Priority = Priority.Low} ,

              new News{ PublishingDate = new DateTime(2021, 10, 6), Priority = Priority.High} ,
              new News{ PublishingDate = new DateTime(2021, 10, 5), Priority = Priority.Low} ,
              new News{ PublishingDate = new DateTime(2021, 10, 4), Priority = Priority.Medium} ,
            };

            var expectedResult = new[]
            {
               new News{ PublishingDate = new DateTime(2021, 10, 6), Priority = Priority.High} ,
               new News{ PublishingDate = new DateTime(2021, 10, 5), Priority = Priority.Low} ,
               new News{ PublishingDate = new DateTime(2021, 10, 4), Priority = Priority.Medium} ,
               new News{ PublishingDate = new DateTime(2021, 10, 2), Priority = Priority.High} ,
            };

            var result = ConcatUnion.SelectRecentAndImportant(news);

            var inputToString = string.Join(", ", news);
            var expectedResultToString = string.Join(", ", expectedResult);
            var resultToString = string.Join(", ", result);
            CollectionAssert.AreEqual(expectedResult, result, $"(See the exercise description for the input data) For input collection ({inputToString}) the result shall be ({expectedResultToString}) but it is ({resultToString})");
        }
    }
}
