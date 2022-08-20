using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramworkCodeFirst.Migrations
{
    public partial class AddDatePublisgedToCoursesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Courses",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Courses");
        }
    }
}
