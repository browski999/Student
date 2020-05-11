using Student.Domain;
using System.Collections.Generic;

namespace Student.Services
{
    public interface IStudentService
    {
        IEnumerable<StudentA> GetStudents();
        StudentA GetStudent(int id);
    }
}
