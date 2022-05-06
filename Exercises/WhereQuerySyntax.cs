using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class WhereQuerySyntax
    {
        //Coding Exercise 1
        /*
        Using the query syntax, implement the GetBornAfter method, which given a year
        and a collection of people will return only the people born after the given year.

        For example, for the year 1950 and the following people:
            *Geraldine Smith born in 1920
            *John Smith born in 1950
            *Monica Smith born in 1954
            *Jake Smith born in 1982
        
        ...the expected result is:
            *Monica Smith born in 1954
            *Jake Smith born in 1982
         */
        public static IEnumerable<Person> GetBornAfter(
           int year, IEnumerable<Person> people)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
        Using LINQ's query syntax implement the GetStudentsWhoNeedToStudyMore method, 
        which given a collection of students will return those students, 
        who don't have any marks, or the average of their marks is below 3.

        For example, for the following students:
            *Stacey Brown with no marks
            *Jake Smith with marks {3, 5, 5}
            *Chris Miller with marks {2, 3}
            *Anne Evans with marks {3, 3, 1}
        
        ...the result shall be:
            *Stacey Brown with no marks
            *Chris Miller with marks {2, 3}
            *Anne Evans with marks {3, 3, 1}
         */
        public static IEnumerable<Student>
           GetStudentsWhoNeedToStudyMore(
               IEnumerable<Student> students)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string> FindWordsWithSubstring_Refactored(
                 string substring,
                 IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string> FindWordsWithSubstring(
                string substring,
                IEnumerable<string> words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                if (word.Contains(substring))
                {
                    result.Add(word);
                }
            }
            result.Sort();
            return result;
        }

        public class Person : IEquatable<Person>
        {
            public string Name { get; }
            public DateTime DateOfBirth { get; }

            public Person(string name, DateTime dateOfBirth)
            {
                Name = name;
                DateOfBirth = dateOfBirth;
            }

            public override string ToString()
            {
                return $"{Name} born on {DateOfBirth.ToString("yyyy-MM-dd")}";
            }

            public bool Equals(Person other)
            {
                return
                       Name == other.Name &&
                       DateOfBirth == other.DateOfBirth;
            }
        }

        public class Student : IEquatable<Student>
        {
            public string Name { get; set; }
            public IEnumerable<int> Marks { get; set; }

            public override string ToString()
            {
                return $"{Name} with marks: ({string.Join(", ", Marks)})";
            }

            public bool Equals(Student other)
            {
                return
                       Name == other.Name &&
                       Marks.SequenceEqual(other.Marks);
            }
        }
    }
}
