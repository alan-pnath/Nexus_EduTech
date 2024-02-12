using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
using System.Security.Cryptography;

namespace NexusEduTech_BackEnd.Repository
{
    public interface ITeacherAttendence
    {
        void AddTeacherAttendence(TeacherAttendenceDTO data);
        AttendenceResult GetTeacherAttendenceById(int tid);
        List<TeacherAttendenceDTO> GetTeacherAttendencebyMonth(int month);
        void Update(TeacherAttendenceDTO data, int id);
    }
}
