using Exercises;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Person = Exercises.FirstLast.Person;

namespace ExercisesTests
{
    [TestFixture]
    public class FirstLast_Exercise2_Tests
    {
        [TestFixture]
        public class FirstTestSuite
        {
            [Test]
            public void ShallFindYoungest_InNonEmptyCollection()
            {
                var people = new List<Person>
            {
              new Person ("John", new DateTime(1986, 3, 4)),
              new Person ("Stephanie", new DateTime(1990, 12, 4)),
              new Person ("Mark", new DateTime(1957, 1, 2))
            };
                var peopleAsString = string.Join(", ", people);
                var result = FirstLast.GetYoungest(people);
                Assert.AreEqual(people[1], result, $"The test failed, because the youngest person in ({peopleAsString}) collection is Stephanie, and the result is {result}");
            }

            [Test]
            public void EmptyCollection()
            {
                var people = new List<Person>
                {
                };
                var result = FirstLast.GetYoungest(people);
                Assert.AreEqual(null, result, "For empty collection the result should be null");
            }
        }
    }
}
