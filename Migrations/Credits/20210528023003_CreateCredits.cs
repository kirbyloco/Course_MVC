using Microsoft.EntityFrameworkCore.Migrations;

namespace course_std.Migrations.Credits
{
    public partial class CreateCredits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Credits",
                columns: table => new
                {
                    Academic = table.Column<string>(type: "TEXT", nullable: true),
                    Schoolsys = table.Column<string>(type: "TEXT", nullable: true),
                    GraduationCredits = table.Column<string>(type: "TEXT", nullable: true),
                    GeneralCredits = table.Column<string>(type: "TEXT", nullable: true),
                    RequiredCredits = table.Column<string>(type: "TEXT", nullable: true),
                    ElectiveCredits = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credits");
        }
    }
}
