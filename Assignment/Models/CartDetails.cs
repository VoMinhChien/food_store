using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asmC5.Models
{
    public class CartDetails
    {
        [Key]
        public int CartdetailId { get; set; }
        [ForeignKey("Carts")]
        
        public int CartID { get; set; }
        [ForeignKey("Foods")]
        public int FoodId { get; set; }
        [Required(ErrorMessage = "Please enter data")]
        public string FoodName { get; set; }
        [Required(ErrorMessage = "Please enter data")]
        public string FoodMount { get; set; } 
        [Required(ErrorMessage = "Please enter data")]
        public string FoodImage { get; set; }
        
        public string FoodType { get; set; }//cái này bỏ nha
        public string VAT { get; set; }
        public string IsDelete { get; set; }

        public Carts Carts{ get ; set ; }
        public Foods Foods{ get; set; }
    }
}
