using AutoMapper;
using Student.Core.Shared.Dtos;
using Student.Domain;

namespace StudentApi
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<StudentA, StudentDto>();
        }
    }
}
