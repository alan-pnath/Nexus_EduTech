using NexusEduTech_BackEnd.DTOs;

namespace NexusEduTech_BackEnd.Repository
{
    public interface IMarks
    {
        public string AddMark(MarksDTO data);
        public string UpdateMark(MarksDTO data);
    }
}
