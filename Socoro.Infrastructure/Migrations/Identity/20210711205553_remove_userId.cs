using Microsoft.EntityFrameworkCore.Migrations;

namespace Socoro.Infrastructure.Migrations.Identity
{
    public partial class remove_userId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "Identity",
                table: "Employee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                schema: "Identity",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
