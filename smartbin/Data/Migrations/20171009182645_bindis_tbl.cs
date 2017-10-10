using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace smartbin.Data.Migrations
{
    public partial class bindis_tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bindis_tbl",
                columns: table => new
                {
                    areaID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    population = table.Column<double>(type: "float", nullable: false),
                    totalbins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bindis_tbl", x => x.areaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bindis_tbl");
        }
    }
}
