using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
namespace NexusEduTech_BackEnd.Profiles
{
    public class TeacherProfile:Profile
    {
        public TeacherProfile() 
        {
            CreateMap<TeacherDTO, Teacher>();
            CreateMap<Teacher,TeacherDTO>();
        }
    }
}
