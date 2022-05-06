using Exercises;
using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;

namespace ExercisesTests
{
    [TestFixture]
    public class Any_RefactoringChallenge_Tests
    {
        [Test]
        public void WithLowerCaseNames()
        {
            var names = new[] { "Bob", "martin", "Greg" };

            Assert.False(Any.AreAllNamesValid(names),
                $"Test failed for names {EnumerableToString(names)}," +
                $" because not all of them are are valid. " +
                $"\"martin\" starts with a lower case");
        }

        [Test]
        public void WithShortNames()
        {
            var names = new[] { "Bob", "M", "Greg" };

            Assert.False(Any.AreAllNamesValid(names),
                $"Test failed for names {EnumerableToString(names)}, " +
                $"because not all of them are are valid. " +
                $"\"M\" is too short");
        }

        [Test]
        public void WithLongNames()
        {
            var names = new[] { "Bob", "Martin", "Greggggggggggggggggggggggggggggggggggggggg" };
            
            Assert.False(Any.AreAllNamesValid(names),
                $"Test failed for names {EnumerableToString(names)}, " +
                $"because not all of them are are valid. " +
                $"\"Greggggggggggggggggggggggggggggggggggggggg\" is too long");
        }

        [Test]
        public void WithValidNamesOnly()
        {
            var names = new[] { "Bob", "Martin", "Greg" };
           
            Assert.True(Any.AreAllNamesValid(names),
                $"Test failed for names {EnumerableToString(names)}. " +
                $"They are all valid.");
        }

        [Test]
        public void WithLowerCaseNames_Refactored()
        {
            var names = new[] { "Bob", "martin", "Greg" };
            
            Assert.False(Any.AreAllNamesValid_Refactored(names),
                $"Test failed for names {EnumerableToString(names)}, " +
                $"because not all of them are are valid. " +
                $"\"martin\" starts with a lower case");
        }

        [Test]
        public void WithShortNames_Refactored()
        {
            var names = new[] { "Bob", "M", "Greg" };
            
            Assert.False(Any.AreAllNamesValid_Refactored(names),
                $"Test failed for names {EnumerableToString(names)}, " +
                $"because not all of them are are valid. " +
                $"\"M\" is too short");
        }

        [Test]
        public void WithLongNames_Refactored()
        {
            var names = new[] { "Bob", "Martin", "Greggggggggggggggggggggggggggggggggggggggg" };
            
            Assert.False(Any.AreAllNamesValid_Refactored(names),
                $"Test failed for names {EnumerableToString(names)}, " +
                $"because not all of them are are valid. " +
                $"\"Greggggggggggggggggggggggggggggggggggggggg\" is too long");
        }

        [Test]
        public void WithValidNamesOnly_Refactored()
        {
            var names = new[] { "Bob", "Martin", "Greg" };
            
            Assert.True(Any.AreAllNamesValid_Refactored(names),
                $"Test failed for names {EnumerableToString(names)}. " +
                $"They are all valid.");
        }
    }
}
