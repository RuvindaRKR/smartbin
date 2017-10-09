using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace smartbin.Data.Migrations
{
    public partial class tue_binLevel_tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tue_binLevel_tbl",
                columns: table => new
                {
                    binID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    week_1_0930 = table.Column<double>(type: "float", nullable: false),
                    week_1_1530 = table.Column<double>(type: "float", nullable: false),
                    week_1_2130 = table.Column<double>(type: "float", nullable: false),
                    week_2_0930 = table.Column<double>(type: "float", nullable: false),
                    week_2_1530 = table.Column<double>(type: "float", nullable: false),
                    week_2_2130 = table.Column<double>(type: "float", nullable: false),
                    week_3_0930 = table.Column<double>(type: "float", nullable: false),
                    week_3_1530 = table.Column<double>(type: "float", nullable: false),
                    week_3_2130 = table.Column<double>(type: "float", nullable: false),
                    week_4_0930 = table.Column<double>(type: "float", nullable: false),
                    week_4_1530 = table.Column<double>(type: "float", nullable: false),
                    week_4_2130 = table.Column<double>(type: "float", nullable: false),
                    week_5_0930 = table.Column<double>(type: "float", nullable: false),
                    week_5_1530 = table.Column<double>(type: "float", nullable: false),
                    week_5_2130 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tue_binLevel_tbl", x => x.binID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tue_binLevel_tbl");
        }
    }
}
