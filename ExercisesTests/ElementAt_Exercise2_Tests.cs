using Exercises;
using NUnit.Framework;
using System.Collections.Generic;
using Pet = Exercises.ElementAt.Pet;

namespace ExercisesTests
{
    [TestFixture]
    public class ElementAt_Exercise2_Tests
    {
        [Test]
        public void NoSuchPet()
        {
            var pets = new List<Pet>();
            var result = ElementAt.FormatPetDataAtIndex(pets, 0);
            Assert.AreEqual("Pet data is missing for index 0", result, "$For an empty collection and index 0, the result should be 'Pet data is missing for index 0'");
        }

        [Test]
        public void PetIsPresent()
        {
            var pets = new List<Pet>
            {
                new Pet {Name = "Hannibal"}
            };
            var result = ElementAt.FormatPetDataAtIndex(pets, 0);
            Assert.AreEqual("Pet name: Hannibal", result, $"For a list of one pet named 'Hannibal' and for index 0, the result should be 'Pet name: Hannibal'");
        }

        [Test]
        public void PetIsPresentButNull()
        {
            var pets = new List<Pet>
            {
                null
            };
            var result = ElementAt.FormatPetDataAtIndex(pets, 0);
            Assert.AreEqual("Pet data is missing for index 0", result, $"For a list of one pet named of null value and for index 0, the result should be 'Pet data is missing for index 0'");
        }
    }
}
