using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramworkCodeFirst.Migrations
{
    public partial class DeleteCategoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categories", x => x.Id);
                });
            migrationBuilder.Sql("INSERT INTO _Categories (Name) SELECT Name FROM Categories");
            migrationBuilder.DropTable(
                name: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });
            migrationBuilder.Sql("INSERT INTO Categories (Name) SELECT Name FROM _Categories");
            migrationBuilder.DropTable(
                name: "_Categories");
        }
    }
}
