using Microsoft.EntityFrameworkCore.Migrations;

namespace Applikacio2.Migrations
{
    public partial class amend_LoginEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "LoginEvents",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "LoginEvents");
        }
    }
}
