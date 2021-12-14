using Microsoft.EntityFrameworkCore.Migrations;

namespace Applikacio2.Migrations
{
    public partial class change_account_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_account",
                table: "account");

            migrationBuilder.DropColumn(
                name: "id",
                table: "account");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "account",
                newName: "Username");

            migrationBuilder.AddPrimaryKey(
                name: "PK_account",
                table: "account",
                column: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_account",
                table: "account");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "account",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "account",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_account",
                table: "account",
                column: "id");
        }
    }
}
