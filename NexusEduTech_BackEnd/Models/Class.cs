using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NexusEduTech_BackEnd.Models
{
    [Table("tbl_class")]
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClassId {  get; set; }

        [Required]
        [Column("Standard", TypeName = "varchar")]
        [StringLength(50)]
        public string Standard { get; set; }

        [Required]
        [Column("Section", TypeName = "varchar")]
        [StringLength(50)]
        public string Section { get; set; }



    }
}
