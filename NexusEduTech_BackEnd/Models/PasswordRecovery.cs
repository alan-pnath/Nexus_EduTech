using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace NexusEduTech_BackEnd.Models
{
    public class PasswordRecovery
    {
        [Required]
        [Column("Email")]
        public string Email { get; set; }   
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
