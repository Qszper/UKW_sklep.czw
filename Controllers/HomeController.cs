using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UKW_sklep.czw.DAL;
using UKW_sklep.czw.Models;

namespace UKW_sklep.czw.Controllers { 

public class HomeController : Controller
{
        FilmsContext db;

    public HomeController(FilmsContext db)
    {
        this.db = db;
    }

    public IActionResult Index()
    {
        var kategorie = db.CategoryContext.ToList();

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult footerSites(string viewName)
    {
        return View(viewName);
    }
} }