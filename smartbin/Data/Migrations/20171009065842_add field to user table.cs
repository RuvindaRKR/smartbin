using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace smartbin.Data.Migrations
{
    public partial class addfieldtousertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "areaID",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "areaID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "fullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "role",
                table: "AspNetUsers");
        }
    }
}
