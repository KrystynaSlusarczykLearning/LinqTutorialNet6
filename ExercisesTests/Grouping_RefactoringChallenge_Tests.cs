using NUnit.Framework;
using Exercises;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class Grouping_RefactoringChallenge_Tests
    {
        [Test]
        public void ShallCountPetsCorrectlyForNonEmptyInput()
        {
            var input = "Dog,Cat,Fish,Dog,Dog,Fish,Cat,Cat,Dog,Ferret,Dog";
            var result = Grouping.CountPets(input);
            var expectedResult = new[] { "Dog:5", "Cat:3", "Fish:2", "Ferret:1" };

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For INPUT '{input}' the RESULT shall be " +
                $"{EnumerableToString(expectedResult)} BUT IT WAS " +
                $"{EnumerableToString(result)}");
        }

        [Test]
        public void EmptyInput()
        {
            var input = "";
            var result = Grouping.CountPets(input);
            var expectedResult = new string[0];

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For an EMPTY INPUT the RESULT shall be " +
                $"{EnumerableToString(expectedResult)} BUT IT WAS " +
                $"{EnumerableToString(result)}");
        }

        [Test]
        public void ShallCountPetsCorrectlyForNonEmptyInput_Refactored()
        {
            var input = "Dog,Cat,Fish,Dog,Dog,Fish,Cat,Cat,Dog,Ferret,Dog";
            var result = Grouping.CountPets_Refactored(input);
            var expectedResult = new[] { "Dog:5", "Cat:3", "Fish:2", "Ferret:1" };

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For INPUT '{input}' the RESULT shall be " +
                $"{EnumerableToString(expectedResult)} BUT IT WAS " +
                $"{EnumerableToString(result)}");
        }

        [Test]
        public void EmptyInput_Refactored()
        {
            var input = "";
            var result = Grouping.CountPets_Refactored(input);
            var expectedResult = new string[0];

            CollectionAssert.AreEqual(expectedResult, result, 
                $"For an EMPTY INPUT the RESULT shall be " +
                $"{EnumerableToString(expectedResult)} BUT IT WAS " +
                $"{EnumerableToString(result)}");
        }
    }
}
