using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace smartbin.Data.Migrations
{
    public partial class adduserImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "userImage",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userImage",
                table: "AspNetUsers");
        }
    }
}
