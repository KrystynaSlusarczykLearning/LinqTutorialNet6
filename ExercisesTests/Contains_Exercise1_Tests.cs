using NUnit.Framework;
using System;
using System.Linq;
using Contains = Exercises.Contains;

namespace ExercisesTests
{
    [TestFixture]
    public class Contains_Exercise1_Tests
    {
        [Test]
        public void DateIsAvailable()
        {
            var date = new DateTime(2022, 1, 10);
            var dates = new[]
            {
                new DateTime(2022, 1, 11),
                new DateTime(2022, 1, 12)
            };
            var datesAsString = string.Join(", ", dates.Select(d => d.ToString("d")));
            var result = Contains.IsAppointmentDateAvailable(date, dates);
            Assert.True(result, $"The test failed because the date {date.ToString("d")} is not present amongst dates: {datesAsString}");
        }

        [Test]
        public void DateIsNotAvailable()
        {
            var date = new DateTime(2022, 1, 10);
            var dates = new[]
            {
                new DateTime(2022, 1, 10),
                new DateTime(2022, 1, 12)
            };
            var datesAsString = string.Join(", ", dates.Select(d => d.ToString("d")));
            var result = Contains.IsAppointmentDateAvailable(date, dates);
            Assert.False(result, $"The test failed because the date {date.ToString("d")} is already present amongst dates: {datesAsString}");
        }
    }
}
