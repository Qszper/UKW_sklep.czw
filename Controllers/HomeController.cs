using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UKW_sklep.czw.Models;

namespace UKW_sklep.czw.Controllers
{
    public class HomeController : Controller
    {
        
        DbContext _context;
       

        public HomeController(DbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var categories = _context.CategoryContext.ToList();  
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult FooterSize(string siteName)
        {
            return View(siteName);

        }
      
    }
}
