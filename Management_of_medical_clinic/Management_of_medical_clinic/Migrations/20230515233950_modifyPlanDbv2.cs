using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class modifyPlanDbv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdsWorkingTerms",
                table: "DbDoctorsDayPlan",
                newName: "IdOfTerm");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdOfTerm",
                table: "DbDoctorsDayPlan",
                newName: "IdsWorkingTerms");
        }
    }
}
