using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
namespace NexusEduTech_BackEnd.Profiles
{
    public class StudentAttendenceProfile : Profile
    {
       public  StudentAttendenceProfile()
        {
            CreateMap<StudentAttendenceDTO, StudentAttendence>();
            CreateMap<StudentAttendence, StudentAttendenceDTO>();

        }
    }
}
