using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Socoro.Infrastructure.Migrations
{
    public partial class booking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperationBookingMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    CarrierId = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationBookingMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationBookingMessages_Carriers_CarrierId",
                        column: x => x.CarrierId,
                        principalTable: "Carriers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OperationBookingMessages_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OperationCargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoadingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoadingTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bonded = table.Column<bool>(type: "bit", nullable: false),
                    Propelled = table.Column<bool>(type: "bit", nullable: false),
                    NoContainers = table.Column<int>(type: "int", nullable: false),
                    OperationId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationCargos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationCargos_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OperationQuotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profit = table.Column<int>(type: "int", nullable: false),
                    Documentation = table.Column<int>(type: "int", nullable: false),
                    FF = table.Column<int>(type: "int", nullable: false),
                    VGM = table.Column<int>(type: "int", nullable: false),
                    Inland = table.Column<int>(type: "int", nullable: false),
                    Others = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationQuotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationQuotes_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Containers",
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
                    OperationId = table.Column<int>(type: "int", nullable: true),
                    OperationCargoId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Containers_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OperationBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vessel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Voyage = table.Column<int>(type: "int", nullable: false),
                    DocumentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocumentTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CargoDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CargoTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    VGMDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ramp = table.Column<bool>(type: "bit", nullable: false),
                    RampDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OperationCargoId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationBookings_OperationCargos_OperationCargoId",
                        column: x => x.OperationCargoId,
                        principalTable: "OperationCargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Containers_OperationCargoId",
                table: "Containers",
                column: "OperationCargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_OperationId",
                table: "Containers",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationBookingMessages_CarrierId",
                table: "OperationBookingMessages",
                column: "CarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationBookingMessages_EmployeeId",
                table: "OperationBookingMessages",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationBookings_OperationCargoId",
                table: "OperationBookings",
                column: "OperationCargoId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationCargos_OperationId",
                table: "OperationCargos",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationQuotes_OperationId",
                table: "OperationQuotes",
                column: "OperationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Containers");

            migrationBuilder.DropTable(
                name: "OperationBookingMessages");

            migrationBuilder.DropTable(
                name: "OperationBookings");

            migrationBuilder.DropTable(
                name: "OperationQuotes");

            migrationBuilder.DropTable(
                name: "OperationCargos");
        }
    }
}
