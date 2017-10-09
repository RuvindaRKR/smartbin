using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace smartbin.Data.Migrations
{
    public partial class addbindetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "bindetail_tbl",
                columns: table => new
                {
                    binID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    H00 = table.Column<double>(type: "float", nullable: false),
                    H01 = table.Column<double>(type: "float", nullable: false),
                    H02 = table.Column<double>(type: "float", nullable: false),
                    H03 = table.Column<double>(type: "float", nullable: false),
                    H04 = table.Column<double>(type: "float", nullable: false),
                    H05 = table.Column<double>(type: "float", nullable: false),
                    H06 = table.Column<double>(type: "float", nullable: false),
                    H07 = table.Column<double>(type: "float", nullable: false),
                    H08 = table.Column<double>(type: "float", nullable: false),
                    H09 = table.Column<double>(type: "float", nullable: false),
                    H10 = table.Column<double>(type: "float", nullable: false),
                    H11 = table.Column<double>(type: "float", nullable: false),
                    H12 = table.Column<double>(type: "float", nullable: false),
                    H13 = table.Column<double>(type: "float", nullable: false),
                    H14 = table.Column<double>(type: "float", nullable: false),
                    H15 = table.Column<double>(type: "float", nullable: false),
                    H16 = table.Column<double>(type: "float", nullable: false),
                    H17 = table.Column<double>(type: "float", nullable: false),
                    H18 = table.Column<double>(type: "float", nullable: false),
                    H19 = table.Column<double>(type: "float", nullable: false),
                    H20 = table.Column<double>(type: "float", nullable: false),
                    H21 = table.Column<double>(type: "float", nullable: false),
                    H22 = table.Column<double>(type: "float", nullable: false),
                    H23 = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    areaID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    areaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filedLevel = table.Column<double>(type: "float", nullable: false),
                    latitude = table.Column<double>(type: "float", nullable: false),
                    longitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bindetail_tbl", x => x.binID);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "bindetail_tbl");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
