using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnIt.Data.Migrations
{
    public partial class CoursesHaveLectures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseDataModelId",
                table: "Lectures",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_CourseDataModelId",
                table: "Lectures",
                column: "CourseDataModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Courses_CourseDataModelId",
                table: "Lectures",
                column: "CourseDataModelId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Courses_CourseDataModelId",
                table: "Lectures");

            migrationBuilder.DropIndex(
                name: "IX_Lectures_CourseDataModelId",
                table: "Lectures");

            migrationBuilder.DropColumn(
                name: "CourseDataModelId",
                table: "Lectures");
        }
    }
}
