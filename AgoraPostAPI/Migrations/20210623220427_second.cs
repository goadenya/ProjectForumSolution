using Microsoft.EntityFrameworkCore.Migrations;

namespace AgoraPostAPI.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePicUrl",
                table: "Replies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicUrl",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicUrl",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicUrl",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "ProfilePicUrl",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ProfilePicUrl",
                table: "Comments");
        }
    }
}
