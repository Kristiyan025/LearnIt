using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnIt.Data.Migrations
{
    public partial class IdentityUserFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomTag",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserDataModelId",
                table: "AspNetUserClaims",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserDataModelId",
                table: "AspNetUserClaims",
                column: "UserDataModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserDataModelId",
                table: "AspNetUserClaims",
                column: "UserDataModelId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserDataModelId",
                table: "AspNetUserClaims");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_UserDataModelId",
                table: "AspNetUserClaims");

            migrationBuilder.DropColumn(
                name: "CustomTag",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserDataModelId",
                table: "AspNetUserClaims");
        }
    }
}
