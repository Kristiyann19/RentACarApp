using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarApp.Data.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09a8376a-b3fe-4811-adab-61d502028822", "AQAAAAEAACcQAAAAEKlxt+fGdVJfwtf8EuCCNDXgpbUY+K6lv6yYb7w3OQxWFqtNpbPG4rFui9r+BNvmkg==", "f9b57a7d-5ecb-4757-b843-0dc909705c51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13691868-b164-425c-8fe4-a89fe1bcbdf0", "AQAAAAEAACcQAAAAEBV6/uAoMnzeNiUSW9y46HOu1+nBN4vkYwt9ZZhpenp5qd3GTYU48a9pMG2CdkQMaA==", "18c58989-e714-430e-9f63-2596c3b91947" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
