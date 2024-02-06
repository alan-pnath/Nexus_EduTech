
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NexusEduTech_BackEnd.Models
{


    [Table("tbl_CustomUser")]
    public class CustomUser
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

        [Required(ErrorMessage = "Enter Valid First Name")]
        [Column("FName", TypeName = "varchar")]
        [StringLength(50)]
        public string FName { set; get; }

        [Required(ErrorMessage = "Enter Valid Last Name")]
        [Column("LName", TypeName = "varchar")]
        [StringLength(50)]
        public string LName { set; get; }

        [Required(ErrorMessage = "Enter Valid Gender")]
        [Column("Gender", TypeName = "varchar")]
        [StringLength(10)]
        public string Gender { set; get; }

        [Required(ErrorMessage = "Enter Valid DOB")]
        [Column("DOB",TypeName ="Date")]
        public DateTime DOB { set; get; }

        [Required(ErrorMessage = "Enter Valid Address")]
        [Column("Address", TypeName = "varchar")]
        [StringLength(50)]
        public string Address { set; get; }

        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage = "Invalid EmailId")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Valid Role")]
        [Column("Role", TypeName = "varchar")]
        [StringLength(10)]
        public string Role { set; get; }

        [Required(ErrorMessage = "Enter IsActive ")]
        [Column("IsActive")]
        public bool IsActive { set; get; } = false;

    }
}

