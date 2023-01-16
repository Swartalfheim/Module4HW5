using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace M4HW3.Migrations
{
    /// <inheritdoc />
    public partial class NewDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "OfficeId", "Location", "Title" },
                values: new object[,]
                {
                    { 1, "Kharkiv", "Kapitalist" },
                    { 2, "Oslo", "Steklo" },
                    { 3, "Nuuk", "Magelan" }
                });

            migrationBuilder.InsertData(
                table: "Title",
                columns: new[] { "TitleId", "Name" },
                values: new object[,]
                {
                    { 1, "En" },
                    { 2, "To" },
                    { 3, "Tre" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "FirstName", "HiredDate", "LastName", "OfficeId", "TitleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denys", new DateTime(2023, 1, 16, 10, 24, 30, 598, DateTimeKind.Local).AddTicks(3352), "Shapka", 1, 1 },
                    { 2, new DateTime(2001, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dima", new DateTime(2023, 1, 16, 10, 24, 30, 598, DateTimeKind.Local).AddTicks(3391), "Kormyshov", 2, 2 },
                    { 3, new DateTime(2001, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nikita", new DateTime(2023, 1, 16, 10, 24, 30, 598, DateTimeKind.Local).AddTicks(3398), "Petrov", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeProjectId", "EmployeeId", "ProjectId", "Rate", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 256m, new DateTime(2023, 1, 16, 10, 24, 30, 598, DateTimeKind.Local).AddTicks(7242) },
                    { 2, 2, 2, 600m, new DateTime(2023, 1, 16, 10, 24, 30, 598, DateTimeKind.Local).AddTicks(7254) },
                    { 3, 3, 3, 300m, new DateTime(2023, 1, 16, 10, 24, 30, 598, DateTimeKind.Local).AddTicks(7257) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 3);
        }
    }
}
