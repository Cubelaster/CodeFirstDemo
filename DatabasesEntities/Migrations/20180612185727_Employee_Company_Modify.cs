using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabasesEntities.Migrations
{
    public partial class Employee_Company_Modify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Employees",
                newName: "ModifiedByEmployeeId");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Companies",
                newName: "ModifiedByEmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByEmployeeId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByEmployeeId",
                table: "Companies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedByEmployeeId", "DateCreated", "DateModified", "ModifiedByEmployeeId", "Name", "Status", "VatId" },
                values: new object[] { 1, 1, new DateTime(2018, 6, 12, 20, 57, 26, 532, DateTimeKind.Local), null, 0, "SysKit", 1, "Vat Id" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "CreatedByEmployeeId", "DateCreated", "DateModified", "DateOfBirth", "FirstName", "LastName", "ModifiedByEmployeeId", "Status" },
                values: new object[] { 1, 1, 1, new DateTime(2018, 6, 12, 20, 57, 26, 537, DateTimeKind.Local), null, null, "David", "Čubela", 0, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyId",
                table: "Employees",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Companies_CompanyId",
                table: "Employees",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companies_CompanyId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CompanyId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedByEmployeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedByEmployeeId",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "ModifiedByEmployeeId",
                table: "Employees",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ModifiedByEmployeeId",
                table: "Companies",
                newName: "CreatedBy");

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "Companies",
                nullable: true);
        }
    }
}
