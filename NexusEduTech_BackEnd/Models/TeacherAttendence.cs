using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusEduTech_BackEnd.Models
{
    public class TeacherAttendence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherAttendId { get; set; }

        [Required]
        [Column("TeacherId")]
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher? Teacher { get; set; }


        [Required]
        [Column("TeacherAttendenceDate",TypeName ="date")]
        public DateTime AttendanceDate { get; set; }

        [Required]
        [Column("TeacherStatus", TypeName = "varchar")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
