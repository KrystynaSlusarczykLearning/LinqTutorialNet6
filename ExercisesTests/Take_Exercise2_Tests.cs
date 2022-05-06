using NUnit.Framework;
using Pet = Exercises.Take.Pet;
using Exercises;

namespace ExercisesTests
{
    [TestFixture]
    public class Take_Exercise2_Tests
    {
        [Test]
        public void FiftyPercent_ShallReturnHalfOfAllPets()
        {
            var pets =
            new[]
            {
                new Pet("Hannibal",  1.1f),
                new Pet("Anthony",  2f),
                new Pet("Ed",  0.7f),
                new Pet("Taiga", 35f),
                new Pet("Rex",  40f),
                new Pet("Lucky",  5f)
            };

            var result = Take.GetGivenPercentOfHeaviestPets(pets, 50);
            var expectedResult = new[] { pets[3], pets[4], pets[5] };
            CollectionAssert.AreEquivalent(expectedResult, result);
        }

        public void TwentyPercent_ShallReturnOneOfSixPets()
        {
            var pets =
            new[]
            {
                new Pet("Hannibal",  1.1f),
                new Pet("Anthony",  2f),
                new Pet("Ed",  0.7f),
                new Pet("Taiga", 35f),
                new Pet("Rex",  40f),
                new Pet("Lucky",  5f)
            };

            var result = Take.GetGivenPercentOfHeaviestPets(pets, 20);
            var expectedResult = new[] { pets[3] };
            CollectionAssert.AreEquivalent(expectedResult, result);
        }

        public void ThirtyPercent_ShallReturnOneOfFourPets()
        {
            var pets =
            new[]
            {
                new Pet("Hannibal",  50f),
                new Pet("Anthony",  5f),
                new Pet("Ed",  6f),
                new Pet("Taiga", 25f)
            };

            var result = Take.GetGivenPercentOfHeaviestPets(pets, 30);
            var expectedResult = new[] { pets[0] };
            CollectionAssert.AreEquivalent(expectedResult, result);
        }
    }
}
