using NexusEduTech_BackEnd.Models;
using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
namespace NexusEduTech_BackEnd.Profiles
{
    public class ClassProfile:Profile
    {
        public ClassProfile() 
        {
            CreateMap<ClassDTO, Classess>();
            CreateMap<ClassProfile ,ClassDTO>();

        }

    }
}
