using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Repository
{
    public interface IStudentAttendence
    {
        void AddStudentAttendence(StudentAttendenceDTO data);
        AttendenceResult GetStudAttendenceById(int studid);
        List<StudentAttendenceDTO> GetStudentAttendencebyMonth(int month);
        void Update(StudentAttendenceDTO data, int id);
        List<AttendenceLayout> GetAttendenceByClassStdSec(string std, string sec);

    }
}
