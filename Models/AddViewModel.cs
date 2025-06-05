namespace UKW_sklep.czw.Models
{
    public class AddViewModel
    {
        public Film NewFilm { get; set; }
        public IFormFile Poster { get; set; }
        public List<Category> AllCategories { get; set; }
    }
}