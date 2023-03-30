using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class SpecializationOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DbEmployees_IdSpecialization",
                table: "DbEmployees");

            migrationBuilder.CreateIndex(
                name: "IX_DbEmployees_IdSpecialization",
                table: "DbEmployees",
                column: "IdSpecialization");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DbEmployees_IdSpecialization",
                table: "DbEmployees");

            migrationBuilder.CreateIndex(
                name: "IX_DbEmployees_IdSpecialization",
                table: "DbEmployees",
                column: "IdSpecialization",
                unique: true);
        }
    }
}
