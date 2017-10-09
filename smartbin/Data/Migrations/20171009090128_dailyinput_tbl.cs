using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace smartbin.Data.Migrations
{
    public partial class dailyinput_tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dailyinput_tbl",
                columns: table => new
                {
                    binID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BD = table.Column<double>(type: "float", nullable: false),
                    GL = table.Column<double>(type: "float", nullable: false),
                    PA = table.Column<double>(type: "float", nullable: false),
                    PL = table.Column<double>(type: "float", nullable: false),
                    areaID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dailyinput_tbl", x => x.binID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dailyinput_tbl");
        }
    }
}
