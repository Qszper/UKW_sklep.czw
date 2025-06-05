using Microsoft.AspNetCore.Mvc;
using UKW_sklep.czw.DAL;
using UKW_sklep.czw.Infrastructure;
using UKW_sklep.czw.Models;


namespace UKW_sklep.czw.Controllers
{
    public class CartController : Controller
    {
        FilmsContext db;
        public CartController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var cart = CartManager.GetItems(HttpContext.Session);
            ViewBag.Total = CartManager.GetCartValue(HttpContext.Session);
            return View(cart);
        }
        public IActionResult AddToCart(int Id_film /*, string returnUrl = null*/)
        {
            CartManager.AddToCart(HttpContext.Session, Id_film, db);
            //if (!string.IsNullOrEmpty(returnUrl))
            //{
            //    return Redirect(returnUrl);
            //}
            return RedirectToAction("Index");
        }
        public IActionResult RemoveFromCart(int id)
        {
            var model = new RemoveViewModel()
            {
                itemId = id,
                itemQuantity = CartManager.RemoveFromCart(HttpContext.Session, id),
                cartValue = CartManager.GetCartValue(HttpContext.Session)
            };
            return Json(model);
        }
    }
}
