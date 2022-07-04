using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asmC5.Models
{
    public partial class Foods
    {
        [Key]
        public int FoodID { get; set; }
        [Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "nvarchar(250)")]
        public string FoodName { get; set; }
        
        [ForeignKey("CategoryModels")]
        [Column(TypeName = "int")]
        public int FoodCategory { get; set; }
        [Required(ErrorMessage = "Please enter data")]    
        [Column(TypeName = "float")]
        public float FoodPrice { get; set; }
        [Required(ErrorMessage = "Please enter data")]
        public string FoodImage { get; set; }
        [NotMapped]
        public IFormFile fileUpload { get; set; }
        [Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "nvarchar(250)")]
        public string FoodType { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime CreatDate { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string ModifyDate { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string ModifyBy { get; set; }
      
        [Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "float")]
        public float VAT { get; set; }
        [Column(TypeName = "bit")]
        public bool IsDelete { get; set; }

        public CategoryModels CategoryModels { get; set ; }
      
        public ICollection<CartDetails> CartDetails{ get; set; }
    }
}
