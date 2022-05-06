using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Where
    {
        //Coding Exercise 1
        /*
         Let's define a Student class. A student has a collection of Marks, 
        which are numbers. We could calculate the average mark for each student, 
        for example, if a student's marks are 3,4,5, the average mark for this student 
        is 4.

        Implement the GetScholarshipCandidates method, which will find all those students,
        whose average mark is above 4.6.

        For example, let's consider students:
            *Cathy has marks 4,4,6 which gives an average of 4.66
            *Martin has marks 5,5,5,3 which gives an average of 4.5
            *Bethy has marks of 6,5,5,3 which gives an average of 4.75

        For those students, the GetScholarshipCandidates method shall return 
        the collection of Students, with Cathy and Bethy in it.

        If a student has no marks at all, we assume their average mark is 0.
         */
        public static IEnumerable<Student> GetScholarshipCandidates(
            IEnumerable<Student> students)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
         Implement the GetProperlyIndexedWords method, which takes a collection 
        of words as a parameter, and returns only those words, that start with 
        a proper index. A proper index shall say at which place the word 
        in the collection is. So the first word shall start with "1.", 
        the third shall start with "3." etc.

        For example:
            *for words {"1.AAA", "2.BBB", "invalidWord", "4.DDD"} the result should be
                {"1.AAA", "2.BBB", "4.DDD"} 
            *for words {"1.AAA", "2.BBB",  "4.DDD"} the result should be 
                {"1.AAA", "2.BBB"}  because "4.DDD" has an invalid index 
                (it is the third word in the collection, so it's index should be 3)
            *for words {"0.AAA", "2.BBB", "invalidWord", "5.DDD"} the result should be 
                {"2.BBB"}, because "0.AAA" is the first word, so it shall start with "1",
                and "5.DDD" is the fourth word, so it shall start with "4". 
                "invalidWord" is invalid, because it doesn't start with an index at all.
         */
        public static IEnumerable<string> GetProperlyIndexedWords(
            IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<Person> GetMultipleFishOwners_Refactored(
            IEnumerable<Person> people)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<Person> GetMultipleFishOwners(
            IEnumerable<Person> people)
        {
            var result = new List<Person>();
            foreach (var person in people)
            {
                var count = 0;
                foreach (var pet in person.Pets)
                {
                    if (pet.PetType == PetType.Fish)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    result.Add(person);
                }
            }
            return result;
        }

        public class Student
        {
            public string Name { get; set; }
            public IEnumerable<int> Marks { get; set; }

            public override string ToString()
            {
                return $"{Name} with marks ({string.Join(", ", Marks)})";
            }
        }

        public class Person
        {
            public int Id { get; }
            public string Name { get; }
            public IEnumerable<Pet> Pets;

            public Person(int id, string name, IEnumerable<Pet> pets)
            {
                Id = id;
                Name = name;
                Pets = pets;
            }

            public override string ToString()
            {
                return $"{Name} owns: ({string.Join(", ", Pets)})";
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
                return $"pet's name: {Name}, Type: {PetType}";
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
