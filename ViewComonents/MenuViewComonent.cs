using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UKW_sklep.czw.Models;

namespace UKW_sklep.czw.ViewComonents
{
    public class MenuViewComonent : ViewComponent
    {
        DbContext _context;
        public MenuViewComonent(DbContext context)
        {
            _context = context; ;

        }
        public async Task<IViewComponentResult> InvokAsync()
        {

            return await Task.FromResult(View("_Menu", _context.CategoryContext.ToList()));
        }
    }
}
