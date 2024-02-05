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

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public CustomUser? userId { get; set; }


        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Classess? class_Id { get; set; }

        [Column]
        public string subject { get; set; }

        [Required]
        [Column("Registration Number", TypeName = "varchar")]
        [StringLength(50)]
        public string RegistrationNumber { get; set; }
    }
}
