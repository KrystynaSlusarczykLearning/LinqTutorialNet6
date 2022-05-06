using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class ElementAt
    {
        //System.Linq.Enumerable.ElementAt
        //System.Linq.Enumerable.ElementAtOrDefault
        public static void Run()
        {
            //ElementAt
            //it accessed the item at given element
            var numbers = new[] { 10, 1, 4, 17, 122 };
            var numberAtIndex3 = numbers.ElementAt(3);
            Printer.Print(numberAtIndex3, nameof(numberAtIndex3));

            //for arrays we can use simple indexer instead of LINQ method:
            var numberAtIndex4 = numbers[4];
            Printer.Print(numberAtIndex4, nameof(numberAtIndex4));

            //we use ElementAt mostly when simple indexing is not supported.
            //the below line is not supported since Pets.Collection is an IEnumerable<Pet>,
            //not an array
            //var petAtIndex3 = Pets.Collection[3];

            var petAtIndex4 = Data.Pets.ElementAt(4);
            Printer.Print(petAtIndex4, nameof(petAtIndex4));

            //if there is no element under the index, an exception is thrown:
            //var petAtIndex99 = Pets.Collection.ElementAt(99);

            //ElementAtOrDefault
            //we can use ElementAtOrDefault to avoid the exception
            //when there is no element under the index
            //the default value for the type will be used - in this case null
            var petAtIndex99OrDefault = Data.Pets.ElementAtOrDefault(99);
            Printer.Print(petAtIndex99OrDefault, nameof(petAtIndex99OrDefault));
        }
    }
}
