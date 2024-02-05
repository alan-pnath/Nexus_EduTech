using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusEduTech_BackEnd.Models
{
    public class Examination
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExamId { get; set; }

        [Required]
        [Column("ExamName", TypeName = "varchar")]
        [StringLength(30)]
        public string ExamName { get; set; }

        [Column("ExamDate", TypeName = "Date")]
        public DateTime ExamDate { get; set; }

        [Column("Max_Mark", TypeName = "int")]
        public int Max_Mark { get; set; }

        [ForeignKey("ClassId")]
        public Classess? ClassId { get; set; }
}
}
