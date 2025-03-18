using System;
using System.Data;
using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class DotNet9Improvements
    {
        public static void Run()
        {
            //CountBy

            //In older .NET versions, we woule need to use GroupBy with Select
            var petCountsByTypeOld = Data.Pets
                .GroupBy(pet => pet.PetType)
                .Select(group => new { Type = group.Key, Count = group.Count() });

            Printer.Print(petCountsByTypeOld, nameof(petCountsByTypeOld));

            //In .NET 9, we can use the CountBy method
            var petCountsByType = Data.Pets.CountBy(pet => pet.PetType);

            Printer.Print(petCountsByType, nameof(petCountsByType));



            //AggregateBy

            //In older .NET versions, we woule need to use GroupBy with Select
            var totalWeightByTypeOld = Data.Pets
                .GroupBy(pet => pet.PetType)
                .Select(group => new { Type = group.Key, TotalWeight = group.Sum(pet => pet.Weight) });

            Printer.Print(totalWeightByTypeOld, nameof(totalWeightByTypeOld));

            //In .NET 9, we can use the AggregateBy method
            var totalWeightByType = Data.Pets.AggregateBy(
                pet => pet.PetType,
                0.0f,
                (total, pet) => total + pet.Weight
            );

            Printer.Print(totalWeightByType, nameof(totalWeightByType));

        }
    }
}
