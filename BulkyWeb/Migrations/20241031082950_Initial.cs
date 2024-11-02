using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyWeb.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Action" },
                    { 2, 2, "SciFi" },
                    { 3, 3, "Action" },
                    { 4, 4, "Adventure" },
                    { 5, 5, "Animation" },
                    { 6, 6, "Biography" },
                    { 7, 7, "Comedy" },
                    { 8, 8, "Crime" },
                    { 9, 9, "Documentary" },
                    { 10, 10, "Drama" },
                    { 11, 11, "Family" },
                    { 12, 12, "Fantasy" },
                    { 13, 13, "Film Noir" },
                    { 14, 14, "History" },
                    { 15, 15, "Horror" },
                    { 16, 16, "Musical" },
                    { 17, 17, "Mystery" },
                    { 18, 18, "Romance" },
                    { 19, 19, "SciFi" },
                    { 20, 20, "Short" },
                    { 21, 21, "Sport" },
                    { 22, 22, "Superhero" },
                    { 23, 23, "Thriller" },
                    { 24, 24, "War" },
                    { 25, 25, "Western" },
                    { 26, 26, "Action" },
                    { 27, 27, "Adventure" },
                    { 28, 28, "Animation" },
                    { 29, 29, "Biography" },
                    { 30, 30, "Comedy" },
                    { 31, 31, "Crime" },
                    { 32, 32, "Documentary" },
                    { 33, 33, "Drama" },
                    { 34, 34, "Family" },
                    { 35, 35, "Fantasy" },
                    { 36, 36, "Film Noir" },
                    { 37, 37, "History" },
                    { 38, 38, "Horror" },
                    { 39, 39, "Musical" },
                    { 40, 40, "Mystery" },
                    { 41, 41, "Romance" },
                    { 42, 42, "SciFi" },
                    { 43, 43, "Short" },
                    { 44, 44, "Sport" },
                    { 45, 45, "Superhero" },
                    { 46, 46, "Thriller" },
                    { 47, 47, "War" },
                    { 48, 48, "Western" },
                    { 49, 49, "Action" },
                    { 50, 50, "Adventure" },
                    { 51, 51, "Animation" },
                    { 52, 52, "Biography" },
                    { 53, 53, "Comedy" },
                    { 54, 54, "Crime" },
                    { 55, 55, "Documentary" },
                    { 56, 56, "Drama" },
                    { 57, 57, "Family" },
                    { 58, 58, "Fantasy" },
                    { 59, 59, "Film Noir" },
                    { 60, 60, "History" },
                    { 61, 61, "Horror" },
                    { 62, 62, "Musical" },
                    { 63, 63, "Mystery" },
                    { 64, 64, "Romance" },
                    { 65, 65, "SciFi" },
                    { 66, 66, "Short" },
                    { 67, 67, "Sport" },
                    { 68, 68, "Superhero" },
                    { 69, 69, "Thriller" },
                    { 70, 70, "War" },
                    { 71, 71, "Western" },
                    { 72, 72, "Action" },
                    { 73, 73, "Adventure" },
                    { 74, 74, "Animation" },
                    { 75, 75, "Biography" },
                    { 76, 76, "Comedy" },
                    { 77, 77, "Crime" },
                    { 78, 78, "Documentary" },
                    { 79, 79, "Drama" },
                    { 80, 80, "Family" },
                    { 81, 81, "Fantasy" },
                    { 82, 82, "Film Noir" },
                    { 83, 83, "History" },
                    { 84, 84, "Horror" },
                    { 85, 85, "Musical" },
                    { 86, 86, "Mystery" },
                    { 87, 87, "Romance" },
                    { 88, 88, "SciFi" },
                    { 89, 89, "Short" },
                    { 90, 90, "Sport" },
                    { 91, 91, "Superhero" },
                    { 92, 92, "Thriller" },
                    { 93, 93, "War" },
                    { 94, 94, "Western" },
                    { 95, 95, "Action" },
                    { 96, 96, "Adventure" },
                    { 97, 97, "Animation" },
                    { 98, 98, "Biography" },
                    { 99, 99, "Comedy" },
                    { 100, 100, "Crime" },
                    { 101, 101, "Documentary" },
                    { 102, 102, "Drama" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
