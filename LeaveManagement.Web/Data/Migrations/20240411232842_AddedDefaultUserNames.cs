using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUserNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "434271b6-429b-42a6-8f5d-9b9d32b8a5dc",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8ad24fcc-27b5-46ec-b953-52922376b53c", true, "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGnxNvt/FgNBl+9SLCyjzeg9wsb0NTzsls9tfTfdxCBYrJQKpeIIh6mWUAsqDxRJlw==", "c3603935-f767-4683-aa41-499ca51b76f7", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69abc1b6-413b-4586-85b2-964d2f9a5cc",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a9138900-0dd3-4dbf-b9b5-80fce9777f1b", true, "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIPs1MOFfCsQTWS8WZ9gkPh88veFKcBqgMSOpidfF5SlCWV6ZD0OkJ/i4z5i/Kpm2Q==", "9d0e241a-ff4c-4a47-a6fb-76e78af9d635", "user@localhost.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "434271b6-429b-42a6-8f5d-9b9d32b8a5dc",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bd29e829-1e14-4cf7-97a5-f3785be2b9eb", false, null, "AQAAAAIAAYagAAAAEC3m7YSrDj30PoiQcD3TZxIZGV0czJ8HOY5mmx4p7W1UDL/dWen6kioTAE1EL34ifA==", "b5055f87-2ad2-433d-95e4-fe0c1a089f99", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69abc1b6-413b-4586-85b2-964d2f9a5cc",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "835d8b21-1517-44e5-9272-eaf108d826e2", false, null, "AQAAAAIAAYagAAAAEOaIleujtI5TiHjhIgwMzVOqL+2IRdXCQjFrMqEISCmfnqyiLRtNQBokjzsHxar/Pw==", "a6fccaff-deca-4993-ae8b-16fd6505898f", null });
        }
    }
}
