using NUnit.Framework;
using System;
using Single = Exercises.Single;

namespace ExercisesTests
{
    [TestFixture]
    public class Single_RefactoringChallenge_Tests
    {
        [Test]
        public void IsSingleThursday()
        {
            var days = new[]
            {
                new DateTime(2021, 9, 30),//thursday
                new DateTime(2021, 9, 29), //wednesday
            };
            var asString = string.Join(", ", days);
            var result = Single.GetSingleDay(days, DayOfWeek.Thursday);
            Assert.AreEqual(days[0], result, $"Days {asString} do contain a single Thursday");
        }

        [Test]
        public void AreMoreThanOneThursdays()
        {
            var days = new[]
            {
                new DateTime(2021, 9, 23),//thursday
                new DateTime(2021, 9, 30),//thursday
                new DateTime(2021, 9, 29), //wednesday
            };
            var asString = string.Join(", ", days);
            var result = Single.GetSingleDay(days, DayOfWeek.Thursday);
            Assert.AreEqual(null, result, $"Days {asString} contain two Thursdays, so null should be returned");
        }

        [Test]
        public void IsZeroThursdays()
        {
            var days = new[]
            {
                new DateTime(2021, 9, 24),//friday
                new DateTime(2021, 9, 29), //wednesday
            };
            var asString = string.Join(", ", days);
            var result = Single.GetSingleDay(days, DayOfWeek.Thursday);
            Assert.AreEqual(null, result, $"Days {asString} contain no Thursdays, so null should be returned");
        }

        [Test]
        public void IsSingleThursday_Refactored()
        {
            var days = new[]
            {
                new DateTime(2021, 9, 30),//thursday
                new DateTime(2021, 9, 29), //wednesday
            };
            var asString = string.Join(", ", days);
            var result = Single.GetSingleDay_Refactored(days, DayOfWeek.Thursday);
            Assert.AreEqual(days[0], result, $"Days {asString} do contain a single Thursday");
        }

        [Test]
        public void AreMoreThanOneThursdays_Refactored()
        {
            var days = new[]
            {
                new DateTime(2021, 9, 23),//thursday
                new DateTime(2021, 9, 30),//thursday
                new DateTime(2021, 9, 29), //wednesday
            };
            var asString = string.Join(", ", days);
            var result = Single.GetSingleDay_Refactored(days, DayOfWeek.Thursday);
            Assert.AreEqual(null, result, $"Days {asString} contain two Thursdays, so null should be returned");
        }

        [Test]
        public void IsZeroThursdays_Refactored()
        {
            var days = new[]
            {
                new DateTime(2021, 9, 24),//friday
                new DateTime(2021, 9, 29), //wednesday
            };
            var asString = string.Join(", ", days);
            var result = Single.GetSingleDay_Refactored(days, DayOfWeek.Thursday);
            Assert.AreEqual(null, result, $"Days {asString} contain no Thursdays, so null should be returned");
        }
    }
}
