using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UKW_sklep.czw.DAL;

namespace UKW_sklep.czw.ViewComonents
{
    public class MenuViewComonent : ViewComponent
    {
        FilmsContext _context;
        public MenuViewComonent(FilmsContext context)
        {
            _context = context; ;

        }
        public async Task<IViewComponentResult> InvokAsync()
        {

            return await Task.FromResult(View("_Menu", _context.CategoryContext.ToList()));
        }
    }
}
