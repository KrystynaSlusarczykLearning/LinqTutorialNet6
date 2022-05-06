using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class SelectQuerySyntax
    {
        //Coding Exercise 1
        /*
         Using LINQ's query syntax, implement the GetAbsoluteValuesInfo method, 
        which given a collection of numbers will return a collection of strings with 
        information about those numbers' absolute values.

        For example, for numbers {-7, 2, -3, 8} the result shall be a collection of 
        strings with the following values:
            "|-7|=7"
            "|2|=2"
            "|-3|=3"
            "|8|=8"
         */
        public static IEnumerable<string>
            GetAbsoluteValuesInfo(IEnumerable<int> numbers)
        {
            //  TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
        Imagine you are working on a system that collects information about houses in 
        some area. Each house has an Address. Some of the houses have full addresses 
        defined, containing:
            *town name
            *road and the house number
            *the borough 

        For example, "Maple Town, 123 Old Road, South Slope Borough". 
        
        On the other hand, some of the houses have only the road and the house number 
        specified in the address.
        
        For example, "41 Beach Road".
        
        Using query syntax, implement the GetShortAddresses method, which given 
        a collection of houses will return a collection of strings with only the road 
        and the house numbers of the houses.
        
        For example, for the following houses:
            *new House("Maple Town, 123 Old Road, South Slope Borough"), 
            *new House("41 Beach Road")
            *new House("Oak Village, 12 Forest Alley, North Lake Borough"),
            *new House("4 River Path"),
        
        The result shall be:
            *"123 Old Road"
            *"41 Beach Road"
            *"12 Forest Alley"
            *"4 River Path"
        
        Assume all addresses are correct, and that the full addresses are always 
        formatted like "{TOWN NAME}, {ROAD AND THE HOUSE NUMBER}, {BOROUGH}".
         */
        public static IEnumerable<string> GetShortAddresses(IEnumerable<House> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring Challenge
        //TODO implement this method
        public static string GetBestStudentInfo_Refactored(
            IEnumerable<Student> students)
        {
            //TODO your code goes here
            throw new NotImplementedException();
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
