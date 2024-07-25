using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Studentpack.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "TeacherId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Doe", "1234567890" },
                    { 2, new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", "Smith", "0987654321" }
                });

            migrationBuilder.InsertData(
                table: "schoolClass",
                columns: new[] { "ClassId", "ClassName", "Description", "TeacherId" },
                values: new object[,]
                {
                    { 1, "Math 101", "Basic Math Class", 1 },
                    { 2, "Science 101", "Basic Science Class", 2 }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "StudentId", "ClassId", "DateOfBirth", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2005, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice.johnson@example.com", "Alice", "Johnson" },
                    { 2, 2, new DateTime(2006, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.brown@example.com", "Bob", "Brown" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "schoolClass",
                keyColumn: "ClassId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "schoolClass",
                keyColumn: "ClassId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "TeacherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "TeacherId",
                keyValue: 2);
        }
    }
}
