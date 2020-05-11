using Student.Domain;
using System.Collections.Generic;

namespace Student.Dal
{
    public interface IStudentRepository
    {
        IEnumerable<StudentA> GetStudents();

        StudentA GetStudent(int id);
    }
}
