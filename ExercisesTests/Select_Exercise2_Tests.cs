using NUnit.Framework;
using Exercises;
using Person = Exercises.Select.Person;
using System;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class Select_Exercise2_Tests
    {
        [Test]
        public void ShallParsePeopleDataCorrectly()
        {
            var input = "John Smith, 1983/08/21;Jane Doe, 1993/12/21;Francis Brown, invalid date here";

            var result = Select.PeopleFromString(input);

            var expectedResult = new[]
            {
              new Person {FirstName = "John", LastName = "Smith", DateOfBirth = new DateTime(1983, 8, 21)},
              new Person {FirstName = "Jane", LastName = "Doe", DateOfBirth = new DateTime(1993, 12, 21)}
            };

            CollectionAssert.AreEqual(expectedResult, result, $"For input \"{input}\" " +
                $"the result shall be {EnumerableToString(expectedResult)} but it was " +
                $"{EnumerableToString(result)}");
        }
    }
}
