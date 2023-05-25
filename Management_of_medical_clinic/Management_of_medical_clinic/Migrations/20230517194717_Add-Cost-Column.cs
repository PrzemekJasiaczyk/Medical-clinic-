using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class AddCostColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "DbDoctorsDayPlan",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "DbDoctorsDayPlan");
        }
    }
}
