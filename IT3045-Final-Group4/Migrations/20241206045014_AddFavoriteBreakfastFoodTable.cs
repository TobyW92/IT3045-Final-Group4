using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT3045_Final_Group4.Migrations
{
    /// <inheritdoc />
    public partial class AddFavoriteBreakfastFoodTable : Migration
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteBreakfastFoods");
        }
    }
}
