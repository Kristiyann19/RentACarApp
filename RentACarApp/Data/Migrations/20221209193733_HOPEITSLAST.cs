using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarApp.Data.Migrations
{
    public partial class HOPEITSLAST : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19a8ab4b-5b71-4567-8090-bf2e45264ae5", "AQAAAAEAACcQAAAAEJrHTjTq3SFbV3Rqs6BSYdIZ6kygNV5DVBpCKAJG1Av73PnW6seOA5LhTWow+HVEFg==", "4fdf4384-925a-45bc-a0d6-21c3c33b33be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9389ca31-9be3-4c67-af11-cdc6488cecee", "AQAAAAEAACcQAAAAECE8R8SWdvpIo5hrzxcPrlSF2XMB4wOPv4r4msTw7aITQ7IzV3wtxpv+W0a9ELIIig==", "667b3c45-fd98-4637-97a2-fd06d2f6968f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "636a3d27-cf3a-46d9-b34c-b4c6466e418a", "AQAAAAEAACcQAAAAEIklQ5YW3+aKO3I+2dkqvBOz2dbnbBMH/V9tPnYH6RqKG+3pRgwWbYODSqb4SqrSWA==", "fa9ca1f5-9679-4638-8509-d030d5fdcc59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2abf6196-4085-4945-a36f-09ac6a262acb", "AQAAAAEAACcQAAAAEMYtv9CY6/r1Qv+ho0C6u6AIFBbF1WqTY3xI74fMU+FMun5Sz6RKAjZ3kA2ub7pMyw==", "403ca3e1-c5dd-451c-b040-699e068a38ce" });
        }
    }
}
