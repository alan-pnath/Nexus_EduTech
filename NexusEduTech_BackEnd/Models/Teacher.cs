using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusEduTech_BackEnd.Models
{
    [Table("tbl_Teacher")]
    public class Teacher
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeacherId { get; set; }

        [Required(ErrorMessage = "Enter Valid Name")]
        [Column("Name", TypeName = "varchar")]
        [StringLength(50)]
        public string Name { set; get; }

        [Required(ErrorMessage = "Enter Valid Gender")]
        [Column("Gender", TypeName = "varchar")]
        [StringLength(10)]
        public string Gender { set; get; }

        [Required(ErrorMessage = "Enter Valid DOB")]
        [Column("DOB", TypeName = "Date")]
        public DateTime DOB { set; get; }

        [Required(ErrorMessage = "Enter Valid Address")]
        [Column("Address", TypeName = "varchar")]
        [StringLength(50)]
        public string Address { set; get; }

        [Required(ErrorMessage = "Enter Valid Contact Number")]
        [Column("Contact Number", TypeName = "varchar")]
        [StringLength(10)]
        public string ContactNumber { set; get; }


        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage = "Invalid EmailId")]
        public string Email { get; set; }

        [Required]
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class? Class { get; set; }

    }
}
