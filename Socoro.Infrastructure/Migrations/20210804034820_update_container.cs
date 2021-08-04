using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Socoro.Infrastructure.Migrations
{
    public partial class update_container : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Containers");

            migrationBuilder.CreateTable(
                name: "OperationContainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    GrossWeight = table.Column<int>(type: "int", nullable: false),
                    CommercialDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hazardous = table.Column<bool>(type: "bit", nullable: false),
                    HazardClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UNCode = table.Column<int>(type: "int", nullable: false),
                    ContainerNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SealNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TareWeight = table.Column<int>(type: "int", nullable: false),
                    OperationCargoId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationContainers_OperationCargos_OperationCargoId",
                        column: x => x.OperationCargoId,
                        principalTable: "OperationCargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OperationContainers_OperationCargoId",
                table: "OperationContainers",
                column: "OperationCargoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationContainers");

            migrationBuilder.CreateTable(
                name: "Containers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommercialDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContainerNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrossWeight = table.Column<int>(type: "int", nullable: false),
                    HazardClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hazardous = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OperationCargoId = table.Column<int>(type: "int", nullable: true),
                    SealNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TareWeight = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    UNCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Containers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Containers_OperationCargos_OperationCargoId",
                        column: x => x.OperationCargoId,
                        principalTable: "OperationCargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Containers_OperationCargoId",
                table: "Containers",
                column: "OperationCargoId");
        }
    }
}
