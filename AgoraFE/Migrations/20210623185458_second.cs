using Microsoft.EntityFrameworkCore.Migrations;

namespace AgoraFE.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "root-0c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "d3cdae35-4a78-47d3-ad36-a943669d01e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user-2c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "71af274e-f725-48e2-abb7-4754591d51ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "929fa6cc-fb9c-446f-aca5-40c3bfc907f1", "AQAAAAEAACcQAAAAEIfMqYqk2kOia60bdeg7DgJ3ucVsBKuVxOO49pdRr4n1pt3aPPEQqkYOlmk7lo4zzg==", "614cde23-8f32-4fb1-bcf6-baedd54fe0bc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "root-0c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "04818fb0-8cbf-435e-880f-77787294d0a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user-2c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "4f93ab06-8e6f-4e51-941a-3c6eafbbefa5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "497eef64-f345-4aaa-9486-df4bac9300ea", "AQAAAAEAACcQAAAAEFPnbblf2RVvWykAv5iJbBcbpDIInnRrxDmyY9TQcrRscc1IwIQ5JRnxXNkzoZgsEw==", "954162ff-250b-4e68-986d-898f6e48e0b8" });
        }
    }
}
