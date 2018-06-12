using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabasesEntities.Migrations
{
    public partial class Modifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByEmployeeId",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "IsPotentialBuyer",
                table: "Employees",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByEmployeeId",
                table: "Companies",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ModifiedByEmployeeId" },
                values: new object[] { new DateTime(2018, 6, 12, 21, 9, 48, 310, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ModifiedByEmployeeId" },
                values: new object[] { new DateTime(2018, 6, 12, 21, 9, 48, 312, DateTimeKind.Local), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPotentialBuyer",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByEmployeeId",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByEmployeeId",
                table: "Companies",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ModifiedByEmployeeId" },
                values: new object[] { new DateTime(2018, 6, 12, 20, 57, 26, 532, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ModifiedByEmployeeId" },
                values: new object[] { new DateTime(2018, 6, 12, 20, 57, 26, 537, DateTimeKind.Local), 0 });
        }
    }
}
