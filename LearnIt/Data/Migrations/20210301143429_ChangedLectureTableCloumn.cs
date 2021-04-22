using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnIt.Data.Migrations
{
    public partial class ChangedLectureTableCloumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info",
                table: "Lectures");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Lectures",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "Lectures");

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "Lectures",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
