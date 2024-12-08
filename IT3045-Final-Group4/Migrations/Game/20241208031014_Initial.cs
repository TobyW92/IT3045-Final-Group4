using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IT3045_Final_Group4.Migrations.Game
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "Developer", "Genre", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Bethesda Game Studios", "Action RPG", "Fallout 3", "October 28, 2008" },
                    { 2, "Bethesda Game Studios", "Action RPG", "Fallout 4", "November 10, 2015" },
                    { 3, "Bethesda Game Studios", "Action RPG", "The Elder Scrolls V: Skyrim", "November 11, 2011" },
                    { 4, "Larian Studios", "Adventure RPG", "Baldur's Gate 3", "August 3, 2023" },
                    { 5, "Bioware", "Action RPG", "Mass Effect 2", "January 26, 2010" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
