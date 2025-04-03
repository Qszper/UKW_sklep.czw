using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UKW_sklep.czw.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAtegoryContext",
                columns: table => new
                {
                    Id_Category = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Desc = table.Column<int>(type: "int", nullable: false),
                    Id_Id_Film = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAtegoryContext", x => x.Id_Category);
                });

            migrationBuilder.CreateTable(
                name: "FilmContex",
                columns: table => new
                {
                    Id_Film = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<int>(type: "int", maxLength: 600, nullable: false),
                    Desc = table.Column<int>(type: "int", nullable: false),
                    Id_Id_Catefory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmContex", x => x.Id_Film);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAtegoryContext");

            migrationBuilder.DropTable(
                name: "FilmContex");
        }
    }
}
