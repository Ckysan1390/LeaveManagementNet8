using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac13a0f-f5ac-6fa3-b3a1-a1bcc5bf2c8d", null, "User", "USER" },
                    { "cac43a6f-f5cc-66a4-baa2-a1bfc5af2c6b", null, "Administrator", "ADMINISTRTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "434271b6-429b-42a6-8f5d-9b9d32b8a5dc", 0, "bd29e829-1e14-4cf7-97a5-f3785be2b9eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEC3m7YSrDj30PoiQcD3TZxIZGV0czJ8HOY5mmx4p7W1UDL/dWen6kioTAE1EL34ifA==", null, false, "b5055f87-2ad2-433d-95e4-fe0c1a089f99", null, false, null },
                    { "69abc1b6-413b-4586-85b2-964d2f9a5cc", 0, "835d8b21-1517-44e5-9272-eaf108d826e2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEOaIleujtI5TiHjhIgwMzVOqL+2IRdXCQjFrMqEISCmfnqyiLRtNQBokjzsHxar/Pw==", null, false, "a6fccaff-deca-4993-ae8b-16fd6505898f", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cac43a6f-f5cc-66a4-baa2-a1bfc5af2c6b", "434271b6-429b-42a6-8f5d-9b9d32b8a5dc" },
                    { "cac13a0f-f5ac-6fa3-b3a1-a1bcc5bf2c8d", "69abc1b6-413b-4586-85b2-964d2f9a5cc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6f-f5cc-66a4-baa2-a1bfc5af2c6b", "434271b6-429b-42a6-8f5d-9b9d32b8a5dc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac13a0f-f5ac-6fa3-b3a1-a1bcc5bf2c8d", "69abc1b6-413b-4586-85b2-964d2f9a5cc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac13a0f-f5ac-6fa3-b3a1-a1bcc5bf2c8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6f-f5cc-66a4-baa2-a1bfc5af2c6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "434271b6-429b-42a6-8f5d-9b9d32b8a5dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69abc1b6-413b-4586-85b2-964d2f9a5cc");
        }
    }
}
