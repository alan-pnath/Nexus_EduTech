using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NexusEduTech_BackEnd.Models
{
    public class StudentAttendence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudAttendenceId { get; set; }

        [Required]
        [Column("StudentID")]
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student? Student { get; set; }
       
        [Required]
        [Column("StudentAttendenceDate",TypeName ="date")]
        public DateTime AttendanceDate { get; set; }

        [Required]
        [Column("StudentStatus",TypeName ="varchar")]
        [StringLength(10)]
        public string Status { get; set; }

    }
}
