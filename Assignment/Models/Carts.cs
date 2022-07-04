using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asmC5.Models
{
    public class Carts
    {
        [Key]
        public int CardId { get; set; }
        [ForeignKey("User")]
        [Column(TypeName = "int")]
        public int UserId { get; set; }
        //[Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "nvarchar(250)")]
        public string UserFullName { get; set; }
        //[Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "varchar(250)")]
        public string UserEmail { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string UserPhone { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string UseAddress { get; set; }
        [Column(TypeName = "float")]
        public float TotalPrice { get; set; }
        [Column(TypeName = "float")]
        public float CardTocal { get; set; }
        [Column(TypeName = "float")]
        public float VAT { get; set; }

        //[Column(TypeName = "nvarchar(20)")]
        public DateTime PaymentDate { get; set; }//sao kieu string ba//tui choi gian a/
        [ForeignKey("PaymentType")]
        public int PaymentTypeId { get; set; }
        [Column(TypeName = "bit")]
        [Display(Name ="Status")]
        public bool IsDelete { get; set; }

        public User User { get; set; }
        public ICollection<CartDetails> CartDetails { get ; set ; }
        public PaymentType PaymentType { get; set; }
    }
}
