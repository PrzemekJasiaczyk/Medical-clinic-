using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class AddingOffices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbOffices",
                columns: table => new
                {
                    IdOffice = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_DbOffices_IdSpecialization",
                table: "DbOffices",
                column: "IdSpecialization");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbOffices");
        }
    }
}
