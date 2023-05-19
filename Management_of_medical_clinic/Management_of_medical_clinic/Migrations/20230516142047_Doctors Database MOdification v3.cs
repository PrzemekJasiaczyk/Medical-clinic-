using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class DoctorsDatabaseMOdificationv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HasVisit",
                table: "DbDoctorsDayPlan",
                newName: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DbDoctorsDayPlan_PatientId",
                table: "DbDoctorsDayPlan",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbDoctorsDayPlan_Patient_PatientId",
                table: "DbDoctorsDayPlan",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbDoctorsDayPlan_Patient_PatientId",
                table: "DbDoctorsDayPlan");

            migrationBuilder.DropIndex(
                name: "IX_DbDoctorsDayPlan_PatientId",
                table: "DbDoctorsDayPlan");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "DbDoctorsDayPlan",
                newName: "HasVisit");
        }
    }
}
