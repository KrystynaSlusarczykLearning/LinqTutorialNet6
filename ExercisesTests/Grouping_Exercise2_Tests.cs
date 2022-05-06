using Exercises;
using NUnit.Framework;
using System;
using static ExercisesTests.Utilities.TestUtilities;
using Pet = Exercises.Grouping.Pet;
using PetType = Exercises.Grouping.PetType;

namespace ExercisesTests
{
    [TestFixture]
    public class Grouping_Exercise2_Tests
    {
        [Test]
        public void HeaviestPetTypeIsDog()
        {
            var pets =
            new[]
            {
                new Pet("Hannibal", PetType.Fish, 1.1f),
                new Pet("Anthony", PetType.Cat, 2f),
                new Pet("Ed", PetType.Cat, 0.7f),
                new Pet("Taiga", PetType.Dog, 35f),
                new Pet("Rex", PetType.Dog, 40f)
            };

            var result = Grouping.FindTheHeaviestPetType(pets);
            var expectedResult = PetType.Dog;

            Assert.AreEqual(expectedResult, result, $"For pets {EnumerableToString(pets)} the result shall be {expectedResult} but it was {result}");
        }

        [Test]
        public void HeaviestPetTypeIsCat()
        {
            var pets =
            new[]
            {
                new Pet("Shere Khan", PetType.Cat, 250f),
                new Pet("Alex", PetType.Cat, 200f),
                new Pet("Taiga", PetType.Dog, 35f),
                new Pet("Rex", PetType.Dog, 40f),
                new Pet("Lucky", PetType.Dog, 5f),
                new Pet("Bruce", PetType.Fish, 210f),
            };

            var result = Grouping.FindTheHeaviestPetType(pets);
            var expectedResult = PetType.Cat;

            Assert.AreEqual(expectedResult, result, $"For pets {EnumerableToString(pets)} the result shall be {expectedResult} but it was {result}");
        }

        [Test]
        public void EmptyPets()
        {
            try
            {
                var pets =
                new Pet[]
                {
                };

                var result = Grouping.FindTheHeaviestPetType(pets);
                PetType? expectedResult = null;

                Assert.AreEqual(expectedResult, result, $"For empty pets collection the result shall be null but it was {result}");
            }
            catch (Exception ex)
            {
                Assert.Fail($"The result shall be null for an empty input, but an expection was thrown. Exception message: {ex.Message}. (Did you possibly call the First or the Last methods on an empty collection?)");
            }
        }
    }
}
