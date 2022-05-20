using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class JoinQuerySyntax
    {
        //Coding Exercise 1
        /*
        Using LINQ's query syntax, implement the GetStudentsInfo method, 
        which given a collection of HogwartsStudents and HogwartsHouses will return 
        a collection of strings with information about which house the given student 
        is from. The result shall be ordered by the house name, 
        and then by the student name.

        For example, for the following houses:
            *Id: 1, Name: Gryffindor
            *Id: 2, Name: Hufflepuff
            *Id: 3, Name: Ravenclaw
            *Id: 4, Name: Slytherin
        
        ...and the following students:        
            *HouseId: 1, Name: Harry
            *HouseId: 4, Name: Draco
            *HouseId: 2, Name: Cedric
            *HouseId: 3, Name: Luna
            *HouseId: 1, Name: Ron
            *HouseId: 3, Name: Padma
        
        ...the result shall be:
            "Harry from house Gryffindor"
            "Ron from house Gryffindor"
            "Cedric from house Hufflepuff"
            "Luna from house Ravenclaw"
            "Padma from house Ravenclaw"
            "Draco from house Slytherin"
         */
        public static IEnumerable<string> GetStudentsInfo(
           IEnumerable<HogwartsStudent> students,
           IEnumerable<HogwartsHouse> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
        Using LINQ's query syntax, implement the GetHousesAndStudentsInfo method, 
        which given a collection of HogwartsStudents and HogwartsHouses will return 
        a collection of strings with information about which house the given student 
        is from. This method shall perform a left join, which means, 
        even if there is a house with no students, it shall still be listed in 
        the collection, with special "no students" information.

        The result shall be ordered by the house name, and then by the student name.
        
        For example, for the following houses:
            *Id: 1, Name: Gryffindor
            *Id: 2, Name: Hufflepuff
            *Id: 3, Name: Ravenclaw
            *Id: 4, Name: Slytherin
        
        ...and the following students:
            *HouseId: 1, Name: Harry
            *HouseId: 2, Name: Cedric
            *HouseId: 3, Name: Luna
            *HouseId: 1, Name: Ron
            *HouseId: 3, Name: Padma
        
        (please note there are no students from house Slytherin)
        
        ...the result shall be:
            "House name: Gryffindor, student: Harry",
            "House name: Gryffindor, student: Ron",
            "House name: Hufflepuff, student: Cedric",
            "House name: Ravenclaw, student: Luna",
            "House name: Ravenclaw, student: Padma",
            "House name: Slytherin, student: no students"
         */
        public static IEnumerable<string> GetHousesAndStudentsInfo(
                IEnumerable<HogwartsStudent> students,
                IEnumerable<HogwartsHouse> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string>
            GetSubjectsOfStudents_Refactored(
                IEnumerable<HogwartsStudent> students,
                IEnumerable<HogwartsSubject> subjects,
                IEnumerable<HogwartsHouse> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string>
            GetSubjectsOfStudents(
                IEnumerable<HogwartsStudent> students,
                IEnumerable<HogwartsSubject> subjects,
                IEnumerable<HogwartsHouse> houses)
        {
            var result = new List<string>();
            foreach (var student in students)
            {
                string studentHouse = null;
                foreach (var house in houses)
                {
                    if (house.Id == student.HouseId)
                    {
                        studentHouse = house.Name;
                    }
                }

                foreach (var subjectId in student.SubjectsIds)
                {
                    foreach (var subject in subjects)
                    {
                        if (subject.Id == subjectId)
                        {
                            result.Add($"{student.Name} from house" +
                                $" {studentHouse} " +
                                $"studies {subject.Name}");
                        }
                    }
                }
            }
            return result;
        }

        public class HogwartsHouse
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"{Id}:{Name}";
            }
        }

        public class HogwartsStudent
        {
            public IEnumerable<int> SubjectsIds { get; set; }
            public int HouseId { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"{Name} (House:{HouseId})";
            }
        }

        public class HogwartsSubject
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"{Id}:{Name}";
            }
        }
    }
}
