using Microsoft.EntityFrameworkCore;
using UKW_sklep.czw;
using UKW_sklep.czw.DAL;
using UKW_sklep.czw.Models.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<FilmsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb")));
builder.Services.AddDbContext<IdentityAppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb")));

builder.Services.AddSession();

builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 4;
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<IdentityAppContext>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "StaticSites",
    pattern: "Info/{siteName}",
    defaults: new { controller = "FIlms", action = "FilmsList" }
    
    );

app.MapControllerRoute(
    name: "Details",
    pattern: "{action}/{Id_Film}",
    defaults: new { controller = "Films", action = "Details" }
    );
app.MapControllerRoute(
    name: "StaticSites",
    pattern: "Info/{viewName}",
    defaults: new { Controller = "Home", action = "footerSites" });
app.MapControllerRoute(
    name: "Categories",
    pattern: "{categoryName}",
    defaults: new { Controller = "Films", action = "FilmsList" });
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
