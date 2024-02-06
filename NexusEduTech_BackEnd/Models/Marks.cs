using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusEduTech_BackEnd.Models
{
    [Table("tbl_Marks")]
    public class Marks
    {
        [Key]
        [Required]
        public Guid MarkId { get; set; }

        public int StudentId { get; set; }
        [Column("StudentID")]
        [ForeignKey("StudentId")]
        public Student? studentId { get; set; }

        public int ExamId { get; set; }
        [Column("ExamId")]
        [ForeignKey("ExamId")]
        public Examination? examId { get; }

        [Required]
        [Column("Mark", TypeName = "int")]
        public int mark { get; set; }
    }
}
