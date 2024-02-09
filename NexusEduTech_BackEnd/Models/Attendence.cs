namespace NexusEduTech_BackEnd.Models
{
    public class Attendence
    {
        public int TotalWorkingDays { get; set; }
        public int NoOfPresent { get; set; }
        public int NoOfAbsent { get; set; }

        public int AttendencePercentage { get; set; }
    }
}
