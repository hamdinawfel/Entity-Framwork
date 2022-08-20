using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramworkCodeFirst.Migrations
{
    public partial class DeleteDatePublisherFromCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Courses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Courses",
                type: "datetime2",
                nullable: true);
        }
    }
}
