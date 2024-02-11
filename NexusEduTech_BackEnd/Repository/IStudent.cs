using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Repository
{
    public interface IStudent
    {
        string Add(StudentDTO data);
        string Update(Student data);
        string Delete(int id);
       GetByRollNo GetByStudentId(int id);
        List<ByStd> GetByStd(string std);
        List<ByStd> GetByStdSec(string std, string sec);
        List<ByStd> GetAll();

        List<StudentDTO> GetStudentsByClassId(int classId);
     
    }
}
