using Exercises;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ExercisesTests
{
    [TestFixture]
    public class OrderBy_RefactoringChallenge_Tests
    {
        [Test]
        public void OrderByMonth()
        {
            var dates = new List<DateTime>
            {
                new DateTime(2021, 4, 10),
                new DateTime(2020, 2, 8),
                new DateTime(2023, 6, 12),
                new DateTime(2025, 1, 16)
            };

            var expected = new List<DateTime>
            {
                new DateTime(2025, 1, 16),
                new DateTime(2020, 2, 8),
                new DateTime(2021, 4, 10),
                new DateTime(2023, 6, 12),
            };

            var result = OrderBy.OrderByMonth(dates);
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void OrderByMonth_Refactored()
        {
            var dates = new List<DateTime>
            {
                new DateTime(2021, 4, 10),
                new DateTime(2020, 2, 8),
                new DateTime(2023, 6, 12),
                new DateTime(2025, 1, 16)
            };

            var expected = new List<DateTime>
            {
                new DateTime(2025, 1, 16),
                new DateTime(2020, 2, 8),
                new DateTime(2021, 4, 10),
                new DateTime(2023, 6, 12),
            };

            var result = OrderBy.OrderByMonth_Refactored(dates);
            CollectionAssert.AreEqual(expected, result);
            Assert.AreEqual(4, dates[0].Month, "Do not modify the input collection");
        }
    }
}
