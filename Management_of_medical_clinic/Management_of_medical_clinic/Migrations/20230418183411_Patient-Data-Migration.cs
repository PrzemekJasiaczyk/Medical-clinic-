using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class PatientDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "PESEL" },
                values: new object[] { "Juan Pablo", "Rodriguez", "90010100191" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PESEL" },
                values: new object[] { "Janina", "Pumpernikiel", "95020200529" });

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
                values: new object[] { 5, new DateTime(2000, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hneryk", (short)1, "Walezy", null, "00320300213", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "PESEL" },
                values: new object[] { "John", "Doe", "12345678901" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PESEL" },
                values: new object[] { "Jane", "Doe", "23456789012" });
        }
    }
}
