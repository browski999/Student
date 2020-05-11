using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Student.Domain;
using Student.Services;
using System.Collections.Generic;

namespace Student.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public IEnumerable<StudentA> Index()
        {
            var students = _studentService.GetStudents();

            return students;
            //var studentDto = _mapper.Map<StudentDto>(students);

            //yield return studentDto;

        }
    }
}