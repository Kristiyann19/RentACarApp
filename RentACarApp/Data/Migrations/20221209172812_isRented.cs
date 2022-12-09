using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarApp.Data.Migrations
{
    public partial class isRented : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsRented",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2b6f510-060b-47be-a18d-8aa0906b1606", "AQAAAAEAACcQAAAAEBThuG+SsP7Nye+RtD8cvJ7jwTZbW0umVl4ImhY7bARVRzChfOAVFD6KL3QXfIjArA==", "e74dc824-0866-46b2-afb5-4b89dcfa15e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dca010df-2622-4772-b517-90941f7dc3f2", "AQAAAAEAACcQAAAAEBOpV8UZcnMZcpIJ9DJshLFzJtBHLFaGpor/62T3/iZMCGuWNVbxhTm1W1KR5dM58A==", "e95cff4c-0e1f-4016-b76d-1b85970edf76" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRented",
                table: "Cars");

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
    }
}
