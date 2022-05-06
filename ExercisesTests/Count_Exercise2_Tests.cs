using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class Count_Exercise2_Tests
    {
        [Test]
        public void MoreEvenThanOdd()
        {
            var numbers = new[] { 2, 3, 4, 5, 6 };
            var numbersAsString = string.Join(", ", numbers);
            var result = Count.AreThereFewerOddThanEvenNumbers(numbers);
            Assert.True(result, $"The test failed for numbers {numbersAsString}. " +
                $"The method result was False, but it should be True");
        }

        [Test]
        public void MoreOddThanEven()
        {
            var numbers = new[] { 3, 4, 5 };
            var numbersAsString = string.Join(", ", numbers);
            var result = Count.AreThereFewerOddThanEvenNumbers(numbers);
            Assert.False(result, $"The test failed for numbers {numbersAsString}. " +
                $"The method result was True, but it should be False");
        }

        [Test]
        public void TheSameCount()
        {
            var numbers = new[] { 2, 3, 4, 5 };
            var numbersAsString = string.Join(", ", numbers);
            var result = Count.AreThereFewerOddThanEvenNumbers(numbers);
            Assert.False(result, $"The test failed for numbers {numbersAsString}. " +
                $"The method result was True, but it should be False");
        }
    }
}
