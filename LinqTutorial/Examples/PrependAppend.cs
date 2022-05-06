using LinqTutorial.DataTypes;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class PrependAppend
    {
        //System.Linq.Enumerable.Prepend
        //System.Linq.Enumerable.Append
        public static void Run()
        {
            IEnumerable<int> numbers = new[] { 10, 1, 4, 17, 122 };
            //Prepend adds element at the beginning of the collection
            //please note that a new collection is created
            //the original collection is not modified
            var newNumbers = numbers.Prepend(99);
            Printer.Print(newNumbers, nameof(newNumbers));
            Printer.Print(numbers, nameof(numbers));

            //Append works the same, but it puts the element at the end of the collection
            var petsWithNewPet = Data.Pets.Append(
                new Pet(7, "Spark", PetType.Dog, 4f));
            Printer.Print(petsWithNewPet, nameof(petsWithNewPet));

            //Prepend and Append are often used together
            //let's say we had system where we can review restaurants
            //at first, we can select "Bad", "Medium" and "Good" grade
            //but after some time we want to also add "Terrible" and "Excellent" grades
            var originalGrades = new[] { "Bad", "Medium", "Good" };
            var newGrades = originalGrades.Prepend("Terrible").Append("Excellent");
            Printer.Print(newGrades, nameof(newGrades));
        }
    }
}
