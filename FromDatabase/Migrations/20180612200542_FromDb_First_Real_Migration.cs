using Microsoft.EntityFrameworkCore.Migrations;

namespace FromDatabase.Migrations
{
    public partial class FromDb_First_Real_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MadeUpSomething",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MadeUpSomething",
                table: "Employees");
        }
    }
}
