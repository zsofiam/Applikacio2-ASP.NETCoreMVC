using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Applikacio2.Migrations
{
    public partial class add_account_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.id);
                });

            //migrationBuilder.CreateTable(
            //    name: "dokumentum",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false),
            //        title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        extension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        main_id = table.Column<int>(type: "int", nullable: false),
            //        source = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_dokumentum", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "esemeny",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false),
            //        title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_esemeny", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "naplo",
            //    columns: table => new
            //    {
            //        dokumentum_id = table.Column<int>(type: "int", nullable: false),
            //        esemeny_id = table.Column<int>(type: "int", nullable: false),
            //        happened_at = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_naplo", x => new { x.dokumentum_id, x.esemeny_id, x.happened_at });
            //        table.ForeignKey(
            //            name: "FK_naplo_dokumentum",
            //            column: x => x.dokumentum_id,
            //            principalTable: "dokumentum",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_naplo_esemeny",
            //            column: x => x.esemeny_id,
            //            principalTable: "esemeny",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_naplo_esemeny_id",
            //    table: "naplo",
            //    column: "esemeny_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "naplo");

            migrationBuilder.DropTable(
                name: "dokumentum");

            migrationBuilder.DropTable(
                name: "esemeny");
        }
    }
}
