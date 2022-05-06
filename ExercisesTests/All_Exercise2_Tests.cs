using Exercises;
using NUnit.Framework;
using System.Collections.Generic;
using static ExercisesTests.Utilities.TestUtilities;
using Pet = Exercises.All.Pet;
using PetType = Exercises.All.PetType;

namespace ExercisesTests
{
    [TestFixture]
    public class All_Exercise2_Tests
    {
        [Test]
        public void AllAreOfTheSameType()
        {
            IEnumerable<Pet> pets = new[]
            {
                new Pet(4, "Taiga", PetType.Dog, 35f),
                new Pet(5, "Rex", PetType.Dog, 40f),
                new Pet(6, "Lucky", PetType.Dog, 5f)
            };

            Assert.True(All.AreAllPetsOfTheSameType(pets),
                $"The test failed because the result of " +
                $"the AreAllPetsOfTheSameType was False, " +
                $"and all those pets are of the same type: {EnumerableToString(pets)}");
        }

        [Test]
        public void AreOfDifferentTypes()
        {
            IEnumerable<Pet> pets = new[]
            {
                new Pet(3, "Ed", PetType.Cat, 0.7f),
                new Pet(4, "Taiga", PetType.Dog, 35f),
                new Pet(5, "Rex", PetType.Dog, 40f)
            };

            Assert.False(All.AreAllPetsOfTheSameType(pets),
                $"The test failed because the result of " +
                $"the AreAllPetsOfTheSameType was True, " +
                $"and those pets are not of the same type: {EnumerableToString(pets)}");
        }
    }
}
