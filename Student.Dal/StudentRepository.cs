
using Student.Domain;
using System;
using System.Collections.Generic;

namespace Student.Dal
{
    public class StudentRepository : IStudentRepository
    {
        public StudentA GetStudent(int id)
        {
            return new StudentA
            {
                Id = 5,
                Forename = "Sarah",
                Surname = "Jones",
                Age = 23,
                DoB = Convert.ToDateTime("1985-11-25")
            };
        }

        public IEnumerable<StudentA> GetStudents()
        {
            var students = new List<StudentA>
            {
                new StudentA { Id = 1, Forename = "Stuart", Surname = "Wright", Age = 23, DoB = Convert.ToDateTime("1969-01-22")},
                new StudentA { Id = 2, Forename = "Timothy", Surname = "Stephson", Age = 55, DoB = Convert.ToDateTime("1965-06-18")},
                new StudentA { Id = 3, Forename = "Peter", Surname = "Grahams", Age = 33, DoB = Convert.ToDateTime("1987-03-05")},
                new StudentA { Id = 4, Forename = "Mark", Surname = "Williams", Age = 20, DoB = Convert.ToDateTime("2000-08-02")}
            };

            return students;
        }
    }
}
