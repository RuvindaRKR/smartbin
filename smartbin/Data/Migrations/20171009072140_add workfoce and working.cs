using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace smartbin.Data.Migrations
{
    public partial class addworkfoceandworking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "workforce_tbl",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    areaID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    pWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workforce_tbl", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "working_tbl",
                columns: table => new
                {
                    workID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    binID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_working_tbl", x => x.workID);
                    table.ForeignKey(
                        name: "FK_working_tbl_bindetail_tbl_binID",
                        column: x => x.binID,
                        principalTable: "bindetail_tbl",
                        principalColumn: "binID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_working_tbl_workforce_tbl_userID",
                        column: x => x.userID,
                        principalTable: "workforce_tbl",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_working_tbl_binID",
                table: "working_tbl",
                column: "binID");

            migrationBuilder.CreateIndex(
                name: "IX_working_tbl_userID",
                table: "working_tbl",
                column: "userID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "working_tbl");

            migrationBuilder.DropTable(
                name: "workforce_tbl");
        }
    }
}
