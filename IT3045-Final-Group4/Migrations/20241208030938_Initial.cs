using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IT3045_Final_Group4.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteBreakfastFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beverage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Popular = table.Column<bool>(type: "bit", nullable: false),
                    ServingSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteBreakfastFoods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteBreakfastFoods",
                columns: new[] { "Id", "Beverage", "Calories", "Name", "Popular", "ServingSize" },
                values: new object[,]
                {
                    { 1, "Orange Juice", 350, "Pancakes", true, "Medium" },
                    { 2, "Coffee", 400, "Waffles", true, "Large" },
                    { 3, "Tea", 250, "Omelette", true, "Small" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteBreakfastFoods");
        }
    }
}
