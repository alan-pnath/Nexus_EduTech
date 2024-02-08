using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusEduTech_BackEnd.Models
{
    [Table("tbl_Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }
        [Required]
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class? Class { get; set; }

        [Required(ErrorMessage = "Enter Valid Name")]
        [Column("Name", TypeName = "varchar")]
        [StringLength(50)] 
        public string Name { get; set; }

        [Required]
        [Column("Registration Number", TypeName = "varchar")]
        [StringLength(50)]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Enter Valid Gender")]
        [Column("Gender", TypeName = "varchar")]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Enter Valid DOB")]
        [Column("DOB", TypeName = "Date")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Enter Valid Address")]
        [Column("Address", TypeName = "varchar")]
        [StringLength(50)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage = "Invalid EmailId")]
        public string Email { get; set; }



    }
}