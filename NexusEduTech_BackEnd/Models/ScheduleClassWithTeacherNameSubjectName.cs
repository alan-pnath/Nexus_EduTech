namespace NexusEduTech_BackEnd.Models
{
    public class ScheduleClassWithTeacherNameSubjectName
    {
        public int ClassId { get; set; }
        public string SessionTime { get; set; }
        public DateTime SessionDate { get; set; }
        public string Name { set; get; }
    }
}
