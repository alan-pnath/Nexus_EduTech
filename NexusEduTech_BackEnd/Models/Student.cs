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



        [Required(ErrorMessage = "Enter Valid Std")]
        [Column("Std", TypeName = "varchar")]
        [StringLength(2)]
        [RegularExpression("[1-12]", ErrorMessage = "Invalid Std")]
        public string Std { set; get; }

        [Required(ErrorMessage = "Enter Valid Section ")]
        [Column("Section", TypeName = "varchar")]
        [StringLength(1)]
        [RegularExpression("[A-Z]", ErrorMessage = "Invalid Section")]
        public string Section { set; get; }

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