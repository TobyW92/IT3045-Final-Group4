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
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "Name", "Developer", "Genre", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Fallout 3", "Bethesda Game Studios", "Action RPG", "October 28, 2008" },
                    { 2, "Fallout 4", "Bethesda Game Studios", "Action RPG", "November 10, 2015" },
                    { 3, "The ELder Scrolls V: Skyrim", "Bethesda Game Studios", "Action RPG", "November 11, 2011" },
                    { 4, "Baldur's Gate 3", "Larian Studios", "Adventure RPG", "August 3, 2023" },
                    { 5, "Mass Effect 2", "Bioware", "Action RPG", "January 26, 2010" }
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
