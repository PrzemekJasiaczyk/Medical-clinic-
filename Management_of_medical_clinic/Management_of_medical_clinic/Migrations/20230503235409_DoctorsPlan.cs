using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class DoctorsPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbDoctorsDayPlan",
                columns: table => new
                {
                    IdDoctorsDayPlan = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdsWorkingTerms = table.Column<string>(type: "TEXT", nullable: false),
                    IdDay = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IdCalendar = table.Column<int>(type: "INTEGER", nullable: true),
                    IdEmployee = table.Column<int>(type: "INTEGER", nullable: false),
                    IdOffice = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbDoctorsDayPlan", x => x.IdDoctorsDayPlan);
                    table.ForeignKey(
                        name: "FK_DbDoctorsDayPlan_DbCalendars_IdCalendar",
                        column: x => x.IdCalendar,
                        principalTable: "DbCalendars",
                        principalColumn: "IdCalendar",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DbDoctorsDayPlan_DbEmployees_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "DbEmployees",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DbDoctorsDayPlan_DbOffices_IdOffice",
                        column: x => x.IdOffice,
                        principalTable: "DbOffices",
                        principalColumn: "IdOffice",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DbDoctorsDayPlan_IdCalendar",
                table: "DbDoctorsDayPlan",
                column: "IdCalendar");

            migrationBuilder.CreateIndex(
                name: "IX_DbDoctorsDayPlan_IdEmployee",
                table: "DbDoctorsDayPlan",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_DbDoctorsDayPlan_IdOffice",
                table: "DbDoctorsDayPlan",
                column: "IdOffice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbDoctorsDayPlan");
        }
    }
}
