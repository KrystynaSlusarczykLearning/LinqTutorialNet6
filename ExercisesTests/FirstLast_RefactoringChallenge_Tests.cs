using Exercises;
using NUnit.Framework;
using System;
using System.Linq;
using Pet = Exercises.FirstLast.Pet;
using PetType = Exercises.FirstLast.PetType;
using Person = Exercises.FirstLast.Person;

namespace ExercisesTests
{
    [TestFixture]
    public class FirstLast_RefactoringChallenge_Tests
    {
        [Test]
        public void OwnerIsPresent()
        {
            var Pets = new[]
             {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f)
            };

            var people =
            new[]
            {
               new Person(1, "John", new [] {
                   Pets.ElementAt(0),
                   Pets.ElementAt(1),
               }),
               new Person(2, "Jack", new [] {
                   Pets.ElementAt(2)
               }),
               new Person(3, "Stephanie", new [] {
                   Pets.ElementAt(2),
               })
            };

            var result = FirstLast.FindOwnerOf(Pets.ElementAt(2), people);
            Assert.AreEqual(people[1], result, $"The first owner of the pet Ed in the collection is Jack. People collection: John owns Hannibal and Anthony, Jack owns Ed, Stephanie owns Ed");
        }

        [Test]
        public void OwnerIsPresent_Refactored()
        {
            var Pets = new[]
             {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f)
            };

            var people =
            new[]
            {
               new Person(1, "John", new [] {
                   Pets.ElementAt(0),
                   Pets.ElementAt(1),
               }),
               new Person(2, "Jack", new [] {
                   Pets.ElementAt(2)
               }),
               new Person(3, "Stephanie", new [] {
                   Pets.ElementAt(2),
               })
            };

            var result = FirstLast.FindOwnerOf_Refactored(Pets.ElementAt(2), people);
            Assert.AreEqual(people[1], result, $"The first owner of the pet Ed in the collection is Jack. People collection: John owns Hannibal and Anthony, Jack owns Ed, Stephanie owns Ed");
        }

        [Test]
        public void OwnerIsNotPresent()
        {
            var Pets = new[]
             {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f)
            };

            var people =
            new[]
            {
               new Person(1, "John", new [] {
                   Pets.ElementAt(0),
                   Pets.ElementAt(1),
               })
            };

            try
            {
                var result = FirstLast.FindOwnerOf(Pets.ElementAt(2), people);

                Assert.AreEqual(null, result, $"Pet Ed in is not owned by anyone - Ed is a free dog! People collection: John owns Hannibal and Anthony.");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Pet Ed in is not owned by anyone - Ed is a free dog! People collection: John owns Hannibal and Anthony. Exception message: {ex.Message}");
            }
        }

        [Test]
        public void OwnerIsNotPresent_Refactored()
        {
            var Pets = new[]
             {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f)
            };

            var people =
            new[]
            {
               new Person(1, "John", new [] {
                   Pets.ElementAt(0),
                   Pets.ElementAt(1),
               })
            };

            try
            {
                var result = FirstLast.FindOwnerOf_Refactored(Pets.ElementAt(2), people);

                Assert.AreEqual(null, result, $"Pet Ed in is not owned by anyone - Ed is a free dog! People collection: John owns Hannibal and Anthony.");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Pet Ed in is not owned by anyone - Ed is a free dog! People collection: John owns Hannibal and Anthony. Exception message: {ex.Message}");
            }
        }
    }
}
