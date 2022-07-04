using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asmC5.Models
{
    public class CategoryModels
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please enter data")]
        [Column(TypeName = "nvarchar(250)")]
        public string CategorName { get; set; }
        public ICollection<Foods> Foods { get; set ; }
        
    }
}
