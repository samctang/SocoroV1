using Microsoft.EntityFrameworkCore.Migrations;

namespace Socoro.Infrastructure.Migrations
{
    public partial class customertypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerType",
                table: "CustomerType");

            migrationBuilder.RenameTable(
                name: "CustomerType",
                newName: "CustomerTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerTypes",
                table: "CustomerTypes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerTypes",
                table: "CustomerTypes");

            migrationBuilder.RenameTable(
                name: "CustomerTypes",
                newName: "CustomerType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerType",
                table: "CustomerType",
                column: "Id");
        }
    }
}
