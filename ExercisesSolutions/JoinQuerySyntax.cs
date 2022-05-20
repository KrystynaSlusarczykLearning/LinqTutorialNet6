using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class JoinQuerySyntax
    {
        //Coding Exercise 1
        public static IEnumerable<string> GetStudentsInfo(
           IEnumerable<HogwartsStudent> students,
           IEnumerable<HogwartsHouse> houses)
        {
            return from student in students
                   join house in houses on student.HouseId equals house.Id
                   orderby house.Name, student.Name
                   select $"{student.Name} from house {house.Name}";
        }

        //Coding Exercise 2
        public static IEnumerable<string> GetHousesAndStudentsInfo(
                IEnumerable<HogwartsStudent> students,
                IEnumerable<HogwartsHouse> houses)
        {
            return from house in houses
                   join student in students
                            on house.Id equals student.HouseId into housesStudents
                   from houseStudent in housesStudents.DefaultIfEmpty()
                   let studentInfo = houseStudent == null ? "no students" : houseStudent.Name
                   orderby house.Name, studentInfo
                   select $"House name: {house.Name}, student: {studentInfo}";
        }

        //Refactoring challenge
        public static IEnumerable<string>
            GetSubjectsOfStudents_Refactored(
                IEnumerable<HogwartsStudent> students,
                IEnumerable<HogwartsSubject> subjects,
                IEnumerable<HogwartsHouse> houses)
        {
            return from student in students
                   from subjectIds in student.SubjectsIds
                   join house in houses
                        on student.HouseId equals house.Id
                   join subject in subjects
                        on subjectIds equals subject.Id
                   select $"{student.Name} from house " +
                   $"{house.Name} studies {subject.Name}";
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
            public IEnumerable<int> SubjectsIds { get; set; } = new List<int>();
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
