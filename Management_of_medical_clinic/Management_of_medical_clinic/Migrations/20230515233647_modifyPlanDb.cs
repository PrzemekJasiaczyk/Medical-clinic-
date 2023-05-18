using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class modifyPlanDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbAppointments_Patient_PatientId",
                table: "DbAppointments");

            migrationBuilder.AlterColumn<int>(
                name: "IdsWorkingTerms",
                table: "DbDoctorsDayPlan",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<bool>(
                name: "HasVisit",
                table: "DbDoctorsDayPlan",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "DbAppointments",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_DbAppointments_Patient_PatientId",
                table: "DbAppointments",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbAppointments_Patient_PatientId",
                table: "DbAppointments");

            migrationBuilder.DropColumn(
                name: "HasVisit",
                table: "DbDoctorsDayPlan");

            migrationBuilder.AlterColumn<string>(
                name: "IdsWorkingTerms",
                table: "DbDoctorsDayPlan",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "DbAppointments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DbAppointments_Patient_PatientId",
                table: "DbAppointments",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
