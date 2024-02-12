using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Repository
{
    public interface IScheduleClass
    {
      void AssignTeacher(ScheduleClassDTO data);
        List<ScheduleClassDTO> ViewSchedules();
        ScheduleClassDTO GetScheduleClassByStudentId(int id);
        void EditScheduleClass(ScheduleClassDTO data, int id);
        void DeleteScheduleClass(int id);
        List<ScheduleClassWithTeacherNameSubjectName> GetWithTeacherNameSubjectName(string teacherName);


    }
}
