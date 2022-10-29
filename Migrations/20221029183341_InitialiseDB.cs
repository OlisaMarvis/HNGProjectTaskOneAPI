using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HNGProjectTaskOneAPI.Migrations
{
    public partial class InitialiseDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HNGStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    slackUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    backend = table.Column<bool>(type: "bit", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HNGStudents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HNGStudents",
                columns: new[] { "Id", "age", "backend", "bio", "slackUsername" },
                values: new object[] { 1, 30, true, "I am a backend developer", "Olisaemeka" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HNGStudents");
        }
    }
}
