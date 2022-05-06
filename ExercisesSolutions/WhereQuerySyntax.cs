using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class WhereQuerySyntax
    {
        //Coding Exercise 1
        public static IEnumerable<Person> GetBornAfter(
           int year, IEnumerable<Person> people)
        {
            return from person in people
                   where person.DateOfBirth.Year > year
                   select person;
        }

        //Coding Exercise 2
        public static IEnumerable<Student>
           GetStudentsWhoNeedToStudyMore(
               IEnumerable<Student> students)
        {
            return from student in students
                   where
                    !student.Marks.Any() ||
                    student.Marks.Average() < 3
                   select student;
        }

        //Refactoring challenge
        public static IEnumerable<string> FindWordsWithSubstring_Refactored(
                 string substring,
                 IEnumerable<string> words)
        {
            return from word in words
                   where word.Contains(substring)
                   orderby word
                   select word;
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
