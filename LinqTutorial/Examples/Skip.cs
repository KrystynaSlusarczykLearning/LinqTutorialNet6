using System.Linq;
using Utilities;

namespace LinqTutorial
{
    static class Skip
    {
        //System.Linq.Enumerable.Skip
        //System.Linq.Enumerable.SkipLast
        //System.Linq.Enumerable.SkipWhile
        public static void Run()
        {
            var numbers = new[] { 10, 1, 4, 17, 122 };

            //Skip
            //Skip bypasses a specified number of elements in a sequence
            //and then returns the remaining elements.
            var skipped3 = numbers.Skip(3);
            Printer.Print(skipped3, nameof(skipped3));

            //if we skip beyond the collection end
            //the result collection will be empty
            var skipped20 = numbers.Skip(20);
            Printer.Print(skipped20, nameof(skipped20));

            //SkipLast
            var skippedLast3 = numbers.SkipLast(3);
            Printer.Print(skippedLast3, nameof(skippedLast3));

            //let's say we want to pick all numbers
            //except the largest and the smallest
            var allButLargestAndSmallest = numbers.OrderBy(n => n).Skip(1).SkipLast(1);
            Printer.Print(allButLargestAndSmallest, nameof(allButLargestAndSmallest));

            //let's skip half of the pets
            var halfOfThePets = Data.Pets.Skip(Data.Pets.Count() / 2);
            Printer.Print(halfOfThePets, nameof(halfOfThePets));

            //SkipWhile
            var numbers2 = new[] { 1, 4, 10, 154, 999 };
            var skipWhileSmallerThan20 = numbers2.SkipWhile(n => n < 20);
            Printer.Print(skipWhileSmallerThan20, nameof(skipWhileSmallerThan20));

            //please note that once we're first done skipping
            //all the next elements will be included, even if they meet the predicate
            //in this case, 11 and 12 will be included because we finished skipping
            //when we processed the 154 number
            var numbers3 = new[] { 1, 4, 10, 154, 999, 11, 12 };
            var skipWhileSmallerThan30 = numbers3.SkipWhile(n => n < 30);
            Printer.Print(skipWhileSmallerThan30, nameof(skipWhileSmallerThan30));

            //let's skip pets until we "hit" a pet heavier than 30 kilos
            var skippedWhileHeavierThan30 = Data.Pets.SkipWhile(pet => pet.Weight <= 30);
            Printer.Print(skippedWhileHeavierThan30, nameof(skippedWhileHeavierThan30));

            //Skip and Take are often used together
            //for example, let's say we want to access all Pets
            //except the 3rd, 4th and 5th pet in the collection
            var thirdFourthAndFifthPet = Data.Pets.Skip(2).Take(3);
            Printer.Print(thirdFourthAndFifthPet, nameof(thirdFourthAndFifthPet));
        }
    }
}
