using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameWorkCorePractice.Migrations
{
    public partial class AddingForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteUserId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SiteUserId",
                table: "Courses",
                column: "SiteUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Siteusers_SiteUserId",
                table: "Courses",
                column: "SiteUserId",
                principalTable: "Siteusers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Siteusers_SiteUserId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_SiteUserId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "SiteUserId",
                table: "Courses");
        }
    }
}
