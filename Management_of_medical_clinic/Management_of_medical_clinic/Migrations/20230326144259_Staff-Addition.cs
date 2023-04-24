using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class StaffAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    IdPatient = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    PESEL = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Sex = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<short>(type: "INTEGER", nullable: false),
                    DateLastVisit = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.IdPatient);
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    IdVisit = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateVisit = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HourVisit = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CostVisit = table.Column<decimal>(type: "TEXT", nullable: false),
                    IdEmployee = table.Column<int>(type: "INTEGER", nullable: true),
                    IdPatient = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.IdVisit);
                    table.ForeignKey(
                        name: "FK_Visit_DbEmployees_IdPatient",
                        column: x => x.IdPatient,
                        principalTable: "DbEmployees",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visit_Patient_IdPatient",
                        column: x => x.IdPatient,
                        principalTable: "Patient",
                        principalColumn: "IdPatient",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "DateOfBirth", "FirstName", "IsActive", "LastName", "DateLastVisit", "PESEL", "Sex" },
                values: new object[] { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", (short)1, "Doe", null, "12345678901", 1 });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "DateOfBirth", "FirstName", "IsActive", "LastName", "DateLastVisit", "PESEL", "Sex" },
                values: new object[] { 2, new DateTime(1995, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", (short)1, "Doe", null, "23456789012", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Visit_IdPatient",
                table: "Visit",
                column: "IdPatient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
