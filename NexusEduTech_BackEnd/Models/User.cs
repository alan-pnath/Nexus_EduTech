        using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NexusEduTech_BackEnd.Models
{
    [Table("tbl_User")]
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("UserId", TypeName = "int")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Enter Valid UserName")]
        [Column("UserName", TypeName = "varchar")]
        [StringLength(50)]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Enter Valid Password")]
        [Column("Password", TypeName = "varchar")]
        [StringLength(50)]
        public string Password { set; get; }

        [Required(ErrorMessage = "Enter Valid Role")]
        [Column("Role", TypeName = "varchar")]
        [StringLength(15)]
        public string Role { set; get; }

        [Required(ErrorMessage = "Enter Valid Contact Number")]
        [Column("Contact Number", TypeName = "varchar")]
        [StringLength(10)]
        public string ContactNumber { set; get; }


        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage = "Invalid EmailId")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Valid Id")]
        [Column("Id", TypeName = "int")]
        public int Id { set; get; }







    }
}
