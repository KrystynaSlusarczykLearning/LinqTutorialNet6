using NUnit.Framework;
using Pet = Exercises.Where.Pet;
using Person = Exercises.Where.Person;
using PetType = Exercises.Where.PetType;
using System.Linq;
using Exercises;

namespace ExercisesTests
{
    [TestFixture]
    public class Where_RefactoringChallenge_Tests
    {

        [Test]
        public void GetMultipleFishOwnersShallWorkCorrectly()
        {
            var pets = new[]
             {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Fish, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f),
                new Pet(3, "Eddie", PetType.Dog, 0.7f)
            };

            var people =
            new[]
            {
               new Person(1, "John", new [] {
                   pets.ElementAt(0),
                   pets.ElementAt(1),
               }),
               new Person(2, "Jack", new [] {
                   pets.ElementAt(0),
                   pets.ElementAt(1),
                   pets.ElementAt(2),

               }),
               new Person(3, "Stephanie", new [] {
                   pets.ElementAt(1),
                   pets.ElementAt(3),
               })
            };

            var result = Where.GetMultipleFishOwners(people);
            var expectedResult = new[] { people[0], people[1] };
            CollectionAssert.AreEqual(expectedResult, result, $"Expected count of items: {expectedResult.Count()}, result count of items: {result.Count()}. Both John and Jack own multiple fish (John owns 2 fish, Jack owns 2 fish and a cat, Stephanie owns 1 fish and a dog)");
        }

        [Test]
        public void GetMultipleFishOwners_RefactoredShallWorkCorrectly()
        {
            var pets = new[]
             {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Fish, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f),
                new Pet(3, "Eddie", PetType.Dog, 0.7f)
            };

            var people =
            new[]
            {
               new Person(1, "John", new [] {
                   pets.ElementAt(0),
                   pets.ElementAt(1),
               }),
               new Person(2, "Jack", new [] {
                   pets.ElementAt(0),
                   pets.ElementAt(1),
                   pets.ElementAt(2)
               }),
               new Person(3, "Stephanie", new [] {
                   pets.ElementAt(1),
                   pets.ElementAt(3),
               })
            };

            var result = Where.GetMultipleFishOwners_Refactored(people);
            var expectedResult = new[] { people[0], people[1] };
            CollectionAssert.AreEqual(expectedResult, result, $"Expected count of items: {expectedResult.Count()}, result count of items: {result.Count()}. Both John and Jack own multiple fish (John owns 2 fish, Jack owns 2 fish and a cat, Stephanie owns 1 fish and a dog)");
        }
    }
}
