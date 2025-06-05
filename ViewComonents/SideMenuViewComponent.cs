using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UKW_sklep.czw.DAL;

namespace UKW_sklep.czw.ViewComonents
{
    
        public class MenuViewComponent : ViewComponent
        {
        FilmsContext db;
            public MenuViewComponent(FilmsContext db)
            {
                this.db = db;
            }
        public async Task<IViewComponentResult> InvokeAsync(string categoryName)
        {
            var category = db.CategoryContext.Include("Film").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).FirstOrDefault();
            var films = category.Films.OrderBy(f => f.Title).ToList();
            return await Task.FromResult(View("_SideMenu", films));
        }
    }
    
}
