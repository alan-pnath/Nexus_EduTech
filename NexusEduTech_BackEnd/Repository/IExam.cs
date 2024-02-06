using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Repository
{
    public interface IExam
    {
        string AddExam(ExamDTO data);
        string UpdateExam(ExamDTO data);
        string DeleteExam(int id);
        List<ExamDTO> GetByName(string name);
        List<ExamDTO> GetAll();
    }
}
