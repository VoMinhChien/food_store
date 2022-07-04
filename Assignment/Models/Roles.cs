using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asmC5.Models
{
    public class Roles
    {

        [Key]
        public int RoleID { get; set; }
        [Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "nvarchar(250)")]
        public string RoleName { get; set; }
        public ICollection<User> User { get ; set ; }
    }
}
