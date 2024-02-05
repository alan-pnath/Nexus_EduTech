using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NexusEduTech_BackEnd.Models
{
    public class Classess
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClassId { get; set; }

        [Required]
        [StringLength(10)]
        public string ClassName { get; set; }

    }
}
