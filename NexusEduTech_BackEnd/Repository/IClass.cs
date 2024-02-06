using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Repository
{
    public interface IClass
    {
        void AddClass(ClassDTO data);
        void UpdateClass(ClassDTO data);
        void DeleteClass(int id);
        List<ClassDTO> GetAllClasses();
            
    }
}
