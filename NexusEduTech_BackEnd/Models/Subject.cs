using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NexusEduTech_BackEnd.Models
{
    [Table("tbl_subjects")]
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int subjectId { get; set; }

        [Required]
        [StringLength(20)]
        [Column("Subject",TypeName ="varchar")]
        public string subjectName { get; set; }


    }
}
