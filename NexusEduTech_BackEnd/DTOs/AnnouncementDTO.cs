namespace NexusEduTech_BackEnd.DTOs
{
    public enum RecipientType
    {
        All,
        Teachers,
        Student
    }

    public class AnnouncementDTO
    {
        public string AnnouncementContent { get; set; }
        public RecipientType RecipientType { get; set; }
        public string StudentEmail { get; set; } // Only applicable if RecipientType is Student
    }
}
