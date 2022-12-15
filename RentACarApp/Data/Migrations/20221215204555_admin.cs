using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarApp.Data.Migrations
{
    public partial class admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc2a2169-319e-42e6-b2c9-1396f92c63ad", "AQAAAAEAACcQAAAAEI0TcEsy64JYoG6emvgPxCnebfFY3DoLit2Q11Pt4VA6PgAJ5qZ2LqkOxM2w+1mABQ==", "db1ffe69-f467-4a63-bb07-1c796231e0f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a10067db-0bf0-4e4a-b4b5-fc1c3d443510", "AQAAAAEAACcQAAAAEIDXzrv4UjVnZJ/LbMfj51PQJ4H1UPpH9JCDNcSAHdYWBqOCgdAfG4UwagUDkRVA4g==", "f623e80c-cf77-4b97-8159-722ff161d9d0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "78551b5d-fd8d-4711-83b5-ed39ae47c072", 0, "216d65cd-e1af-4ce0-9973-28c3fd07f5b7", "admin@mail.com", false, true, false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEM18UtLitTGU++33SBPQpcWe2FiPR8I1lGNIzqPUfDCPQZ8KwO0pD/PdpDyYSaMHxw==", null, false, "6c752d91-68a6-4201-a8a2-80d0c26dd75a", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "FirstName", "LastName", "PhoneNumber", "UserId" },
                values: new object[] { 6, "admin@mail.com", "admin@mail.com", "+359123456789", "78551b5d-fd8d-4711-83b5-ed39ae47c072" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78551b5d-fd8d-4711-83b5-ed39ae47c072");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc2fea45-c85a-4a47-bb3a-8a6d512a9a96", "AQAAAAEAACcQAAAAEM1flNV+z4mdIbMrv80BnBeWvC/7VlFwSgah9vFu92a+FiYFjL2X4A9WvCULHZLJFg==", "19735fdf-bc40-4d96-a766-2f8d721f5e35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f00b2ce-cef8-4d89-894b-b29dc660b01b", "AQAAAAEAACcQAAAAEPsELYLWsjB7JBqtfu21H0zTdqb4mZlvj6q92FrlFZ/LbBn1weHJCUScWdIlP6HdpQ==", "4e8db378-5f17-491c-a6dc-fe7008eb783e" });
        }
    }
}
