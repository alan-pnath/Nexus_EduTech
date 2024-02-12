using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusEduTech_BackEnd.Models
{
    [Table("tbl_Marks")]
    public class Marks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MarkId { get; set; }


        public int StudentId { get; set; }
        [ForeignKey("StudentId")]

        public Student? Student { get; set; }


        public int ExamId { get; set; }
        [ForeignKey("ExamId")]

        public Examination? Exam { get; set; }


        [Required]
        [Column("Mark")]
        public int mark { get; set; }

    }
}
