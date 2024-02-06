using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Profiles
{
    public class MarkProfile:Profile
    {
        public MarkProfile() 
        {
            CreateMap<MarksDTO, Marks>();
            CreateMap<Marks, MarksDTO>();

        }
    }
}
