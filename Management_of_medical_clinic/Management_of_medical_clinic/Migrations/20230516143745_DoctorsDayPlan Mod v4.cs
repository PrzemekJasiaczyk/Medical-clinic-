using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class DoctorsDayPlanModv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbDoctorsDayPlan_Patient_PatientId",
                table: "DbDoctorsDayPlan");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "DbDoctorsDayPlan",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_DbDoctorsDayPlan_Patient_PatientId",
                table: "DbDoctorsDayPlan",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbDoctorsDayPlan_Patient_PatientId",
                table: "DbDoctorsDayPlan");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "DbDoctorsDayPlan",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DbDoctorsDayPlan_Patient_PatientId",
                table: "DbDoctorsDayPlan",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
