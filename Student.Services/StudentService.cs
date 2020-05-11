using Student.Dal;
using Student.Domain;
using System.Collections.Generic;

namespace Student.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public StudentA GetStudent(int id)
        {
            return _studentRepository.GetStudent(id);
        }

        public IEnumerable<StudentA> GetStudents()
        {
            return _studentRepository.GetStudents();
        }
    }
}
