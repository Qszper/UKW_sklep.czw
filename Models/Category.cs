using System.ComponentModel.DataAnnotations;

namespace UKW_sklep.czw.Models
{
    public class Category
    {
        [Key]
        public required int Id_Category  { get; set; }
        [Required(ErrorMessage = "Dodaj pole")]
        public required string Name { get; set; }
         public required string Desc { get; set; }
  
        public  int? Id_Id_Film  { get; set; }
    }
}
