namespace NexusEduTech_BackEnd.DTOs
{
    public class TeacherDTO
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public int ClassId { get; set; }

    }
}
