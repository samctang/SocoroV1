using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Socoro.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffectedColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarrierTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrierTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDBA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDBA2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyAddr1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyAddr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailAddr1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailAddr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoEmployees = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationContainerTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationContainerTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationProcessTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationTypeId = table.Column<int>(type: "int", nullable: false),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationProcessTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Freight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carriers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    CarrierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneExt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyAddr1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyAddr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectConnection = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carriers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carriers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyAddr1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyAddr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentalEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    EmployerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyAddr1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyAddr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailAddr1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailAddr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeNotes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Agent = table.Column<int>(type: "int", nullable: false),
                    Shipper = table.Column<int>(type: "int", nullable: false),
                    Consignee = table.Column<int>(type: "int", nullable: false),
                    AgentRefNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperRefNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeRefNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginAddr1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginAddr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationAddr1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationAddr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier = table.Column<int>(type: "int", nullable: true),
                    Progress = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmittedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operations_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Operations_Employees_EmployeeId",
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
                    EIN = table.Column<int>(type: "int", nullable: false),
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
                name: "OperationInsurances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Freight = table.Column<int>(type: "int", nullable: false),
                    Duties = table.Column<int>(type: "int", nullable: false),
                    OtherCosts = table.Column<int>(type: "int", nullable: false),
                    VoluntaryCoverage = table.Column<int>(type: "int", nullable: false),
                    LostProfit = table.Column<int>(type: "int", nullable: false),
                    OperationId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationInsurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationInsurances_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OperationProcesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationProcesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationProcesses_Operations_OperationId",
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
                    Commodities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marks = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "OperationTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    OperationProcessId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationTasks_OperationProcesses_OperationProcessId",
                        column: x => x.OperationProcessId,
                        principalTable: "OperationProcesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carriers_CompanyId",
                table: "Carriers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanyId",
                table: "Customers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeNotes_EmployeeId",
                table: "EmployeeNotes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyId",
                table: "Employees",
                column: "CompanyId");

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
                name: "IX_OperationContainers_OperationCargoId",
                table: "OperationContainers",
                column: "OperationCargoId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationInsurances_OperationId",
                table: "OperationInsurances",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationProcesses_OperationId",
                table: "OperationProcesses",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationQuotes_OperationId",
                table: "OperationQuotes",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_CompanyId",
                table: "Operations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_EmployeeId",
                table: "Operations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationTasks_OperationProcessId",
                table: "OperationTasks",
                column: "OperationProcessId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "CarrierTypes");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CustomerTypes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "EmployeeNotes");

            migrationBuilder.DropTable(
                name: "OperationBookingMessages");

            migrationBuilder.DropTable(
                name: "OperationBookings");

            migrationBuilder.DropTable(
                name: "OperationContainers");

            migrationBuilder.DropTable(
                name: "OperationContainerTypes");

            migrationBuilder.DropTable(
                name: "OperationInsurances");

            migrationBuilder.DropTable(
                name: "OperationProcessTypes");

            migrationBuilder.DropTable(
                name: "OperationQuotes");

            migrationBuilder.DropTable(
                name: "OperationTasks");

            migrationBuilder.DropTable(
                name: "OperationTypes");

            migrationBuilder.DropTable(
                name: "Carriers");

            migrationBuilder.DropTable(
                name: "OperationCargos");

            migrationBuilder.DropTable(
                name: "OperationProcesses");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
