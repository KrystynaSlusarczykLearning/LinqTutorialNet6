using Exercises;
using NUnit.Framework;
using System.Linq;
using Pet = Exercises.MinMax.Pet;
using PetType = Exercises.MinMax.PetType;
using Person = Exercises.MinMax.Person;
using System.Collections.Generic;

namespace ExercisesTests
{
    [TestFixture]
    public class MinMax_RefactoringChallenge_Tests
    {
        [Test]
        public void MaxIs2_Refactored()
        {
            var Pets =
            new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f),
                new Pet(4, "Taiga", PetType.Dog, 35f),
                new Pet(5, "Rex", PetType.Dog, 40f)
            };

            var owners = new List<Person>
            {
             new Person(1, "John", new [] {
                   Pets.ElementAt(0),
                   Pets.ElementAt(1),
                   Pets.ElementAt(2)
               }),
               new Person(2, "Jack", new [] {
                   Pets.ElementAt(2)
               }),
               new Person(3, "Stephanie", new [] {
                   Pets.ElementAt(3),
                   Pets.ElementAt(4)
               })
            };

            var petsData = string.Join(" --- ", owners.Select(o => $"OWNER: {o.Name}, PETS: {string.Join(",", o.Pets)}"));

            var result = MinMax.CountOfDogsOfTheOwnerWithMostDogs_Refactored(owners);
            var message = $"The test failed, because Stephanie owns 2 dogs, and the result was {result}. Owners and pets data: {petsData}";
            Assert.AreEqual(2, result, message);
        }

        [Test]
        public void MaxIs2()
        {
            var Pets =
            new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f),
                new Pet(4, "Taiga", PetType.Dog, 35f),
                new Pet(5, "Rex", PetType.Dog, 40f)
            };

            var owners = new List<Person>
            {
             new Person(1, "John", new [] {
                   Pets.ElementAt(0),
                   Pets.ElementAt(1),
                   Pets.ElementAt(2)
               }),
               new Person(2, "Jack", new [] {
                   Pets.ElementAt(2)
               }),
               new Person(3, "Stephanie", new [] {
                   Pets.ElementAt(3),
                   Pets.ElementAt(4)
               })
            };

            var petsData = string.Join(" --- ", owners.Select(o => $"OWNER: {o.Name}, PETS: {string.Join(",", o.Pets)}"));

            var result = MinMax.CountOfDogsOfTheOwnerWithMostDogs(owners);
            var message = $"The test failed, because Stephanie owns 2 dogs, and the result was {result}. Owners and pets data: {petsData}";
            Assert.AreEqual(2, result, message);
        }

        [Test]
        public void EmptyCollection()
        {

            var owners = new List<Person>
            {
            };

            var result = MinMax.CountOfDogsOfTheOwnerWithMostDogs(owners);
            var message = $"The test failed, because the owners list is empty, and the result should be 0, but it was {result}.";
            Assert.AreEqual(0, result, message);
        }
    }
}
