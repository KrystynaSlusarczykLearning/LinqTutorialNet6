using LinqTutorial.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class DotNet6Improvements
    {
        public static void Run()
        {
            //By operators (MinBy, MaxBy, DistinctBy, ExceptBy, IntersectBy, UnionBy)

            //MaxBy

            //before .NET 6 if we wanted to, for example, find the heaviest Pet, 
            //we had to do this

            var heaviestPetBeforeNet6 = Data.Pets.OrderBy(pet => pet.Weight).Last();
            Console.WriteLine($"heaviestPetBeforeNet6: {heaviestPetBeforeNet6}");

            var heaviestPet = Data.Pets.MaxBy(pet => pet.Weight);
            Console.WriteLine($"heaviestPetBeforeNet6: {heaviestPetBeforeNet6}");

            //MinBy

            var petWithShortestName = Data.Pets.MinBy(pet => pet.Name.Length);
            Console.WriteLine($"petWithShortestName: {petWithShortestName}");

            //DistinctBy
            //Returns distinct elements from a sequence by some properties.
            //let's say we have a collection of People, and people's Id 
            //is identifying them. Unfortunately, our data quality is low, 
            //and we have some duplicates. With DistinctBy, we can
            //select people without entries duplicated by Id. The second and next
            //entries with duplicated Id will be discarded
            var peopleWithDuplicatesById = new[]
            {
                new Person(1, "John", 1982),
                new Person(1, "john", 1982),
                new Person(2, "Monica", 1994),
                new Person(2, "MONICA", 1994),
                new Person(3, "Peter", 2000),
            };

            var peopleNoDuplicatesById = peopleWithDuplicatesById.DistinctBy(
                person => person.Id);
            Printer.Print(peopleNoDuplicatesById, nameof(peopleNoDuplicatesById));

            //Chunk

            //splits a collection into collections of given size
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var chunks = numbers.Chunk(3);
            foreach (var chunk in chunks)
            {
                Printer.Print(chunk.AsEnumerable(), nameof(chunk));
            }

            //Zip with third parameter

            //before .NET 6 Zip could have combined at most 2 collections:
            var years = new[] { 2000, 2001, 2002 };
            var months = new [] { 9, 10, 11 };
            var days = new [] { 20, 21, 22 };

            var zippedBeforeNet6 = years.Zip(months)
                .Select(yearMonth => $"{yearMonth.First}/{yearMonth.Second}");

            //to Zip 3 collections, we needed to use Zip twice
            var allZippedBeforeNet6 = years.Zip(months).Zip(days)
                .Select(yearMonthDay => 
                $"{yearMonthDay.First.First}/{yearMonthDay.First.Second}/{yearMonthDay.Second}");

            var allZipped = years.Zip(months, days)
                .Select(yearMonthDay =>
                $"{yearMonthDay.First}/{yearMonthDay.Second}/{yearMonthDay.Third}");

            Printer.Print(allZipped, nameof(allZipped));

            //index from end operator
            //allows to use the N-th index from the end

            //In .NET 5 I would need to do this
            var thirdFromEndBeforeNet6 = numbers.ElementAt(numbers.Count() - 3);
            Printer.Print(thirdFromEndBeforeNet6, nameof(thirdFromEndBeforeNet6));

            //with .NET 6, it is much simpler
            var thirdFromEnd = numbers.ElementAt(^3);
            Printer.Print(thirdFromEnd, nameof(thirdFromEnd));

            //range operator
            //before .NET 6 if we wanted, for example, to take elements between 
            //index 2 and 6 from a collection, we needed to do this:
            var secondToSixthBeforeNet6 = numbers.Skip(2).Take(4);
            Printer.Print(secondToSixthBeforeNet6, nameof(secondToSixthBeforeNet6));

            //with .NET 6, we can use the range operator
            var secondToSixth = numbers.Take(2..6);
            Printer.Print(secondToSixth, nameof(secondToSixth));

            //we can skip the beginning or the end of the range,
            //for example, to take all alfter index 6:
            var allAfterIndex6 = numbers.Take(6..);
            Printer.Print(allAfterIndex6, nameof(allAfterIndex6));

            //..or all before index 4:
            var allBefore4 = numbers.Take(..4);
            Printer.Print(allBefore4, nameof(allBefore4));

            //we can also use it with the index from end operator,
            //for example, to take all elements between
            //index 2 and the 3rd index from the end
            var allBetweenIndex2AndThirdFromEnd = numbers.Take(2..^3);
            Printer.Print(allBetweenIndex2AndThirdFromEnd, nameof(allBetweenIndex2AndThirdFromEnd));

            //TryGetNonEnumeratedCount
            //enables us to get the count of the collection,
            //IF it doesn't require enumeration
            //if it would, the count will not be returned

            //regular Count will enumerate collection, and if this collection
            //comes, for example, from a database, it can take long time

            IEnumerable<Pet> pets1 =
            new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f),
            };

            IEnumerable<Pet> pets2 =
            new[]
            {
                new Pet(6, "Lucky", PetType.Dog, 5f),
                new Pet(7, "Storm", PetType.Cat, 0.9f),
                new Pet(8, "Nyan", PetType.Cat, 2.2f)
            };
            var count = pets1.Concat(pets2).Count();

            //for such usecases we can use TryGetNonEnumeratedCount
            if(numbers.TryGetNonEnumeratedCount(out int safeCount))
            {
                Console.WriteLine("Count is: " + safeCount);
            }
            else
            {
                Console.WriteLine("Can't get the count without enumerating.");
            }
        }

        public record Person(int Id, string Name, int YearOfBirth);
    }
}
