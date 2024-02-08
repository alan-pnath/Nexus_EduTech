using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Profiles
{
    public class StudentProfile:Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentDTO, Student>();
            CreateMap<Student, StudentDTO>();

        }
    }
}
