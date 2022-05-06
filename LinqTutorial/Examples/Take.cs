using System.Linq;
using Utilities;

namespace LinqTutorial
{
    static class Take
    {
        //System.Linq.Enumerable.Take
        //System.Linq.Enumerable.TakeLast
        //System.Linq.Enumerable.TakeWhile
        public static void Run()
        {
            var numbers = new[] { 10, 1, 4, 17, 122 };

            //Take
            //Take returns a specified number
            //of contiguous elements from the start of a sequence.
            var take3 = numbers.Take(3);
            Printer.Print(take3, nameof(take3));

            //if we take more than collection size,
            //whole collection will be returned
            //no exception will be thrown
            var take20 = numbers.Take(20);
            Printer.Print(take20, nameof(take20));

            //TakeLast
            var takeLast3 = numbers.TakeLast(3);
            Printer.Print(takeLast3, nameof(takeLast3));

            //let's say we want to pick the 2 largest numbers
            var twoLargestNumbers = numbers.OrderBy(n => n).TakeLast(2);
            Printer.Print(twoLargestNumbers, nameof(twoLargestNumbers));

            //let's say we want to pick the second largest number
            var secondLargestNumber = numbers.OrderBy(n => n).TakeLast(2).First();
            Printer.Print(secondLargestNumber, nameof(secondLargestNumber));

            //let's take 60% of the pets
            var sixtyPercentOfPets = Data.Pets.Take((int)(Data.Pets.Count() * 0.6));
            Printer.Print(sixtyPercentOfPets, nameof(sixtyPercentOfPets));

            //TakeWhile
            var numbers2 = new[] { 1, 4, 10, 154, 999 };
            var takeWhileSmallerThan20 = numbers2.TakeWhile(n => n < 20);
            Printer.Print(takeWhileSmallerThan20, nameof(takeWhileSmallerThan20));

            //let's take pets until we "hit" a pet heavier than 30 kilos
            var takeWhileLighterThan30 = Data.Pets.TakeWhile(pet => pet.Weight < 30);
            Printer.Print(takeWhileLighterThan30, nameof(takeWhileLighterThan30));

            //let's do the same but until we "hit" a pet LIGHTER than 30 kilos
            //the collection will be empty because the first pet is lighter than 30 kilos,
            //so while we process the first element the predicate will be false,
            //so we will not Take even one element
            var takeWhileHeavierThan30 = Data.Pets.TakeWhile(pet => pet.Weight > 30);
            Printer.Print(takeWhileHeavierThan30, nameof(takeWhileHeavierThan30));
        }
    }
}
