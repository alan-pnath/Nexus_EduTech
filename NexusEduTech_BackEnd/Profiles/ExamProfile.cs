using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
namespace NexusEduTech_BackEnd.Profiles
{
    public class ExamProfile:Profile
    {
        public ExamProfile() 
        {
            CreateMap<ExamDTO, Examination>();
            CreateMap<Examination, ExamDTO>();
        }
    }
}
