using LinqTutorial.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class TypeSwitching
    {
        //System.Linq.Enumerable.ToArray
        //System.Linq.Enumerable.ToDictionary
        //System.Linq.Enumerable.ToHashSet
        //System.Linq.Enumerable.ToList
        //System.Linq.Enumerable.ToLookup
        //System.Linq.Enumerable.AsEnumerable
        //System.Linq.Enumerable.Cast
        public static void Run()
        {
            //ToArray
            //simply changes the type to an array
            var numbers = new List<int> { 10, 1, 4, 17, 122 };
            Console.WriteLine(numbers.GetType());
            var numbersAsArray = numbers.ToArray();
            Console.WriteLine(numbersAsArray.GetType());

            //ToDictionary
            //transforms the collection to a Dictionary, 
            //which is a collection of KeyValue pairs
            //in case of pets, let's make the Id the Key, and the Name the Value
            var petsAsDictionary = Data.Pets.ToDictionary(
                pet => pet.Id,
                pet => pet.Name);

            Printer.Print(petsAsDictionary, nameof(petsAsDictionary));

            //remember that Dictionary's keys must be unique
            //for example, we can't use PetType as Dictionary,
            //because we have several Pets of type Dog
            //that's why the below code will throw an exception
            //var petsAsDictionary2 = Pets.Collection.ToDictionary(
            //    pet => pet.PetType,
            //    pet => pet.Name);

            //ToHashSet
            //HashSet is a collection of unique elements
            //transforming collection to a HashSet will remove duplicates, 
            //similarly as the Distinct method does
            var numbersWithDuplicates = new[] { 1, 1, 2, 2, 2, 3 };
            var numbersAsHashSet = numbersWithDuplicates.ToHashSet();
            Printer.Print(numbersAsHashSet, nameof(numbersAsHashSet));

            //ToList
            //simply changes the type to a List<T>
            var words = new [] { "little", "brown", "fox" };
            Console.WriteLine(words.GetType());
            var wordsAsList = words.ToList();
            Console.WriteLine(wordsAsList.GetType());

            //ToLookup
            //Lookup is somewhat similar to Dictionary,
            //but under one key there can be more than one value
            //let's create a Lookup where the PetType will be the Key,
            //and pets names will be the values
            var lookup = Data.Pets.ToLookup(
                pet => pet.PetType,
                pet => pet.Name);
            Printer.Print(lookup, nameof(lookup));

            //AsEnumerable
            //AsEnumerable simply transforms the collection to IEnumerable<T>
            var asEnumerable = numbers.AsEnumerable();
            Printer.Print(asEnumerable, nameof(asEnumerable));

            //but AsEnumerable is an extension method for... IEnumerable<T>!
            //so what's the point of "tranforming" it to the same type?
            //it's to make sure we use the methods from IEnumerable,
            //not some custom methods present in custom types
            var verySpecificList = new VerySpecificList<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //first, let's simply use the Where method
            //the Where method from VerySpecificList will be used
            //and 1,2,3,4,5 will be printed
            var where1 = verySpecificList.Where(n => n > 7);
            Printer.Print(where1, nameof(where1));

            //now, let's hide the specific Where implementation by using AsEnumerable
            //Wehere from LINQ will be used
            //and 8,9,10 will be printed
            var where2 = verySpecificList.AsEnumerable().Where(n => n > 7);
            Printer.Print(where2, nameof(where2));

            //we can use Cast to cast each element in the collection
            //to a target type
            var flyables = new List<IFlyable> { new Bird(), new Bird() };
            Console.WriteLine(flyables.GetType());
            var birds = flyables.Cast<Bird>();
            Console.WriteLine(birds.GetType());

            //a common use for the Cast method = getting all values from the Enum
            var allPetsTypes = Enum.GetValues(typeof(PetType)).Cast<PetType>();
        }

        class VerySpecificList<T> : List<T>
        {
            // Custom implementation of Where()
            // the signature is the same as for LINQ's Where method
            public IEnumerable<T> Where(Func<T, bool> predicate)
            {
                //this implementation is made this way for the sake of the example
                throw new InvalidOperationException("I don't support filtering!");
            }
        }

        interface IFlyable
        {
            public void Fly();
        }

        class Bird : IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("Flying by flapping my wings");
            }
        }
    }
}

