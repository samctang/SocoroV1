using Microsoft.EntityFrameworkCore.Migrations;

namespace Socoro.Infrastructure.Migrations
{
    public partial class container : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Containers_Operations_OperationId",
                table: "Containers");

            migrationBuilder.DropIndex(
                name: "IX_Containers_OperationId",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "OperationId",
                table: "Containers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OperationId",
                table: "Containers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Containers_OperationId",
                table: "Containers",
                column: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_Operations_OperationId",
                table: "Containers",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
