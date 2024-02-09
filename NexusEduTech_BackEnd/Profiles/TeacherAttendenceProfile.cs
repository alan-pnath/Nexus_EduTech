using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
namespace NexusEduTech_BackEnd.Profiles
{
    public class TeacherAttendenceProfile:Profile
    {
        public TeacherAttendenceProfile() 
        {
            CreateMap<TeacherAttendenceDTO,TeacherAttendence>();
            CreateMap<TeacherAttendence,TeacherAttendenceDTO>();
        }
    }
}
