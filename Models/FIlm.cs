using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UKW_sklep.czw.Models
{
    public class Film  
    {
        [Key]
        public required int Id_Film { get; set; }
        public required string Title { get; set; }
        [StringLength (600,ErrorMessage ="Przekroczono limit znaków")]
         public required string Director { get; set; }
        public required string Desc { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        public string Poster { get; set; }
        public int CategoryId { get; set; }


        public Category Category { get; set; }

        
    }
}
