using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusEduTech_BackEnd.Models
{
    public class ScheduleClass
    {

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScheduleClassId { get; set; }

        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class? Class { get; set; }


        /* [Required]
         [StringLength(10)]
         public string Standard { get; set; }*/

        [Required]
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher? Teacher { get; set; }

        [Required]
        public string SessionTime { get; set; }

        [Required]
        [Column("SessionDate", TypeName = "date")]
        public DateTime SessionDate { get; set; }


        [Required]
        public int subjectId { get; set; }
        [ForeignKey("subjectId")]
        public Subject? Subject { get; set; }
    }
}
