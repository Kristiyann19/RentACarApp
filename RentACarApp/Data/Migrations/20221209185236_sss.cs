using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarApp.Data.Migrations
{
    public partial class sss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02794310-8df8-43ce-8e75-0a4e05a1e0fb", "AQAAAAEAACcQAAAAEANh6cktTz5SKjVN180iaESRGt3U5TrT6iYK1NlWjuS99xZDKR0+pRJ8MTYBEvnwYA==", "af701ec4-6303-444f-855d-a6350b40c151" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88772a38-39de-4759-9732-a59a9b94fe91", "AQAAAAEAACcQAAAAEOo52QbtFfeM4xn6W1114gExus/2+RhpvbP5duigdy4cjkGsgAQ8fkyEheP7dVtnKA==", "65d15d16-99e5-414b-8828-5ef8f821ca73" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
