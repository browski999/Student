using System;

namespace Student.Core.Shared.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime DoB { get; set; }
    }
}
