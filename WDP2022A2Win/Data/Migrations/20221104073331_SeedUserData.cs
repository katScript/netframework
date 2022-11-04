using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WDP2022A2Win.Data.Migrations
{
    public partial class SeedUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69f9df25-29ec-44ce-9cdd-33f7b60b432d", "6e69dd1d-1652-4773-86e4-f53476e9304d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d939f033-fb9a-4849-85fe-303ec1ceac8d", 0, "29d269fd-ba37-4608-9893-bf6f57246fdc", "user@asp.net", true, false, null, "USER@ASP.NET", "USER@ASP.NET", "AQAAAAEAACcQAAAAEFdx1Ip2WyL9A287OBgN+dpoybhEJ1ez+mB8zGOLN6MFTiSALd3Clrk4lzyLm/JfTg==", null, false, "0f949255-9bf0-4b09-8ef7-11792bd8f848", false, "user@asp.net" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f2c3d758-976b-4f3e-9f0d-8531cb24ec2e", 0, "ee4c46d1-c66e-4c72-8b03-582672cc96c8", "admin@asp.net", true, false, null, "ADMIN@ASP.NET", "ADMIN@ASP.NET", "AQAAAAEAACcQAAAAEKnsqv+1hRwG+SBMbdOOocNicRTaOyP76rMxZbkTvgUNhsRDfXtxpq6sjr/JoxMCuw==", null, false, "9fa422f9-a898-4ef4-babd-1a2669c2ccb5", false, "admin@asp.net" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "69f9df25-29ec-44ce-9cdd-33f7b60b432d", "f2c3d758-976b-4f3e-9f0d-8531cb24ec2e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69f9df25-29ec-44ce-9cdd-33f7b60b432d", "f2c3d758-976b-4f3e-9f0d-8531cb24ec2e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d939f033-fb9a-4849-85fe-303ec1ceac8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69f9df25-29ec-44ce-9cdd-33f7b60b432d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2c3d758-976b-4f3e-9f0d-8531cb24ec2e");
        }
    }
}
