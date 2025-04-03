using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UKW_sklep.czw.Migrations
{
    /// <inheritdoc />
    public partial class initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CAtegoryContext",
                table: "CAtegoryContext");

            migrationBuilder.DropColumn(
                name: "Id_Id_Catefory",
                table: "FilmContex");

            migrationBuilder.RenameTable(
                name: "CAtegoryContext",
                newName: "CategoryContext");

            migrationBuilder.AlterColumn<string>(
                name: "Director",
                table: "FilmContex",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 600);

            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "FilmContex",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id_Id_Category",
                table: "FilmContex",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CategoryContext",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Id_Film",
                table: "CategoryContext",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "CategoryContext",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryContext",
                table: "CategoryContext",
                column: "Id_Category");

            migrationBuilder.InsertData(
                table: "CategoryContext",
                columns: new[] { "Id_Category", "Desc", "Id_Id_Film", "Name" },
                values: new object[,]
                {
                    { 1, "High-paced movies with lots of physical activity and stunts.", null, "Action" },
                    { 2, "Movies designed to make the audience laugh.", null, "Comedy" },
                    { 3, "Movies with a focus on realistic storytelling and emotional themes.", null, "Drama" },
                    { 4, "Movies intended to scare or unsettle the audience.", null, "Horror" },
                    { 5, "Science fiction movies that often involve futuristic technology and space exploration.", null, "Sci-Fi" },
                    { 6, "Movies that focus on romantic relationships.", null, "Romance" },
                    { 7, "Movies that are suspenseful and keep the audience on the edge of their seats.", null, "Thriller" },
                    { 8, "Movies that include magical or supernatural elements.", null, "Fantasy" },
                    { 9, "Movies that provide a factual representation of real events.", null, "Documentary" },
                    { 10, "Movies that use animated images to tell a story.", null, "Animation" }
                });

            migrationBuilder.InsertData(
                table: "FilmContex",
                columns: new[] { "Id_Film", "Desc", "Director", "Id_Id_Category", "Title" },
                values: new object[,]
                {
                    { 1, "A mind-bending thriller about dreams within dreams.", "Christopher Nolan", null, "Inception" },
                    { 2, "A powerful crime drama about an Italian-American mafia family.", "Francis Ford Coppola", null, "The Godfather" },
                    { 3, "A gripping superhero film featuring Batman's battle against the Joker.", "Christopher Nolan", null, "The Dark Knight" },
                    { 4, "A nonlinear narrative that interweaves various crime stories.", "Quentin Tarantino", null, "Pulp Fiction" },
                    { 5, "A poignant historical drama about the Holocaust.", "Steven Spielberg", null, "Schindler's List" },
                    { 6, "A revolutionary sci-fi film about a dystopian future and virtual reality.", "Lana Wachowski, Lilly Wachowski", null, "The Matrix" },
                    { 7, "A psychological drama exploring identity and consumer culture.", "David Fincher", null, "Fight Club" },
                    { 8, "A heartwarming tale of an unlikely hero's journey through life.", "Robert Zemeckis", null, "Forrest Gump" },
                    { 9, "A story of hope and friendship within the walls of a prison.", "Frank Darabont", null, "The Shawshank Redemption" },
                    { 10, "The epic adventure of a hobbit and his quest to destroy a powerful ring.", "Peter Jackson", null, "The Lord of the Rings: The Fellowship of the Ring" },
                    { 11, "The beginning of an epic space saga.", "George Lucas", null, "Star Wars: Episode IV - A New Hope" },
                    { 12, "A story of revenge and redemption in ancient Rome.", "Ridley Scott", null, "Gladiator" },
                    { 13, "A chilling thriller featuring a brilliant but deranged serial killer.", "Jonathan Demme", null, "The Silence of the Lambs" },
                    { 14, "A sci-fi adventure about a theme park with genetically engineered dinosaurs.", "Steven Spielberg", null, "Jurassic Park" },
                    { 15, "An animated classic about a lion cub's journey to adulthood and kingship.", "Roger Allers, Rob Minkoff", null, "The Lion King" },
                    { 16, "A romantic drama set against the backdrop of the ill-fated Titanic voyage.", "James Cameron", null, "Titanic" },
                    { 17, "A visually stunning sci-fi epic set on the alien world of Pandora.", "James Cameron", null, "Avatar" },
                    { 18, "A harrowing World War II drama about a mission to save a soldier.", "Steven Spielberg", null, "Saving Private Ryan" },
                    { 19, "A sci-fi epic exploring space travel and the quest to save humanity.", "Christopher Nolan", null, "Interstellar" },
                    { 20, "A supernatural drama set on death row in a Southern prison.", "Frank Darabont", null, "The Green Mile" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryContext",
                table: "CategoryContext");

            migrationBuilder.DeleteData(
                table: "CategoryContext",
                keyColumn: "Id_Category",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryContext",
                keyColumn: "Id_Category",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryContext",
                keyColumn: "Id_Category",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryContext",
                keyColumn: "Id_Category",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryContext",
                keyColumn: "Id_Category",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryContext",
                keyColumn: "Id_Category",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CategoryContext",
                keyColumn: "Id_Category",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CategoryContext",
                keyColumn: "Id_Category",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CategoryContext",
                keyColumn: "Id_Category",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CategoryContext",
                keyColumn: "Id_Category",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FilmContex",
                keyColumn: "Id_Film",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "Id_Id_Category",
                table: "FilmContex");

            migrationBuilder.RenameTable(
                name: "CategoryContext",
                newName: "CAtegoryContext");

            migrationBuilder.AlterColumn<int>(
                name: "Director",
                table: "FilmContex",
                type: "int",
                maxLength: 600,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600);

            migrationBuilder.AlterColumn<int>(
                name: "Desc",
                table: "FilmContex",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Id_Id_Catefory",
                table: "FilmContex",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "CAtegoryContext",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Id_Film",
                table: "CAtegoryContext",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Desc",
                table: "CAtegoryContext",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAtegoryContext",
                table: "CAtegoryContext",
                column: "Id_Category");
        }
    }
}
