using LinqTutorial.DataTypes;
using System;
using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class GeneratingNewCollection
    {
        //System.Linq.Enumerable.Empty
        //System.Linq.Enumerable.Range
        //System.Linq.Enumerable.Repeat
        //System.Linq.Enumerable.DefaultIfEmpty
        public static void Run()
        {
            //Empty
            //simply creates a new empty collection of a given type
            var emptyNumbers = Enumerable.Empty<int>();
            Console.WriteLine($"Count of elements in {nameof(emptyNumbers)} is {emptyNumbers.Count()}");

            //let's create a Dictionary 
            //where Person's name will be the key
            //and the Person's Pets will be the Value
            //but if this Person owns a Pet from the "blacklistedPets" collection
            //we wan't to make the Value an empty collection
            var blackListedPets = Data.Pets.Where(pet => pet.Name == "Ed");

            var peoplePetsDictionry = Data.People.ToDictionary(
                person => person.Name,
                person => person.Pets.Any(pet => blackListedPets.Contains(pet)) ?
                        Enumerable.Empty<Pet>() :
                        person.Pets);

            Printer.Print(peoplePetsDictionry, nameof(peoplePetsDictionry));

            //Repeat
            //Repeat creates a collection of a given size
            //filled with a repeated value
            var tenRepetitionsOf100 = Enumerable.Repeat(100, 10);
            Printer.Print(tenRepetitionsOf100, nameof(tenRepetitionsOf100));

            var threeFoxes = Enumerable
                .Repeat("fox", 3)
                .Select((word, index) => $"{index+1}. {word}");
            Printer.Print(threeFoxes, nameof(threeFoxes));

            //Range

            //Range creates a collection of given size, starting at given value
            var numbersFrom10To30 = Enumerable.Range(10, 21);
            Printer.Print(numbersFrom10To30, nameof(numbersFrom10To30));

            //let's find the first 10 powers of 2
            var powersOf2 = Enumerable.Range(1, 10).Select(number => Math.Pow(2, number));
            Printer.Print(powersOf2, nameof(powersOf2));

            //since in C# char can be cast to an int, we can easily generate 
            // a collection of letters
            var letters = Enumerable.Range('A', 10).Select(charAsNumber => (char)charAsNumber);
            Printer.Print(letters, nameof(letters));

            //let's create a dictionatry that will contain the following data:
            //Key - a string like "[0-5) kg", "[5-10) kg", "[10-15) kg"
            //Value - count of Pets with weight within that range
            var petsWeightsMapping = Enumerable
                .Range(0, 10)
                .Select(number => number * 5)
                .ToDictionary(
                    number => $"[{number}-{number + 5}) kg",
                    number => Data.Pets.Count(pet =>
                        pet.Weight >= number &&
                        pet.Weight < number + 5));
            Printer.Print(petsWeightsMapping, nameof(petsWeightsMapping));

            //DefaultIfEmpty
            //this method returns the original collection if not empty
            var numbers1 = new[] { 10, 1, 10, 4, 17, 17, 122 };
            var defaultIfEmpty1 = numbers1.DefaultIfEmpty();
            Printer.Print(defaultIfEmpty1, nameof(defaultIfEmpty1));

            //if empty, a collection of size 1 and default value at index 0 will be produced
            var numbers2 = new int[0];
            var defaultIfEmpty2 = numbers2.DefaultIfEmpty();
            Printer.Print(defaultIfEmpty2, nameof(defaultIfEmpty2));

            //we can choose the default value we want
            var defaultIfEmpty3 = numbers2.DefaultIfEmpty(99);
            Printer.Print(defaultIfEmpty3, nameof(defaultIfEmpty3));
        }
    }
}

