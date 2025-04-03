using System.ComponentModel.DataAnnotations;

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
        public  int? Id_Id_Category { get; set; }



    }
}
