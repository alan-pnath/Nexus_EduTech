using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
namespace NexusEduTech_BackEnd.Profiles
{
    public class ScheduleClassProfile:Profile
    {
        public ScheduleClassProfile()
        {
            CreateMap<ScheduleClassDTO, ScheduleClass>();
            CreateMap<ScheduleClass, ScheduleClassDTO>();

        }
    }
}



