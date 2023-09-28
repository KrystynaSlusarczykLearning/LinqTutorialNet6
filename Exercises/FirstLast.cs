using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class FirstLast
    {
        //Coding Exercise 1
        /*
         Implement the FindFirstNameInTheCollection method, which takes a collection of 
        strings as a parameter, and as a result, it returns the first valid name 
        from this collection. 
        A string is a valid name if:
            *it consists of at least two letters
            *it starts with an upper case character
            *all other characters in this word are lower case
        If there are no valid names in this collection, the result should be null.
         */
        public static string FindFirstNameInTheCollection(IEnumerable<string> words)
        {
            // My 1st solution - don't think this is what she had in mind as we haven't done "Skip" yet
            //return words.FirstOrDefault(w =>
            //{
            //    return w.Count() > 1 
            //        && Char.IsUpper(w[0])
            //        && w.Skip(1).All(c => Char.IsLower(c));
            //});

            // Aha! One detail, as words is a collection of strings, could have used Length property (cool)
            // To verify other chars lower case, she simply counted uppercase chars and expects 1
            // To verify first char is Upper, she used First instead of treating the string as an array
            return words.FirstOrDefault(w =>
            {
                return w.Length > 1
                    && Char.IsUpper(w.First())  
                    && w.Count(c => Char.IsUpper(c)) == 1;
            });



        }

        //Coding Exercise 2
        /*
        Implement the GetYoungest method, which, given a collection of people, 
        will return the youngest person from this collection. 
        
        If the collection is empty, the result should be null.
         */
        public static Person GetYoungest(IEnumerable<Person> people)
        {
            return people.OrderBy(p => p.DateOfBirth).LastOrDefault();
        }

        //Refactoring challenge
        public static Person FindOwnerOf_Refactored(Pet pet, IEnumerable<Person> people)
        {
            // First solution, I used "Where" when it wasn't necessary
            //return people.Where(p => p.Pets.Contains(pet)).FirstOrDefault();
            return people.FirstOrDefault(p => p.Pets.Contains(pet));
        }

        //do not modify this method
        public static Person FindOwnerOf(Pet pet, IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                foreach (var personsPet in person.Pets)
                {
                    if (personsPet == pet)
                    {
                        return person;
                    }
                }
            }
            return null;
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IEnumerable<Pet> Pets;
            public DateTime DateOfBirth { get; set; }

            public Person(string name, DateTime dateOfBirth)
            {
                Name = name;
                DateOfBirth = dateOfBirth;
            }

            public Person(int id, string name, IEnumerable<Pet> pets)
            {
                Id = id;
                Name = name;
                Pets = pets;
            }

            public override string ToString()
            {
                return $"Name: {Name}, DateOfBirth: {DateOfBirth}";
            }
        }

        public class Pet
        {
            public int Id { get; }
            public string Name { get; }
            public PetType PetType { get; }
            public float Weight { get; }

            public Pet(int id, string name, PetType petType, float weight)
            {
                Id = id;
                Name = name;
                PetType = petType;
                Weight = weight;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Type: {PetType}, Weight: {Weight}";
            }
        }

        public enum PetType
        {
            Cat,
            Dog,
            Fish
        }
    }
}
