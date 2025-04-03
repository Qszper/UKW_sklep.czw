using Microsoft.EntityFrameworkCore;



using UKW_sklep.czw.Models;


public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{

    public DbContext(DbContextOptions<DbContext> options) : base(options)
    {
    }



    public DbSet<Film> FilmContex { get; set; }

    public DbSet<Category> CategoryContext { set; get; }

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
            new Film { Id_Film = 1, Title = "Inception", Director = "Christopher Nolan", Desc = "A mind-bending thriller about dreams within dreams." },
            new Film { Id_Film = 2, Title = "The Godfather", Director = "Francis Ford Coppola", Desc = "A powerful crime drama about an Italian-American mafia family." },
            new Film { Id_Film = 3, Title = "The Dark Knight", Director = "Christopher Nolan", Desc = "A gripping superhero film featuring Batman's battle against the Joker." },
            new Film { Id_Film = 4, Title = "Pulp Fiction", Director = "Quentin Tarantino", Desc = "A nonlinear narrative that interweaves various crime stories." },
            new Film { Id_Film = 5, Title = "Schindler's List", Director = "Steven Spielberg", Desc = "A poignant historical drama about the Holocaust." },
            new Film { Id_Film = 6, Title = "The Matrix", Director = "Lana Wachowski, Lilly Wachowski", Desc = "A revolutionary sci-fi film about a dystopian future and virtual reality." },
            new Film { Id_Film = 7, Title = "Fight Club", Director = "David Fincher", Desc = "A psychological drama exploring identity and consumer culture." },
            new Film { Id_Film = 8, Title = "Forrest Gump", Director = "Robert Zemeckis", Desc = "A heartwarming tale of an unlikely hero's journey through life." },
            new Film { Id_Film = 9, Title = "The Shawshank Redemption", Director = "Frank Darabont", Desc = "A story of hope and friendship within the walls of a prison." },
            new Film { Id_Film = 10, Title = "The Lord of the Rings: The Fellowship of the Ring", Director = "Peter Jackson", Desc = "The epic adventure of a hobbit and his quest to destroy a powerful ring." },
            new Film { Id_Film = 11, Title = "Star Wars: Episode IV - A New Hope", Director = "George Lucas", Desc = "The beginning of an epic space saga." },
            new Film { Id_Film = 12, Title = "Gladiator", Director = "Ridley Scott", Desc = "A story of revenge and redemption in ancient Rome." },
            new Film { Id_Film = 13, Title = "The Silence of the Lambs", Director = "Jonathan Demme", Desc = "A chilling thriller featuring a brilliant but deranged serial killer." },
            new Film { Id_Film = 14, Title = "Jurassic Park", Director = "Steven Spielberg", Desc = "A sci-fi adventure about a theme park with genetically engineered dinosaurs." },
            new Film { Id_Film = 15, Title = "The Lion King", Director = "Roger Allers, Rob Minkoff", Desc = "An animated classic about a lion cub's journey to adulthood and kingship." },
            new Film { Id_Film = 16, Title = "Titanic", Director = "James Cameron", Desc = "A romantic drama set against the backdrop of the ill-fated Titanic voyage." },
            new Film { Id_Film = 17, Title = "Avatar", Director = "James Cameron", Desc = "A visually stunning sci-fi epic set on the alien world of Pandora." },
            new Film { Id_Film = 18, Title = "Saving Private Ryan", Director = "Steven Spielberg", Desc = "A harrowing World War II drama about a mission to save a soldier." },
            new Film { Id_Film = 19, Title = "Interstellar", Director = "Christopher Nolan", Desc = "A sci-fi epic exploring space travel and the quest to save humanity." },
            new Film { Id_Film = 20, Title = "The Green Mile", Director = "Frank Darabont", Desc = "A supernatural drama set on death row in a Southern prison." }

        };
        modelBuilder.Entity<Category>().HasData(categories);
        modelBuilder.Entity<Film>().HasData(films);
    }



}


