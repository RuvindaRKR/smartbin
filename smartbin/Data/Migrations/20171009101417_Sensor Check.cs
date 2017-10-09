using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace smartbin.Data.Migrations
{
    public partial class SensorCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sensorCheck_tbl",
                columns: table => new
                {
                    binID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    filedLevel_1 = table.Column<double>(type: "float", nullable: false),
                    filedLevel_2 = table.Column<double>(type: "float", nullable: false),
                    filedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sensorCheck_tbl", x => x.binID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sensorCheck_tbl");
        }
    }
}
