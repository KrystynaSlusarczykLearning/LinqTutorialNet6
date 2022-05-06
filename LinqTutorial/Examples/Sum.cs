using System;
using System.Linq;

namespace LinqTutorial
{
    static class Sum
    {
        //System.Linq.Enumerable.Sum
        public static void Run()
        {
            var numbers = new[] { 10, 1, 4, 17, 122 };

            //Sum calculates the sum of the values
            var sumOfNumbers = numbers.Sum();
            Console.WriteLine($"sumOfNumbers: {sumOfNumbers}");

            var sumOfPetsWeight = Data.Pets.Sum(pet => pet.Weight);
            Console.WriteLine($"sumOfPetsWeight: {sumOfPetsWeight}");

            //if the collection is empty, the sum will be zero
            //no exception will be thrown
            var emptyNumbers = new int[0];
            var sum = emptyNumbers.Sum();
            Console.WriteLine(
                $"sum of elements in an empty collection: {sum}");
        }
    }
}
