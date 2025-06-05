using Microsoft.EntityFrameworkCore;



using UKW_sklep.czw.Models;

namespace UKW_sklep.czw.DAL;
public class FilmsContext : DbContext
{

    public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
    {
    }



    public DbSet<Film> FilmContex { get; set; }

    public DbSet<Category> CategoryContext { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var categories = new List<Category>()
        {
            new Category { Id_Category = 1, Name = "Action", Desc = "High-paced movies with lots of physical activity and stunts." },
            new Category { Id_Category = 2, Name = "Comedy", Desc = "Movies designed to make the audience laugh." },
            new Category { Id_Category = 3, Name = "Drama", Desc = "Movies with a focus on realistic storytelling and emotional themes." },
            new Category { Id_Category = 4, Name = "Horror", Desc = "Movies intended to scare or unsettle the audience." },
            new Category { Id_Category = 5, Name = "Sci-Fi", Desc = "Science fiction movies that often involve futuristic technology and space exploration." },
            new Category { Id_Category = 6, Name = "Romance", Desc = "Movies that focus on romantic relationships." },
            new Category { Id_Category = 7, Name = "Thriller", Desc = "Movies that are suspenseful and keep the audience on the edge of their seats." },
            new Category { Id_Category = 8, Name = "Fantasy", Desc = "Movies that include magical or supernatural elements." },
            new Category { Id_Category = 9, Name = "Documentary", Desc = "Movies that provide a factual representation of real events." },
            new Category { Id_Category = 10, Name = "Animation", Desc = "Movies that use animated images to tell a story." }

        };
        var films = new List<Film>()
{
    new Film { Poster ="Inception.png", Id_Film = 1, Title = "Inception", Director = "Christopher Nolan", Desc = "A mind-bending thriller about dreams within dreams.", Price = 24.99m, CategoryId = 5 },
    new Film { Poster ="The_God_father.png", Id_Film = 2, Title = "The Godfather", Director = "Francis Ford Coppola", Desc = "A powerful crime drama about an Italian-American mafia family.", Price = 19.99m, CategoryId = 3 },
    new Film { Poster ="The_Dark_Knight.png", Id_Film = 3, Title = "The Dark Knight", Director = "Christopher Nolan", Desc = "A gripping superhero film featuring Batman's battle against the Joker.", Price = 22.49m, CategoryId = 1 },
    new Film { Poster ="Pulp_Fiction.png", Id_Film = 4, Title = "Pulp Fiction", Director = "Quentin Tarantino", Desc = "A nonlinear narrative that interweaves various crime stories.", Price = 17.99m, CategoryId = 3 },
    new Film { Poster ="Schindlers_List.png", Id_Film = 5, Title = "Schindler's List", Director = "Steven Spielberg", Desc = "A poignant historical drama about the Holocaust.", Price = 21.99m, CategoryId = 9 },
    new Film { Poster ="The_Matrix.png", Id_Film = 6, Title = "The Matrix", Director = "Lana Wachowski, Lilly Wachowski", Desc = "A revolutionary sci-fi film about a dystopian future and virtual reality.", Price = 26.99m, CategoryId = 5 },
    new Film { Poster ="Fight_Club.png", Id_Film = 7, Title = "Fight Club", Director = "David Fincher", Desc = "A psychological drama exploring identity and consumer culture.", Price = 18.49m, CategoryId = 3 },
    new Film { Poster ="Forrest_Gump.png", Id_Film = 8, Title = "Forrest Gump", Director = "Robert Zemeckis", Desc = "A heartwarming tale of an unlikely hero's journey through life.", Price = 16.99m, CategoryId = 3 },
    new Film { Poster ="The_Shawshank_Redemption.png", Id_Film = 9, Title = "The Shawshank Redemption", Director = "Frank Darabont", Desc = "A story of hope and friendship within the walls of a prison.", Price = 20.99m, CategoryId = 3 },
    new Film { Poster ="The_Lord_of_the_Rings.png", Id_Film = 10, Title = "The Lord of the Rings: The Fellowship of the Ring", Director = "Peter Jackson", Desc = "The epic adventure of a hobbit and his quest to destroy a powerful ring.", Price = 29.99m, CategoryId = 8 },
    new Film { Poster ="Star Wars_Episode_IV.png", Id_Film = 11, Title = "Star Wars: Episode IV - A New Hope", Director = "George Lucas", Desc = "The beginning of an epic space saga.", Price = 27.99m, CategoryId = 5 },
    new Film { Poster ="Gladiator.png", Id_Film = 12, Title = "Gladiator", Director = "Ridley Scott", Desc = "A story of revenge and redemption in ancient Rome.", Price = 22.99m, CategoryId = 1 },
    new Film { Poster ="The_Silence_of_the_Lambs.png", Id_Film = 13, Title = "The Silence of the Lambs", Director = "Jonathan Demme", Desc = "A chilling thriller featuring a brilliant but deranged serial killer.", Price = 19.99m, CategoryId = 4 },
    new Film { Poster ="Jurassic_Park.png", Id_Film = 14, Title = "Jurassic Park", Director = "Steven Spielberg", Desc = "A sci-fi adventure about a theme park with genetically engineered dinosaurs.", Price = 25.49m, CategoryId = 5 },
    new Film { Poster ="The_Lion_King.png", Id_Film = 15, Title = "The Lion King", Director = "Roger Allers, Rob Minkoff", Desc = "An animated classic about a lion cub's journey to adulthood and kingship.", Price = 14.99m, CategoryId = 10 },
    new Film { Poster ="Titanic.png", Id_Film = 16, Title = "Titanic", Director = "James Cameron", Desc = "A romantic drama set against the backdrop of the ill-fated Titanic voyage.", Price = 23.99m, CategoryId = 6 },
    new Film { Poster ="Avatar.png", Id_Film = 17, Title = "Avatar", Director = "James Cameron", Desc = "A visually stunning sci-fi epic set on the alien world of Pandora.", Price = 28.99m, CategoryId = 5 },
    new Film { Poster ="Saving_Private_Ryan.png", Id_Film = 18, Title = "Saving Private Ryan", Director = "Steven Spielberg", Desc = "A harrowing World War II drama about a mission to save a soldier.", Price = 21.49m, CategoryId = 3 },
    new Film { Poster ="Interstellar.png", Id_Film = 19, Title = "Interstellar", Director = "Christopher Nolan", Desc = "A sci-fi epic exploring space travel and the quest to save humanity.", Price = 27.49m, CategoryId = 5 },
    new Film { Poster ="The_Green_Mile.png", Id_Film = 20, Title = "The Green Mile", Director = "Frank Darabont", Desc = "A supernatural drama set on death row in a Southern prison.", Price = 18.99m, CategoryId = 3 }
};
        modelBuilder.Entity<Category>().HasData(categories);
        modelBuilder.Entity<Film>().HasData(films);
    }



}


