using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Repository
{
    public interface IStudent
    {
        string Add(StudentDTO data);
        string Update(StudentDTO data);
        string Delete(int id);
        StudentDTO GetByRollNo(string rollno);
        List<StudentDTO> GetByStd(string std);
        List<StudentDTO> GetByStdSec(string std, string sec);

        List<StudentDTO> GetAll();

    }
}
