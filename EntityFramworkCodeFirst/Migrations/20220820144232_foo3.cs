using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramworkCodeFirst.Migrations
{
    public partial class foo3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FullPrice",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 1200,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FullPrice",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1200);
        }
    }
}
