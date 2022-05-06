using Exercises;
using NUnit.Framework;
using System.Collections.Generic;
using static ExercisesTests.Utilities.TestUtilities;
using Pet = Exercises.Any.Pet;
using PetType = Exercises.Any.PetType;

namespace ExercisesTests
{
    [TestFixture]
    public class Any_Exercise2_Tests
    {
        [Test]
        public void WithNoCats()
        {
            IEnumerable<Pet> pets = new[]
            {
                new Pet(5, "Rex", PetType.Dog, 40f),
                new Pet(6, "Lucky", PetType.Dog, 5f)
            };

            Assert.False(
                Any.AreThereAnyBigCats(pets),
                $"AreThereAnyBigCats should return False for Pets: " +
                $"{EnumerableToString(pets, ";")}, as there is no Pet of type Cat" +
                $" and Weight over 2 kilos in this collection");
        }

        [Test]
        public void WithNoBigCats()
        {
            IEnumerable<Pet> pets = new[]
            {
                new Pet(6, "Lucky", PetType.Dog, 5f),
                new Pet(7, "Paws", PetType.Cat, 1f)
            };

            Assert.False(
                Any.AreThereAnyBigCats(pets),
                $"AreThereAnyBigCats should return False for Pets: " +
                $"{EnumerableToString(pets, ";")}, as there is no Pet of type Cat " +
                $"and Weight over 2 kilos in this collection");
        }

        [Test]
        public void WithBigCats()
        {
            IEnumerable<Pet> pets = new[]
            {
                new Pet(6, "Lucky", PetType.Dog, 5f),
                new Pet(7, "Paws", PetType.Cat, 1f),
                new Pet(8, "Big Foot", PetType.Cat, 2.1f)
            };

            Assert.True(
                Any.AreThereAnyBigCats(pets),
                $"AreThereAnyBigCats should return True for Pets: " +
                $"{EnumerableToString(pets, ";")}, as Big Foot is a Cat " +
                $"and it weighs over 2 kilos");
        }
    }
}
