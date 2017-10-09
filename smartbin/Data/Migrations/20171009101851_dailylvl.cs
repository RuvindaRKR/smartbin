using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace smartbin.Data.Migrations
{
    public partial class dailylvl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dailylvl_tbl",
                columns: table => new
                {
                    areaID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BD = table.Column<double>(type: "float", nullable: false),
                    GL = table.Column<double>(type: "float", nullable: false),
                    PA = table.Column<double>(type: "float", nullable: false),
                    PL = table.Column<double>(type: "float", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dailylvl_tbl", x => x.areaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dailylvl_tbl");
        }
    }
}
