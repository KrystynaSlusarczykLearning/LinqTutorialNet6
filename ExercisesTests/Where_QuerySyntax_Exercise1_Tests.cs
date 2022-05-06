using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Exercises;
using System;
using System.Collections.Generic;
using Person = Exercises.WhereQuerySyntax.Person;

namespace ExercisesTests
{
    [TestFixture]
    public class Where_QuerySyntax_Exercise1_Tests
    {
        [Test]
        public void GetBornAfter1952ShallGetOnlyBornAfter1950()
        {
            var people = new List<Person>
            {
                new Person("Geraldine Smith", new DateTime(1920, 12, 2) ),
                new Person("John Smith", new DateTime(1950, 4, 8)) ,
                new Person("Monica Smith", new DateTime(1954,11, 3)) ,
                new Person("Jake Smith", new DateTime(1982, 8, 3) )
            };

            var expectedResult = new List<Person>
            {
                new Person("Monica Smith", new DateTime(1954, 11, 3) ),
                new Person("Jake Smith", new DateTime(1982, 8, 3) )
            };

            var result = WhereQuerySyntax.GetBornAfter(1950, people);

            CollectionAssert.AreEqual(expectedResult, result, $"For input {EnumerableToString(people)} the result shall be {EnumerableToString(expectedResult)} but it was '{EnumerableToString(result)}'");
        }

        [Test]
        public void GetBornAfter1980ShallGetOnlyBornAfter1980()
        {
            var people = new List<Person>
            {
                new Person("Geraldine Smith", new DateTime(1920, 12, 2) ),
                new Person("John Smith", new DateTime(1950, 4, 8)) ,
                new Person("Monica Smith", new DateTime(1954,11, 3)) ,
                new Person("Jake Smith", new DateTime(1982, 8, 3) )
            };

            var expectedResult = new List<Person>
            {
                new Person("Jake Smith", new DateTime(1982, 8, 3) )
            };

            var result = WhereQuerySyntax.GetBornAfter(1980, people);

            CollectionAssert.AreEqual(expectedResult, result, $"For input {EnumerableToString(people)} the result shall be {EnumerableToString(expectedResult)} but it was '{EnumerableToString(result)}'");
        }
    }
}
