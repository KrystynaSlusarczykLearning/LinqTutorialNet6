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
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
        Implement the GetYoungest method, which, given a collection of people, 
        will return the youngest person from this collection. 
        
        If the collection is empty, the result should be null.
         */
        public static Person GetYoungest(IEnumerable<Person> people)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static Person FindOwnerOf_Refactored(Pet pet, IEnumerable<Person> people)
        {
            //TODO your code goes here
            throw new NotImplementedException();
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
