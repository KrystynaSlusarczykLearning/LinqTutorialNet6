using System;
using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{

    static class Aggregate
    {
        //System.Linq.Enumerable.Aggregate
        public static void Run()
        {
            //Aggregate Applies an accumulator function over a sequence.
            //Aggregate performs an operation on each element of the list
            //taking into account the operations that have been performed before

            //let's use Aggregate to calculate a sum of elements in a collection
            //(we could use Sum method, of course)
            var numbers = new[] { 10, 1, 4, 17, 122 };
            var sum = numbers.Aggregate((sum, nextNumber) => sum + nextNumber);
            Console.WriteLine($"sum is {sum}");

            //let's find the longest word in the collection
            var sentence = "The quick brown fox jumps over the lazy dog";
            var longestWord = sentence.Split(" ")
                .Aggregate((longestSoFar, nextWord) => 
                nextWord.Length > longestSoFar.Length ? nextWord : longestSoFar);
            Console.WriteLine($"longest word is '{longestWord}'");

            //let's use Aggregate to merge letters with a separator
            //(we could use string.Join for that, of course)
            var chars = new[] { "a", "b", "c", "d" };
            var withSeparator = chars.Aggregate((a, b) => a + ',' + b);
            Console.WriteLine($"withSeparator: {withSeparator}");

            //we can use non-default initial value (so-called "seed")
            //we can also implement Count using Aggregate
            var countOfWords = sentence.Split(" ")
                .Aggregate(
                0,
                (totalCount, nextWord) => totalCount + 1);
            Console.WriteLine($"countOfWords: {countOfWords}");

            //let's create a list of all lenghts of words from the sentence
            var lenghtsOfWords = sentence.Split(" ")
                .Aggregate(
                Enumerable.Empty<int>(),
                (wordsLengthsLists, nextWord) => wordsLengthsLists.Append(nextWord.Length));
            Printer.Print(lenghtsOfWords, nameof(lenghtsOfWords));

            //let's calculate the factorial of 10
            //10! = 10*9*8*7*6*5*4*3*2*1
            var factorialBase = 10;
            var factorial = Enumerable.Range(1, factorialBase - 1)
                .Aggregate(
                    10,
                    (factorialSoFar, nextNumber) => factorialSoFar * (factorialBase - nextNumber));
            Console.WriteLine($"factorial: {factorial}");
        }
    }
}
