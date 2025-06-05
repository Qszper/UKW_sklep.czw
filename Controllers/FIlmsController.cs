using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UKW_sklep.czw.Models;
using UKW_sklep.czw.DAL;


namespace UKW_sklep.czw.Models
{
    public class FilmsController : Controller
    {
        FilmsContext db;
        IWebHostEnvironment webHost;

        public FilmsController(FilmsContext db, IWebHostEnvironment webHost)
        {
            this.db = db;
            this.webHost = webHost;
        }

        public IActionResult AllFilms()
        {
            return View(db.FilmContex.ToList());
        }

        public IActionResult FilmsList(string categoryName)
        {
            var category = db.CategoryContext.Include("Film").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single();
            var films = category.Films.ToList();
            KategoriaViewModel model = new KategoriaViewModel();
            model.Kategoria = category;
            model.FilmyKategorii = films;
            model.FilmyNajnowsze = db.FilmContex.OrderByDescending(f => f.Id_Film).Take(3);
            return View(films);
        }

        public IActionResult Details(int filmId)
        {
            var film = db.FilmContex.Find(filmId);
            if (film != null)
            {
                db.CategoryContext.Find(film.CategoryId);
            }
            return View(film);
        }
        [HttpGet]
        public IActionResult AddFilm()
        {
            AddViewModel model = new AddViewModel();
            model.AllCategories = db.CategoryContext.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddFilm(AddViewModel model)
        {
            var posterFolderPath = Path.Combine(webHost.WebRootPath, "posters");
            var uniquePosterName = model.Poster.FileName + "_" + Guid.NewGuid() + Path.GetExtension(model.Poster.FileName);
            var filePath = Path.Combine(posterFolderPath, uniquePosterName);
            model.Poster.CopyTo(new FileStream(filePath, FileMode.Create));
            model.NewFilm.Poster = uniquePosterName;
            db.FilmContex.Add(model.NewFilm);
            db.SaveChanges();
            return RedirectToAction("AddFilm");
        }
    }
}