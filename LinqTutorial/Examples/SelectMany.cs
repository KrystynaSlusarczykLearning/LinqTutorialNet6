using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TResult> OurSelectMany<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, IEnumerable<TResult>> selector)
        {
            var results = new List<TResult>();
            foreach (var element in source)
            {
                var innerCollection = selector(element);
                foreach (var innerElement in innerCollection)
                {
                    results.Add(innerElement);
                }
            }
            return results;
        }
    }

    static class SelectMany
    {
        //System.Linq.Enumerable.SelectMany
        public static void Run()
        {
            //SelectMany is used to flatten nested collections
            var nestedListOfNumbers = new List<List<int>>
            {
                new List<int> {1, 2, 3},
                new List<int> {4, 5, 6},
                new List<int> {5, 6},
            };

            Console.WriteLine(
                $"Count of elements in the {nameof(nestedListOfNumbers)}: {nestedListOfNumbers.Count()}");

            var allNumbersFromNestedList = nestedListOfNumbers.SelectMany(
                list => list);
            Console.WriteLine(
                $"Count of elements in the {nameof(allNumbersFromNestedList)}: {allNumbersFromNestedList.Count()}");
            Printer.Print(allNumbersFromNestedList, nameof(allNumbersFromNestedList));

            //let's select all Pets belonging to people,
            //whose names start with letter "J"

            //if we use Select, we will get a nested IEnumerable
            var allPetsOfJPeopleNested = Data.People
                .Where(person => person.Name.StartsWith("J"))
                .Select(person => person.Pets);
            Console.WriteLine($"Count of {nameof(allPetsOfJPeopleNested)} is {allPetsOfJPeopleNested.Count()}");
            Printer.Print(allPetsOfJPeopleNested, nameof(allPetsOfJPeopleNested));

            //we must use SelectMany to flatten the nested collection
            var allPetsOfJPeople = Data.People
                .Where(person => person.Name.StartsWith("J"))
                .SelectMany(person => person.Pets);
            Console.WriteLine($"Count of {nameof(allPetsOfJPeople)} is {allPetsOfJPeople.Count()}");
            Printer.Print(allPetsOfJPeople, nameof(allPetsOfJPeople));

            //what if the collection was nested even deeper?
            var veryNestedListOfNumbers = new List<List<List<int>>>
            {
                new List<List<int>>
                {
                    new List<int> { 1, 2, 3},
                    new List<int> { 4,5,6},
                    new List<int> { 5,6},
                },
                new List<List<int>>
                {
                    new List<int> { 10, 12, 13},
                    new List<int> { 14, 15},
                }
            };

            //we just need to use SelectMany twice
            var allNumbersFromVeryNestedList = veryNestedListOfNumbers
                .SelectMany(innerList => innerList)
                .SelectMany(innerInnerList => innerInnerList);
            Console.WriteLine(
                $"Count of elements in the {nameof(allNumbersFromVeryNestedList)}: {allNumbersFromVeryNestedList.Count()}");
            Printer.Print(allNumbersFromVeryNestedList, nameof(allNumbersFromVeryNestedList));

            //let's go back to the People and Pets example
            //before we selected all Pets belonging to all People
            //but in the end, we ignored People's information
            //let's now select pairs of People and their Pets
            //we will use the overloaded SelectMany method

            var personsPetsPairs = Data.People
                .SelectMany(
                    person => person.Pets,
                    (person, pet) => $"Person {person.Name}, Pet: {pet.Name}");

            Printer.Print(personsPetsPairs, nameof(personsPetsPairs));

            var numbers = new[] { 1, 2, 3 };
            var letters = new[] { 'A', 'B', 'C' };
            var carthesianProduct = numbers.SelectMany(
                _ => letters,
                (number, letter) => $"{number},{letter}");
            Printer.Print(carthesianProduct, nameof(carthesianProduct));
        }

        public static class QuerySyntax
        {
            public static void Run()
            {
                //with query syntax, we must simply use "from... in" twice
                var nestedListOfNumbers = new List<List<int>>
                {
                    new List<int> { 1, 2, 3},
                    new List<int> { 4,5,6},
                    new List<int> { 5,6},
                };

                Console.WriteLine(
                    $"Count of elements in the {nameof(nestedListOfNumbers)}: {nestedListOfNumbers.Count()}");

                var allNumbersFromNestedList = from list in nestedListOfNumbers
                                               from number in list
                                               select number;
                Console.WriteLine(
                    $"Count of elements in the {nameof(allNumbersFromNestedList)}: {allNumbersFromNestedList.Count()}");
                Printer.Print(allNumbersFromNestedList, nameof(allNumbersFromNestedList));

                //let's select all Pets belonging to people,
                //whose names start with letter "J"

                var allPetsOfJPeople = from person in Data.People
                                       where person.Name.StartsWith("J")
                                       from pet in person.Pets
                                       select pet;

                Console.WriteLine($"Count of {nameof(allPetsOfJPeople)} is {allPetsOfJPeople.Count()}");
                Printer.Print(allPetsOfJPeople, nameof(allPetsOfJPeople));

                //what if the collection was nested even deeper?
                var veryNestedListOfNumbers = new List<List<List<int>>>
                {
                    new List<List<int>>
                    {
                        new List<int> { 1, 2, 3},
                        new List<int> { 4,5,6},
                        new List<int> { 5,6},
                    },
                    new List<List<int>>
                    {
                        new List<int> { 10, 12, 13},
                        new List<int> { 14, 15},
                    }
                };

                //we just need to use "from...in" three times
                var allNumbersFromVeryNestedList =
                    from nestedList in veryNestedListOfNumbers
                    from list in nestedList
                    from number in list
                    select number;

                Console.WriteLine(
                    $"Count of elements in the {nameof(allNumbersFromVeryNestedList)}: {allNumbersFromVeryNestedList.Count()}");
                Printer.Print(allNumbersFromVeryNestedList, nameof(allNumbersFromVeryNestedList));
            }
        }
    }
}

