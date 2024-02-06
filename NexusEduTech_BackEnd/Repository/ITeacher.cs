using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Repository
{
    public interface ITeacher
    {
        void AddTeacher(TeacherDTO data);
        void UpdateTeacher(TeacherDTO data);
        void DeleteTeacher(int teacherId);
        List<TeacherDTO> GetAll();
        List<TeacherDTO> GetTeacherBySubject(string subject);
        TeacherDTO GetTeacher(int teacherId);
    }
}
