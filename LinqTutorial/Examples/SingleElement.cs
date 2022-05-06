using LinqTutorial.DataTypes;
using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class SingleElement
    {
        //System.Linq.Enumerable.Single
        //System.Linq.Enumerable.SingleOrDefault
        public static void Run()
        {
            var numbers = new[] { 10, 1, 4, 17, 122 };

            //Single
            //Returns the only element of a sequence that satisfies a specified condition,
            //and throws an exception if more than one such element exists.
            var number10 = numbers.Single(n => n == 10);
            Printer.Print(number10, nameof(number10));

            //we can skip the predicate if we want to access the only element in the collection
            //this simply changes an one-element collection to a single value
            var numbers2 = new[] { 6 };
            var singleNumber = numbers2.Single();

            //but it will throw an exception if there are more than one elements in the collection
            //var singleNumber2 = numbers.Single();

            //the below will thrown an exception
            //because there is no such element in this collection
            //var number99 = numbers.Single(n => n == 99);
            //Printer.Print(number99, nameof(number99));

            //the below will thrown an exception
            //because there are more than one even numbers in this collection
            //var singleEvenNumber = numbers.Single(n => n % 2 == 0);
            //Printer.Print(singleEvenNumber, nameof(singleEvenNumber));

            //SingleOrDefault
            //we can use SingleOrDefault to avoid the exception
            //when there is no such element in the collection
            //the default value for the type will be used - in this case 0
            var number99OrDefault = numbers.SingleOrDefault(n => n == 99);
            Printer.Print(number99OrDefault, nameof(number99OrDefault));

            //the below will thrown an exception
            //because there are more than one even numbers in this collection
            //var singleOrDefaultEvenNumber = numbers.SingleOrDefault(n => n % 2 == 0);
            //Printer.Print(singleOrDefaultEvenNumber, nameof(singleOrDefaultEvenNumber));

            var singleFish = Data.Pets.Single(pet => pet.PetType == PetType.Fish);
            Printer.Print(singleFish, nameof(singleFish));
        }
    }
}
