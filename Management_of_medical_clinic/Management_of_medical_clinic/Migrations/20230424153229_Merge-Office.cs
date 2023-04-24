using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class MergeOffice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfficeModel_DbSpecializations_IdSpecialization",
                table: "OfficeModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Patient_IdPatient",
                table: "Visit");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Patient_TempId",
                table: "Patient");

            migrationBuilder.RenameTable(
                name: "OfficeModel",
                newName: "DbOffices");

            migrationBuilder.RenameColumn(
                name: "TempId",
                table: "Patient",
                newName: "Sex");

            migrationBuilder.AddColumn<int>(
                name: "IdPatient",
                table: "Patient",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateLastVisit",
                table: "Patient",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patient",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Patient",
                type: "TEXT",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "IsActive",
                table: "Patient",
                type: "INTEGER",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Patient",
                type: "TEXT",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PESEL",
                table: "Patient",
                type: "TEXT",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "IdSpecialization",
                table: "DbOffices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdOffice",
                table: "DbOffices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "DbOffices",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "DbOffices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "DbOffices",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "IdPatient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbOffices",
                table: "DbOffices",
                column: "IdOffice");

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
                name: "IX_DbOffices_IdSpecialization",
                table: "DbOffices",
                column: "IdSpecialization");

            migrationBuilder.AddForeignKey(
                name: "FK_DbOffices_DbSpecializations_IdSpecialization",
                table: "DbOffices",
                column: "IdSpecialization",
                principalTable: "DbSpecializations",
                principalColumn: "IdSpecialization",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Patient_IdPatient",
                table: "Visit",
                column: "IdPatient",
                principalTable: "Patient",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbOffices_DbSpecializations_IdSpecialization",
                table: "DbOffices");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Patient_IdPatient",
                table: "Visit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbOffices",
                table: "DbOffices");

            migrationBuilder.DropIndex(
                name: "IX_DbOffices_IdSpecialization",
                table: "DbOffices");

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyColumnType: "INTEGER",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyColumnType: "INTEGER",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyColumnType: "INTEGER",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyColumnType: "INTEGER",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyColumnType: "INTEGER",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "IdPatient",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "DateLastVisit",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "PESEL",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "IdOffice",
                table: "DbOffices");

            migrationBuilder.DropColumn(
                name: "Info",
                table: "DbOffices");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "DbOffices");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "DbOffices");

            migrationBuilder.RenameTable(
                name: "DbOffices",
                newName: "OfficeModel");

            migrationBuilder.RenameColumn(
                name: "Sex",
                table: "Patient",
                newName: "TempId");

            migrationBuilder.AlterColumn<int>(
                name: "IdSpecialization",
                table: "OfficeModel",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Patient_TempId",
                table: "Patient",
                column: "TempId");

            migrationBuilder.AddForeignKey(
                name: "FK_OfficeModel_DbSpecializations_IdSpecialization",
                table: "OfficeModel",
                column: "IdSpecialization",
                principalTable: "DbSpecializations",
                principalColumn: "IdSpecialization",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Patient_IdPatient",
                table: "Visit",
                column: "IdPatient",
                principalTable: "Patient",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
