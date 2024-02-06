using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusEduTech_BackEnd.Models
{
    
        [Table("tbl_UserAuthenticate")]
        public class UserAuthenticate
        {
            [Key]
            public Guid id { set; get; }

            [Required]
            [StringLength(50)]
            public string username { set; get; }

            [Required]
            [StringLength(50)]
            public string Password { set; get; }

            [Required]
            [StringLength(10)]
            public string role { set; get; }
        }
    }

