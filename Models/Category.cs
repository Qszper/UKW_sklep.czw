using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace UKW_sklep.czw.Models
{
    public class Category
    {
        [Key]
        public required int Id_Category  { get; set; }
        [Required(ErrorMessage = "Wpisz nazwę")]
        public required string Name { get; set; }
        [StringLength(600, ErrorMessage = "Przekroczony limit znaków")]
        public required string Desc { get; set; }
  
     
        public ICollection<Film> Films { get; set; }
    }
}
