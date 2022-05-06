using NUnit.Framework;
using System;
using Exercises;
using System.Linq;

namespace ExercisesTests
{
    [TestFixture]
    public class Take_RefactoringChallenge_Tests
    {
        [Test]
        public void GetDatesBeforeXXCentury_ShallWorkCorrectly()
        {
            var dates = new[]
            {
              new DateTime(1741, 1, 1),
              new DateTime(1899, 1, 1),
              new DateTime(1900, 1, 1),
              new DateTime(1901, 1, 1),
              new DateTime(1451, 1, 1)
            };

            var expectedResult = new[]
            {
              new DateTime(1741, 1, 1),
              new DateTime(1899, 1, 1),
              new DateTime(1900, 1, 1)
            };

            var result = Take.GetDatesBeforeXXCentury(dates);
            var datesAsString = string.Join(", ", dates.Select(d => d.ToString("dd/MM/yyyy")));
            var expectedResultAsString = string.Join(", ", expectedResult.Select(d => d.ToString("dd/MM/yyyy")));
            var resultAsString = string.Join(", ", result.Select(d => d.ToString("dd/MM/yyyy")));
            CollectionAssert.AreEqual(expectedResult, result, $"Input dates: ({datesAsString}), expected result: ({expectedResultAsString}), actual result: ({resultAsString})");
        }

        [Test]
        public void GetDatesBeforeXXCentury_Refactored_ShallWorkCorrectly()
        {
            var dates = new[]
            {
              new DateTime(1741, 1, 1),
              new DateTime(1899, 1, 1),
              new DateTime(1900, 1, 1),
              new DateTime(1901, 1, 1),
              new DateTime(1451, 1, 1)
            };

            var expectedResult = new[]
            {
              new DateTime(1741, 1, 1),
              new DateTime(1899, 1, 1),
              new DateTime(1900, 1, 1)
            };

            var result = Take.GetDatesBeforeXXCentury_Refactored(dates);
            var datesAsString = string.Join(", ", dates.Select(d => d.ToString("dd/MM/yyyy")));
            var expectedResultAsString = string.Join(", ", expectedResult.Select(d => d.ToString("dd/MM/yyyy")));
            var resultAsString = string.Join(", ", result.Select(d => d.ToString("dd/MM/yyyy")));
            CollectionAssert.AreEqual(expectedResult, result, $"Input dates: ({datesAsString}), expected result: ({expectedResultAsString}), actual result: ({resultAsString})");
        }
    }
}
