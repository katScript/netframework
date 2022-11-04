using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WDP2022A2Win.Data.Migrations
{
    public partial class CeateCompanySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageFilename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnchorLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Like = table.Column<int>(type: "int", nullable: false),
                    canIncreaseLike = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cec6dc14-3129-44d4-8f42-e58ba7adcf0c", "c4684af9-8a39-4246-8de4-a59daefc5114", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9f706b74-8348-4266-a2c1-e4f71f789e30", 0, "7f4031e8-99d9-4589-b377-6065f9068756", "admin@asp.net", true, false, null, "ADMIN@ASP.NET", "ADMIN@ASP.NET", "AQAAAAEAACcQAAAAEK0Yi1it72aAhfNB/7oXp8Lp6e95xRgbL7ZFJTI6qfpQ40RbiBc0O2L9HYf79H3XJw==", null, false, "90093058-bf21-4fac-90dc-b8593ce8f11d", false, "admin@asp.net" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c7338150-1e1d-4b5e-a722-9e96efb3b213", 0, "43478eba-7cc0-4a81-98db-b4c6a2e19cf5", "user@asp.net", true, false, null, "USER@ASP.NET", "USER@ASP.NET", "AQAAAAEAACcQAAAAEOMoVyl3tGNuU4K3IuYsVGUIzWE646PSWQMmvTSuVxfCtMfTmgeNX+lNNBpuC8/JiA==", null, false, "0f589a01-32c9-4c56-ac9c-64666f929d44", false, "user@asp.net" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cec6dc14-3129-44d4-8f42-e58ba7adcf0c", "9f706b74-8348-4266-a2c1-e4f71f789e30" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cec6dc14-3129-44d4-8f42-e58ba7adcf0c", "9f706b74-8348-4266-a2c1-e4f71f789e30" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7338150-1e1d-4b5e-a722-9e96efb3b213");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cec6dc14-3129-44d4-8f42-e58ba7adcf0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f706b74-8348-4266-a2c1-e4f71f789e30");

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
    }
}
