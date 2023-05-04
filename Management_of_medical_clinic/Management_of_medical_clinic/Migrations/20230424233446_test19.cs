using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class test19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbCalendars",
                columns: table => new
                {
                    IdCalendar = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateReference = table.Column<string>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbCalendars", x => x.IdCalendar);
                });

            migrationBuilder.CreateTable(
                name: "DbSpecializations",
                columns: table => new
                {
                    IdSpecialization = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbSpecializations", x => x.IdSpecialization);
                });

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
                name: "DbEmployees",
                columns: table => new
                {
                    IdEmployee = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    PESEL = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<string>(type: "TEXT", nullable: false),
                    CorrespondenceAddress = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Sex = table.Column<int>(type: "INTEGER", nullable: true),
                    Role = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IdSpecialization = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbEmployees", x => x.IdEmployee);
                    table.ForeignKey(
                        name: "FK_DbEmployees_DbSpecializations_IdSpecialization",
                        column: x => x.IdSpecialization,
                        principalTable: "DbSpecializations",
                        principalColumn: "IdSpecialization",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DbOffices",
                columns: table => new
                {
                    IdOffice = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    Info = table.Column<string>(type: "TEXT", nullable: false),
                    IdSpecialization = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbOffices", x => x.IdOffice);
                    table.ForeignKey(
                        name: "FK_DbOffices_DbSpecializations_IdSpecialization",
                        column: x => x.IdSpecialization,
                        principalTable: "DbSpecializations",
                        principalColumn: "IdSpecialization",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DbUsers",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IdEmployee = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbUsers", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_DbUsers_DbEmployees_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "DbEmployees",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "DbAppointments",
                columns: table => new
                {
                    IdAppointment = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdTerm = table.Column<int>(type: "INTEGER", nullable: false),
                    Cost = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IdCalendar = table.Column<int>(type: "INTEGER", nullable: false),
                    IdEmployee = table.Column<int>(type: "INTEGER", nullable: false),
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false),
                    IdOffice = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbAppointments", x => x.IdAppointment);
                    table.ForeignKey(
                        name: "FK_DbAppointments_DbCalendars_IdCalendar",
                        column: x => x.IdCalendar,
                        principalTable: "DbCalendars",
                        principalColumn: "IdCalendar",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DbAppointments_DbEmployees_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "DbEmployees",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DbAppointments_DbOffices_IdOffice",
                        column: x => x.IdOffice,
                        principalTable: "DbOffices",
                        principalColumn: "IdOffice",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DbAppointments_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "IdPatient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "DateOfBirth", "FirstName", "IsActive", "LastName", "DateLastVisit", "PESEL", "Sex" },
                values: new object[] { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan Pablo", (short)1, "Rodriguez", null, "90010100191", 1 });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "DateOfBirth", "FirstName", "IsActive", "LastName", "DateLastVisit", "PESEL", "Sex" },
                values: new object[] { 2, new DateTime(1995, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janina", (short)1, "Pumpernikiel", null, "95020200222", 2 });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "DateOfBirth", "FirstName", "IsActive", "LastName", "DateLastVisit", "PESEL", "Sex" },
                values: new object[] { 3, new DateTime(1970, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aleksander I", (short)1, "Romanow", null, "70120300913", 1 });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "DateOfBirth", "FirstName", "IsActive", "LastName", "DateLastVisit", "PESEL", "Sex" },
                values: new object[] { 4, new DateTime(1950, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Żaneta", (short)1, "Skowron-Ćwir", null, "50120300123", 2 });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "DateOfBirth", "FirstName", "IsActive", "LastName", "DateLastVisit", "PESEL", "Sex" },
                values: new object[] { 5, new DateTime(2000, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henryk", (short)1, "Walezy", null, "00320300213", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_DbAppointments_IdCalendar",
                table: "DbAppointments",
                column: "IdCalendar");

            migrationBuilder.CreateIndex(
                name: "IX_DbAppointments_IdEmployee",
                table: "DbAppointments",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_DbAppointments_IdOffice",
                table: "DbAppointments",
                column: "IdOffice");

            migrationBuilder.CreateIndex(
                name: "IX_DbAppointments_PatientId",
                table: "DbAppointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DbEmployees_IdSpecialization",
                table: "DbEmployees",
                column: "IdSpecialization");

            migrationBuilder.CreateIndex(
                name: "IX_DbOffices_IdSpecialization",
                table: "DbOffices",
                column: "IdSpecialization");

            migrationBuilder.CreateIndex(
                name: "IX_DbUsers_IdEmployee",
                table: "DbUsers",
                column: "IdEmployee",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Visit_IdPatient",
                table: "Visit",
                column: "IdPatient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbAppointments");

            migrationBuilder.DropTable(
                name: "DbUsers");

            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropTable(
                name: "DbCalendars");

            migrationBuilder.DropTable(
                name: "DbOffices");

            migrationBuilder.DropTable(
                name: "DbEmployees");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "DbSpecializations");
        }
    }
}
