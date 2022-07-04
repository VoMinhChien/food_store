using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asmC5.Models
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeId { get; set; }
        [Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "nvarchar(150)")]
        public string PaymentTypeName { get; set; }
        public ICollection<Carts> Carts { get; set; }
        
    }
}
