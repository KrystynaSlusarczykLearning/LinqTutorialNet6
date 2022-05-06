using LinqTutorial.DataTypes;
using System;
using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class IntersectExcept
    {
        //System.Linq.Enumerable.Intersect
        //System.Linq.Enumerable.Except
        //System.Linq.Enumerable.SequenceEqual
        public static void Run()
        {
            //Intersect finds the common part of two collections
            var numbers1 = new[] { 1, 2, 3, 4, 5, 6 };
            var numbers2 = new[] { 4, 5, 6, 7, 8, 9, 10 };
            var intersect = numbers1.Intersect(numbers2);
            Printer.Print(intersect, nameof(intersect));

            //Except finds all the elements from the first collection,
            //which are not present in the second collection
            var except = numbers1.Except(numbers2);
            Printer.Print(except, nameof(except));

            //remember that for Intersect and Except the default equality comparison be used
            var pets1 = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f)
            };
            var pets2 = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f)
            };

            //in this case, Intersect will produce empty collection
            //because Hannibal from pets1 is not equal to Hannibal from pets2
            //remember, they may look the same but they are two different objects
            //with two different references
            var petsIntersectDefaultEqualityCheck = pets1.Intersect(pets2);
            Printer.Print(petsIntersectDefaultEqualityCheck, nameof(petsIntersectDefaultEqualityCheck));

            //we can provide the custom equality comparer:
            var petsIntersect = pets1.Intersect(pets2, new PetEqualityByIdComparer());
            Printer.Print(petsIntersect, nameof(petsIntersect));

            //let's imagine a situation when one pet can have multiple owners
            //for example, people can donate money for given pets in an animal shelter
            //and becone their virtual "owners"
            var alice = new PetOwner(1, "Alice", new[] {
                       Data.Pets.ElementAt(0),
                       Data.Pets.ElementAt(2),
                       Data.Pets.ElementAt(3)
                   });
            var bob = new PetOwner(2, "Bob", new[] {
                       Data.Pets.ElementAt(0),
                       Data.Pets.ElementAt(1),
                       Data.Pets.ElementAt(2)
                   });

            //let's find those Pets who are "shared" between Bob and Alice
            var sharedBetweenBobAndAlice = alice.Pets.Intersect(bob.Pets, new PetEqualityByIdComparer());
            Printer.Print(sharedBetweenBobAndAlice, nameof(sharedBetweenBobAndAlice));

            //now let's find Pets owned by Bob, who are not owned by Alice
            var bobExclusivePets = bob.Pets.Except(alice.Pets, new PetEqualityByIdComparer());
            Printer.Print(bobExclusivePets, nameof(bobExclusivePets));

            //now let's find those Pets who have one owner only
            var petsWithOneOwnerOnly =
                bob.Pets.Concat(alice.Pets) //those are all pets
                                            //and now we exclude the Pets who are "shared"
                .Except(alice.Pets.Intersect(bob.Pets, new PetEqualityByIdComparer()));
            Printer.Print(petsWithOneOwnerOnly, nameof(petsWithOneOwnerOnly));


            //SequenceEqual check if the collection are equal
            var numbers3 = new[] { 1, 2, 3, 4 };
            var numbers4 = new[] { 1, 2, 3, 4 };
            Console.WriteLine(
                $"{nameof(numbers3)}.SequenceEqual({nameof(numbers4)}): {numbers3.SequenceEqual(numbers4)}");

            //note that the order matters
            var numbers5 = new[] { 4, 3, 2, 1 };
            Console.WriteLine(
                $"{nameof(numbers3)}.SequenceEqual({nameof(numbers5)}): {numbers3.SequenceEqual(numbers5)}");

            //remember that the default equality comparison be used
            var pets3 = new[]
             {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f)
            };
            var pets4 = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f)
            };

            Console.WriteLine(
               $"{nameof(pets3)}.SequenceEqual({nameof(pets4)}): {pets3.SequenceEqual(pets4)}");

            //we can provide custom Equality Comparer
            Console.WriteLine(
               $"{nameof(pets3)}.SequenceEqual({nameof(pets4)}) " +
               $"(equality compared by id): {pets3.SequenceEqual(pets4, new PetEqualityByIdComparer())}");
        }
    }
}

