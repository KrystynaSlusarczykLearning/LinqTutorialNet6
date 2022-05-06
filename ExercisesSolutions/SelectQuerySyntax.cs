using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class SelectQuerySyntax
    {
        //Coding Exercise 1
        public static IEnumerable<string>
            GetAbsoluteValuesInfo(IEnumerable<int> numbers)
        {
            return from number in numbers
                   select $"|{number}|={Math.Abs(number)}";
        }

        //Coding Exercise 2
        public static IEnumerable<string> GetShortAddresses(IEnumerable<House> houses)
        {
            return from house in houses
                   let addressSplitByCommas = house.Address.Split(',')
                   select addressSplitByCommas.Count() == 3 ?
                   addressSplitByCommas[1].TrimStart(' ') :
                   house.Address;
        }

        //Refactoring Challenge
        public static string GetBestStudentInfo_Refactored(
            IEnumerable<Student> students)
        {
            return (from student in students
                    let maxMark = student.Marks.Any() ?
                                  student.Marks.Max() :
                                  0
                    orderby maxMark descending
                    select
                        $"Best mark was earned by " +
                        $"{student.Name}" +
                        $" and it is {maxMark}")
                    .FirstOrDefault();
        }

        //do not modify this method
        public static string GetBestStudentInfo(IEnumerable<Student> students)
        {
            var studentsAsList = students.ToList();
            if (studentsAsList.Count == 0)
            {
                return null;
            }

            var studentWithMaxMark = studentsAsList[0];
            var maxMark = 0;
            foreach (var student in studentsAsList)
            {
                var studentsMaxMark = student.Marks.Any() ?
                    student.Marks.Max() :
                    0;
                if (studentsMaxMark > maxMark)
                {
                    maxMark = studentsMaxMark;
                    studentWithMaxMark = student;
                }
            }

            return $"Best mark was earned by " +
                   $"{studentWithMaxMark.Name}" +
                   $" and it is {maxMark}";
        }

        public class House
        {
            public string Address { get; }

            public House(string address)
            {
                Address = address;
            }

            public override string ToString()
            {
                return Address;
            }
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
    }
}
