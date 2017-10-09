using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace smartbin.Data.Migrations
{
    public partial class addfeedbacktable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "feedback",
                columns: table => new
                {
                    fid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    binid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feedbacktype = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedback", x => x.fid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "feedback");
        }
    }
}
