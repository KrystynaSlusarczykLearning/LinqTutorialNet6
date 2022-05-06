using System;
using System.Linq;

namespace LinqTutorial.MethodSyntax
{
    static class DotNet6Improvements
    {
        public static void Run()
        {
            //By operators (MinBy, MaxBy, DistinctBy, ExceptBy, IntersectBy, UnionBy)

            //before .NET 6 if we wanted to, for example, find the heaviest Pet, 
            //we had to do this

            var heaviestPetBeforeNet6 = Data.Pets.OrderBy(pet => pet.Weight).Last();
            Console.WriteLine($"heaviestPetBeforeNet6: {heaviestPetBeforeNet6}");

            var heaviestPet = Data.Pets.MaxBy(pet => pet.Weight);
            Console.WriteLine($"heaviestPetBeforeNet6: {heaviestPetBeforeNet6}");

        }
    }
}
