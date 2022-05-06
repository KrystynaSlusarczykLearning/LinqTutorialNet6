using System;
using System.Collections.Generic;
using System.Linq;
using LinqTutorial.DataTypes;
using Utilities;

namespace LinqTutorial
{
    static class OrderBy
    {
        //System.Linq.Enumerable.OrderBy
        //System.Linq.Enumerable.OrderByDescending
        //System.Linq.Enumerable.ThenBy
        //System.Linq.Enumerable.ThenByDescending
        //System.Linq.Enumerable.Reverse
        public static void Run()
        {
            //OrderBy creates a copy of the collection,
            //which is ordered by the given criteria
            var petsOrderedByName = Data.Pets.OrderBy(pet => pet.Name);
            Printer.Print(petsOrderedByName, nameof(petsOrderedByName));

            var petsOrderedByIdDescending = Data.Pets.OrderByDescending(pet => pet.Id);
            Printer.Print(petsOrderedByIdDescending, nameof(petsOrderedByIdDescending));

            //numbers of words we can simply order by themselves
            var numbers = new[] { 16, 8, 9, -1, 2 };
            var orderedNumbers = numbers.OrderBy(number => number);
            Printer.Print(orderedNumbers, nameof(orderedNumbers));

            var words = new[] { "lion", "tiger", "snow leopard" };
            var orderedWords = words.OrderBy(word => word);
            Printer.Print(orderedWords, nameof(orderedWords));

            //we can order by some criteria, and then by other criteria
            var petsOrderedByTypeThenName = Data.Pets
                .OrderBy(pet => pet.PetType)
                .ThenBy(pet => pet.Name);
            Printer.Print(petsOrderedByTypeThenName, nameof(petsOrderedByTypeThenName));

            var petsOrderedByTypeDescendingThenIdDescending = Data.Pets
                .OrderByDescending(pet => pet.PetType)
                .ThenByDescending(pet => pet.Id);
            Printer.Print(petsOrderedByTypeDescendingThenIdDescending,
                nameof(petsOrderedByTypeDescendingThenIdDescending));

            //Remember that LINQ does not modify the collections - it creates new ones

            //there are also overloaded versions of those methods
            //Accepting IComparer<T> as an input
            var petsOrderedByType = Data.Pets.OrderBy(
                pet => pet, new PetByTypeComparer());
            Printer.Print(petsOrderedByType, nameof(petsOrderedByType));

            //we can use the Reverse method to Reverse the order of the collection
            var petsReversed = Data.Pets.Reverse();
            Printer.Print(petsReversed, nameof(petsReversed));
        }

        public class PetByTypeComparer : IComparer<Pet>
        {
            public int Compare(Pet x, Pet y)
            {
                return x.PetType.CompareTo(y.PetType);
            }
        }

        public static class QuerySyntax
        {
            //orderby...descending
            public static void Run()
            {
                var numbers = new[] { 9, 3, 7, 1, 2 };
                var orderedNumbers = from number in numbers
                                     orderby number
                                     select number;
                Printer.Print(orderedNumbers, nameof(orderedNumbers));

                var petsOrderedByName = from pet in Data.Pets
                                        orderby pet.Name
                                        select pet;
                Printer.Print(petsOrderedByName, nameof(petsOrderedByName));

                var petsOrderedByIdDescending = from pet in Data.Pets
                                                orderby pet.Id descending
                                                select pet;
                Printer.Print(petsOrderedByIdDescending, nameof(petsOrderedByIdDescending));

                var petsOrderedByTypeThenName = from pet in Data.Pets
                                                orderby pet.PetType, pet.Name
                                                select pet;
                Printer.Print(petsOrderedByTypeThenName, nameof(petsOrderedByTypeThenName));

                var petsOrderedByTypeDescendingThenIdDescending =
                    from pet in Data.Pets
                    orderby pet.PetType descending, pet.Id descending
                    select pet;
                Printer.Print(petsOrderedByTypeDescendingThenIdDescending,
                    nameof(petsOrderedByTypeDescendingThenIdDescending));

                //No equivalent of Reverse method is present in Query Syntax
            }
        }
    }
}
