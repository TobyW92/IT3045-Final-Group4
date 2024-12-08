using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IT3045_Final_Group4.Migrations.TreeTable
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    BroughtBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "Birthday", "BroughtBy", "Email", "Height", "PhoneNumber", "TreeType" },
                values: new object[,]
                {
                    { 1, "1990-05-15", "Alice", "alice@example.com", 20.5, "123-456-7890", "Oak" },
                    { 2, "1985-03-20", "Bob", "bob@example.com", 30.0, "987-654-3210", "Pine" },
                    { 3, "2000-08-10", "Charlie", "charlie@example.com", 25.300000000000001, "456-789-0123", "Maple" },
                    { 4, "1995-12-25", "David", "david@example.com", 15.699999999999999, "321-654-9870", "Birch" },
                    { 5, "1988-11-05", "Eve", "eve@example.com", 18.199999999999999, "213-546-7890", "Cedar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trees");
        }
    }
}
