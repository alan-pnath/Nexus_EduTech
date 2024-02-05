using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusEduTech_BackEnd.Models
{
    [Table("tbl_Student")]
    public class Student
    {
        [Required]
        public int StudentId { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public CustomUser? userId { get; set; }

        [Required]
        public int ClassRoomId { get; set; }

        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Classess? class_Id { get; set; }

        [Required]
        [Column("Registration Number", TypeName = "varchar")]
        [StringLength(50)]
        public string RegistrationNumber { get; set; }
    }


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

        public int ExamId { get;set; }
        [Column("ExamId")]
        [ForeignKey("ExamId")]
        public Examination? examId { get;}

        [Required]
        [Column("Mark",TypeName ="int")]
        public int mark {  get; set; }
    }



}