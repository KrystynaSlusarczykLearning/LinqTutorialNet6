using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using System;
using System.Collections.Generic;

namespace ExercisesTests
{
    [TestFixture]
    public class GroupBy_QuerySyntax_Exercise2_Tests
    {
        [Test]
        public void GroupByDayOfWeekShallWorkCorrectly1()
        {
            var input = new[] {
                new DateTime(2021, 10, 10),
                new DateTime(2021, 10, 17),
                new DateTime(2021, 10, 11),
                new DateTime(2021, 10, 4),
                new DateTime(2021, 10, 13),
            };
            var result = GroupByQuerySyntax.GroupByDayOfWeek(input);
            var expectedResult = new Dictionary<DayOfWeek, DateTime>
            {
                [DayOfWeek.Sunday] = new DateTime(2021, 10, 17),
                [DayOfWeek.Monday] = new DateTime(2021, 10, 11),
                [DayOfWeek.Wednesday] = new DateTime(2021, 10, 13)
            };

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(input)} the RESULT shall be {DictionaryToString(expectedResult)} but it was {DictionaryToString(result)}");
        }

        [Test]
        public void GroupByDayOfWeekShallWorkCorrectly2()
        {
            var input = new[] {
                new DateTime(2021, 10, 10),
                new DateTime(2021, 10, 17),
                new DateTime(2021, 10, 24),
                new DateTime(2021, 10, 4),
                new DateTime(2021, 10, 13),
            };
            var result = GroupByQuerySyntax.GroupByDayOfWeek(input);
            var expectedResult = new Dictionary<DayOfWeek, DateTime>
            {
                [DayOfWeek.Sunday] = new DateTime(2021, 10, 24),
                [DayOfWeek.Monday] = new DateTime(2021, 10, 4),
                [DayOfWeek.Wednesday] = new DateTime(2021, 10, 13)
            };

            CollectionAssert.AreEqual(expectedResult, result, $"For INPUT {EnumerableToString(input)} the RESULT shall be {DictionaryToString(expectedResult)} but it was {DictionaryToString(result)}");
        }
    }
}
