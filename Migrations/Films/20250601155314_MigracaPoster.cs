using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UKW_sklep.czw.Migrations.Films
{
    /// <inheritdoc />
    public partial class MigracaPoster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryContext",
                columns: table => new
                {
                    Id_Category = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryContext", x => x.Id_Category);
                });

            migrationBuilder.CreateTable(
                name: "FilmContex",
                columns: table => new
                {
                    Id_Film = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmContex", x => x.Id_Film);
                    table.ForeignKey(
                        name: "FK_FilmContex_CategoryContext_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryContext",
                        principalColumn: "Id_Category",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryContext",
                columns: new[] { "Id_Category", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "High-paced movies with lots of physical activity and stunts.", "Action" },
                    { 2, "Movies designed to make the audience laugh.", "Comedy" },
                    { 3, "Movies with a focus on realistic storytelling and emotional themes.", "Drama" },
                    { 4, "Movies intended to scare or unsettle the audience.", "Horror" },
                    { 5, "Science fiction movies that often involve futuristic technology and space exploration.", "Sci-Fi" },
                    { 6, "Movies that focus on romantic relationships.", "Romance" },
                    { 7, "Movies that are suspenseful and keep the audience on the edge of their seats.", "Thriller" },
                    { 8, "Movies that include magical or supernatural elements.", "Fantasy" },
                    { 9, "Movies that provide a factual representation of real events.", "Documentary" },
                    { 10, "Movies that use animated images to tell a story.", "Animation" }
                });

            migrationBuilder.InsertData(
                table: "FilmContex",
                columns: new[] { "Id_Film", "CategoryId", "Desc", "Director", "Poster", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 5, "A mind-bending thriller about dreams within dreams.", "Christopher Nolan", "Inception.png", 24.99m, "Inception" },
                    { 2, 3, "A powerful crime drama about an Italian-American mafia family.", "Francis Ford Coppola", "The_God_father.png", 19.99m, "The Godfather" },
                    { 3, 1, "A gripping superhero film featuring Batman's battle against the Joker.", "Christopher Nolan", "The_Dark_Knight.png", 22.49m, "The Dark Knight" },
                    { 4, 3, "A nonlinear narrative that interweaves various crime stories.", "Quentin Tarantino", "Pulp_Fiction.png", 17.99m, "Pulp Fiction" },
                    { 5, 9, "A poignant historical drama about the Holocaust.", "Steven Spielberg", "Schindlers_List.png", 21.99m, "Schindler's List" },
                    { 6, 5, "A revolutionary sci-fi film about a dystopian future and virtual reality.", "Lana Wachowski, Lilly Wachowski", "The_Matrix.png", 26.99m, "The Matrix" },
                    { 7, 3, "A psychological drama exploring identity and consumer culture.", "David Fincher", "Fight_Club.png", 18.49m, "Fight Club" },
                    { 8, 3, "A heartwarming tale of an unlikely hero's journey through life.", "Robert Zemeckis", "Forrest_Gump.png", 16.99m, "Forrest Gump" },
                    { 9, 3, "A story of hope and friendship within the walls of a prison.", "Frank Darabont", "The_Shawshank_Redemption.png", 20.99m, "The Shawshank Redemption" },
                    { 10, 8, "The epic adventure of a hobbit and his quest to destroy a powerful ring.", "Peter Jackson", "The_Lord_of_the_Rings.png", 29.99m, "The Lord of the Rings: The Fellowship of the Ring" },
                    { 11, 5, "The beginning of an epic space saga.", "George Lucas", "Star Wars_Episode_IV.png", 27.99m, "Star Wars: Episode IV - A New Hope" },
                    { 12, 1, "A story of revenge and redemption in ancient Rome.", "Ridley Scott", "Gladiator.png", 22.99m, "Gladiator" },
                    { 13, 4, "A chilling thriller featuring a brilliant but deranged serial killer.", "Jonathan Demme", "The_Silence_of_the_Lambs.png", 19.99m, "The Silence of the Lambs" },
                    { 14, 5, "A sci-fi adventure about a theme park with genetically engineered dinosaurs.", "Steven Spielberg", "Jurassic_Park.png", 25.49m, "Jurassic Park" },
                    { 15, 10, "An animated classic about a lion cub's journey to adulthood and kingship.", "Roger Allers, Rob Minkoff", "The_Lion_King.png", 14.99m, "The Lion King" },
                    { 16, 6, "A romantic drama set against the backdrop of the ill-fated Titanic voyage.", "James Cameron", "Titanic.png", 23.99m, "Titanic" },
                    { 17, 5, "A visually stunning sci-fi epic set on the alien world of Pandora.", "James Cameron", "Avatar.png", 28.99m, "Avatar" },
                    { 18, 3, "A harrowing World War II drama about a mission to save a soldier.", "Steven Spielberg", "Saving_Private_Ryan.png", 21.49m, "Saving Private Ryan" },
                    { 19, 5, "A sci-fi epic exploring space travel and the quest to save humanity.", "Christopher Nolan", "Interstellar.png", 27.49m, "Interstellar" },
                    { 20, 3, "A supernatural drama set on death row in a Southern prison.", "Frank Darabont", "The_Green_Mile.png", 18.99m, "The Green Mile" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmContex_CategoryId",
                table: "FilmContex",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmContex");

            migrationBuilder.DropTable(
                name: "CategoryContext");
        }
    }
}
