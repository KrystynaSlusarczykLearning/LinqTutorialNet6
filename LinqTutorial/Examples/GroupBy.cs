using System;
using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class GroupBy
    {
        //System.Linq.Enumerable.GroupBy
        public static void Run()
        {
            //Group by groups the elements of a collection by some criteria

            //let's say we want to create a Dictionary
            //with PetType as the Key
            //and sum of weights of Pets of this type
            //we will need to group all pets by PetType
            var petsGroupedByType = Data.Pets
                .GroupBy(
                pet => pet.PetType,
                pet => pet.Weight);

            //GroupBy creates a IEnumerable<IGrouping<PetType, float>>
            //now we need to sum up weights of each group
            var petTypesWeights = petsGroupedByType.ToDictionary(
                grouping => grouping.Key,
                grouping => grouping.Sum());
            Printer.Print(petTypesWeights, nameof(petTypesWeights));

            //if we omitted the second param, the values in each group
            //would simply be whole Pets objects, not weights

            //now, let's group People by their names first letter
            //and create a Dictionary where the first letter will be the key
            //and those People Pets' Names will be the value
            var personInitialsPetsMapping = Data.People
                .GroupBy(person => person.Name[0])
                .ToDictionary(
                grouping => grouping.Key,
                grouping => string.Join(", ", grouping.SelectMany(person => person.Pets)
                    .Select(pet => pet.Name)));

            Printer.Print(personInitialsPetsMapping, nameof(personInitialsPetsMapping));

            //the first parameter of GroupBy is KeySelector, which we used above
            //we can use GroupBy with second argument - the ElementSelector

            //now let's group Pets by the floor of their Weight
            //and then let's create print all those groups
            //with information about minimal and maximal weight in each group
            var weightGroups = Data.Pets
                .GroupBy(
                pet => Math.Floor(pet.Weight),
                (floorOfWeight, allPetsInThisGroup) => new
                {
                    FloorOfWeight = floorOfWeight,
                    MinWeightInThisGroup = allPetsInThisGroup.Min(pet => pet.Weight),
                    MaxWeightInThisGroup = allPetsInThisGroup.Max(pet => pet.Weight)
                })
                .OrderBy(weightGroup => weightGroup.FloorOfWeight);

            Console.WriteLine(string.Join(
                "\n",
                weightGroups.Select(weightGroup =>
                $"Group: {weightGroup.FloorOfWeight}," +
                $" Min: {weightGroup.MinWeightInThisGroup}," +
                $" Max: {weightGroup.MaxWeightInThisGroup}")));
        }

        public static class QuerySyntax
        {
            //group by
            public static void Run()
            {
                //let's say we want to create a Dictionary
                //with PetType as the Key
                //and sum of weights of Pets of this type
                //we will need to group all pets by PetType

                var petsGroupedByType = from pet in Data.Pets
                                        group pet by pet.PetType;

                //GroupBy creates a IEnumerable<IGrouping<PetType, Pet>>
                //now we need to sum up weights of each group
                var petTypesWeights = petsGroupedByType.ToDictionary(
                    grouping => grouping.Key,
                    grouping => grouping.Sum(pet => pet.Weight));
                Printer.Print(petTypesWeights, nameof(petTypesWeights));

                //now, let's group People by their names first letter
                //and create a Dictionary where the first letter will be the key
                //and those People Pets' Names will be the value
                var personInitialsPetsMapping =
                    (from person in Data.People
                     group person by person.Name.First())
                     .ToDictionary(
                        grouping => grouping.Key,
                        grouping => string.Join(",",
                            from person in grouping
                            from pet in person.Pets
                            select pet.Name));

                Printer.Print(personInitialsPetsMapping, nameof(personInitialsPetsMapping));

                //we can use the grouping in the same query
                //now let's group Pets by the floor of their Weight
                //and then let's create print all those groups
                //with information about minimal and maximal weight in each group
                var petWeightGroups = from pet in Data.Pets
                                      group pet by Math.Floor(pet.Weight) into grouping
                                      orderby grouping.Key
                                      let petsOrderedByWeight = from pet in grouping
                                                                orderby pet.Weight
                                                                select pet
                                      select new
                                      {
                                          Key = grouping.Key,
                                          LightestPet = petsOrderedByWeight.First(),
                                          HeaviestPet = petsOrderedByWeight.Last(),
                                      };

                var petsWeightsGroupsAsStrings = from petWeightGroup in petWeightGroups
                                                 select $"Weight category: {petWeightGroup.Key}, " +
                                                 $"heaviestPet: {petWeightGroup.HeaviestPet.Name}, " +
                                                 $"lightestPet: {petWeightGroup.LightestPet.Name}";
                Printer.Print(petsWeightsGroupsAsStrings, nameof(petsWeightsGroupsAsStrings));

            }
        }
    }
}

