using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asmC5.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "nvarchar(250)")]
        public string UserFullName { get; set; }

        //[Required(ErrorMessage = "Please enter data")]
        //[Column(TypeName = "nvarchar(250)")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "nvarchar(250)")]
        public string UserPassWord { get; set; }

        [Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "nvarchar(100)")]
        public string UserGender { get; set; }
        [Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "DateTime")]
        public DateTime UserBirtday { get; set; }
        [Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "varchar(15)")]
        public string UserPhone { get; set; }
        [Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "nvarchar(250)")]
        public string UserAddress { get; set; }

        [ForeignKey("Roles")]
        public int RoleID { get; set; }
        
        [Column(TypeName = "nvarchar(250)")]
        public string UserToken { get; set; }
        
        [Column(TypeName = "nvarchar(250)")]
        public string UserTokenGG { get; set; }
      
        [Column(TypeName = "bit")]
        public bool IsDelete { get; set; }
        public ICollection<Carts> Carts { get; set; }
        public Roles Roles{ get ; set ; }
     
    }
}
