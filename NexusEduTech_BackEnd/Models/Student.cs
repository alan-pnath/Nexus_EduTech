using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusEduTech_BackEnd.Models
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }

        [ForeignKey("UserId")]
        public CustomUser? UserId { get; set; }

        [Required]
        public int ClassRoomId { get; set; }

        // [ForeignKey("ClassRoomId")]
        // public Classes? ClassRoomId { get; set; }

        [Required]
        [Column("Registration Number", TypeName = "varchar")]
        [StringLength(50)]
        public string RegistrationNumber { get; set; }
    }
}