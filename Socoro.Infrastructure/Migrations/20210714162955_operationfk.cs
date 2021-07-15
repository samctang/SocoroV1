using Microsoft.EntityFrameworkCore.Migrations;

namespace Socoro.Infrastructure.Migrations
{
    public partial class operationfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Operations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Operations_EmployeeId",
                table: "Operations",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Employees_EmployeeId",
                table: "Operations",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Employees_EmployeeId",
                table: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_Operations_EmployeeId",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Operations");
        }
    }
}
