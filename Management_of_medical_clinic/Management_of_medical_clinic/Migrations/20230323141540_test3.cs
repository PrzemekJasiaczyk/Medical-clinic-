using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbEmployees_DbUsers_IdUser1",
                table: "DbEmployees");

            migrationBuilder.DropIndex(
                name: "IX_DbEmployees_IdUser1",
                table: "DbEmployees");

            migrationBuilder.DropColumn(
                name: "IdUser1",
                table: "DbEmployees");

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "DbEmployees",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DbEmployees_IdUser",
                table: "DbEmployees",
                column: "IdUser",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DbEmployees_DbUsers_IdUser",
                table: "DbEmployees",
                column: "IdUser",
                principalTable: "DbUsers",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbEmployees_DbUsers_IdUser",
                table: "DbEmployees");

            migrationBuilder.DropIndex(
                name: "IX_DbEmployees_IdUser",
                table: "DbEmployees");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "DbEmployees");

            migrationBuilder.AddColumn<int>(
                name: "IdUser1",
                table: "DbEmployees",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbEmployees_IdUser1",
                table: "DbEmployees",
                column: "IdUser1");

            migrationBuilder.AddForeignKey(
                name: "FK_DbEmployees_DbUsers_IdUser1",
                table: "DbEmployees",
                column: "IdUser1",
                principalTable: "DbUsers",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
