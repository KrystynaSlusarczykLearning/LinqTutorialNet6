using LinqTutorial.DataTypes;
using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class ConcatUnion
    {
        //System.Linq.Enumerable.Concat
        //System.Linq.Enumerable.Union
        public static void Run()
        {
            //Concat merges two collections into one
            var numbers1 = new[] { 1, 3, 5, 7, 9 };
            var numbers2 = new[] { 2, 4, 6, 8, 10 };
            var concatenatedNumbers = numbers1.Concat(numbers2);
            Printer.Print(concatenatedNumbers, nameof(concatenatedNumbers));

            //Concat do not remove duplicates
            var numbers3 = new[] { 1, 3, 5, 7, 9 };
            var numbers4 = new[] { 1, 3, 5, 7 };
            var concatenatedNumbersWithDuplicates = numbers3.Concat(numbers4);
            Printer.Print(concatenatedNumbersWithDuplicates, nameof(concatenatedNumbersWithDuplicates));

            //to remove the duplicates after concatenation we can use Distinct
            var concatenatedNumbersNoDuplicates = numbers3.Concat(numbers4).Distinct();
            Printer.Print(concatenatedNumbersNoDuplicates, nameof(concatenatedNumbersNoDuplicates));

            //alternatively, we can use Union, which removes duplicates by definitions
            //creating a set of unique elements
            var union = numbers3.Union(numbers4);
            Printer.Print(union, nameof(union));

            //remember that for Union the default equality comparison be used
            var pets1 = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f)
            };
            var pets2 = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f)
            };
            //in this case, Union will produce a collection of 3 elements
            //because Hannibal from pets1 is not equal to Hannibal from pets2
            //remember, they may look the same but they are two different objects
            //with two different references
            var petsUnionDefaultEqualityCheck = pets1.Union(pets2);
            Printer.Print(petsUnionDefaultEqualityCheck, nameof(petsUnionDefaultEqualityCheck));

            //we can provide the custom equality comparer:
            var petsUnion = pets1.Union(pets2, new PetEqualityByIdComparer());
            Printer.Print(petsUnion, nameof(petsUnion));

            //we can, of course, chain the Concat and Union methods
            //to merge more than one collection
            var cats = Data.Pets.Where(pet => pet.PetType == PetType.Cat);
            var dogs = Data.Pets.Where(pet => pet.PetType == PetType.Dog);
            var fish = Data.Pets.Where(pet => pet.PetType == PetType.Fish);
            var catsDogsAndFish = cats.Concat(dogs).Concat(fish);
            Printer.Print(catsDogsAndFish, nameof(catsDogsAndFish));
        }
    }
}
