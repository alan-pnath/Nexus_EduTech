namespace NexusEduTech_BackEnd.Models
{
    public class SC
    {
        public int ScheduleClassId { get; set; }
        public int ClassId { get; set; }
        public int TeacherId { get; set; }
        public string SessionTime { get; set; }
        public DateTime SessionDate { get; set; }
        public int subjectId { get; set; }
    }
}
