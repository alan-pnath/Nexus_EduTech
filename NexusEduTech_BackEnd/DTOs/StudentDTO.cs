namespace NexusEduTech_BackEnd.DTOs
{
    public class StudentDTO
    {
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public int ClassRoomId { get; set; }
        public int ClassId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Std { set; get; }
        public string Section { set; get; }
    }

}
