using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IT3045_Final_Group4.Migrations.TeamMember
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearInProgram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(1992, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Associate of Applied Business in Information Technology", "Toby Wright", "Freshman" },
                    { 2, new DateTime(1995, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Associate of Applied Business in Information Technology", "John Penn", "Sophomore" },
                    { 3, new DateTime(1998, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clermont Certificate in Information Technology", "Matt Glazier", "Sophomore" },
                    { 4, new DateTime(2005, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor of Science in Cybersecurity", "Leslie Alonge", "Sophomore" },
                    { 5, new DateTime(1998, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Associate of Applied Business in Information Technology", "Kellen Hubbard", "Sophomore" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
