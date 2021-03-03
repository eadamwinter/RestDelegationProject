using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestDelegations.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    DateOfEmployment = table.Column<DateTime>(type: "date", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Delegations",
                columns: table => new
                {
                    DelegationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TravelToStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TravelToEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TravelBackStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TravelBackEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delegations", x => x.DelegationId);
                    table.ForeignKey(
                        name: "FK_Delegations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DateOfEmployment", "Name", "Salary", "Surname" },
                values: new object[] { 1, new DateTime(1990, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", 3500m, "Sahara" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DateOfEmployment", "Name", "Salary", "Surname" },
                values: new object[] { 2, new DateTime(1992, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sebastian", 4000m, "Kałamarz" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DateOfEmployment", "Name", "Salary", "Surname" },
                values: new object[] { 3, new DateTime(1985, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feliks", 5500m, "Stasiak" });

            migrationBuilder.InsertData(
                table: "Delegations",
                columns: new[] { "DelegationId", "Code", "Company", "Country", "EmployeeId", "Status", "TravelBackEnd", "TravelBackStart", "TravelToEnd", "TravelToStart" },
                values: new object[,]
                {
                    { 1, "Z64", "VolksWagen", "Germany", 1, "Confirmed", new DateTime(2019, 2, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 2, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 10, 18, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 10, 7, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Z66", "VolksWagen", "Spain", 1, "Confirmed", new DateTime(2018, 12, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 2, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 10, 7, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Z68", "Opel", "Spain", 2, "Confirmed", new DateTime(2017, 4, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 4, 22, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 4, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 4, 10, 7, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Z69", "Skoda", "Czech Republic", 3, "Confirmed", new DateTime(2016, 7, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 7, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 10, 7, 15, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Delegations_EmployeeId",
                table: "Delegations",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delegations");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
