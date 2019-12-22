using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTattoo.Migrations
{
    public partial class DateFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppDatee",
                table: "Appointment",
                newName: "AppDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppDate",
                table: "Appointment",
                newName: "AppDatee");
        }
    }
}
