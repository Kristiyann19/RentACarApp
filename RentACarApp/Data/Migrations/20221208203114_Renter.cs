using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarApp.Data.Migrations
{
    public partial class Renter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RenterId",
                table: "Cars",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b994341b-1d1e-4201-92cf-2ceffd505245", "AQAAAAEAACcQAAAAEO+kgxf/1DIlAyajPf6U8Bjua1cKQ3YHaapJ5Vcb7dwNK5MZS/QXmEB4vhh7z0q3rA==", "ea45e3da-6d6a-4060-a3fa-61396070d3fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88c591ee-63e2-4611-8000-b28cbca1b268", "AQAAAAEAACcQAAAAEAh4CppS7eRsdh5tRcBDhSugUY+CIfHqswKR1aeHOGyskAmfcpXREjw0ZrqCsuC5Pg==", "32020c98-2b39-4bea-bcb3-3b2ea52046d0" });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RenterId",
                table: "Cars",
                column: "RenterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_AspNetUsers_RenterId",
                table: "Cars",
                column: "RenterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_AspNetUsers_RenterId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_RenterId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RenterId",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3fd746c-b7b9-4c87-9d3d-16bdf5fd5d66", "AQAAAAEAACcQAAAAEHa+CwBHTmynuvaHiZuW1ERjZQFIt5rNsXXunLPcrwtxKFWoJ3bW6ktWx73qMsTgXA==", "14172185-a9b7-4f8b-a15d-5e01737703b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ef3dfb4-b27c-45fe-b6a6-e04f9e81f797", "AQAAAAEAACcQAAAAEF2rWcZ39JeUxHaW/IpZC4+wTsbSPYnXEN3AdBOXL2xb1JKxKIiZ2huAOxyDTXTFSA==", "e7eb88aa-022e-4317-899a-0b94bdd25896" });
        }
    }
}
