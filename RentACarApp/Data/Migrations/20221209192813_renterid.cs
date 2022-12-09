using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarApp.Data.Migrations
{
    public partial class renterid : Migration
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
                values: new object[] { "636a3d27-cf3a-46d9-b34c-b4c6466e418a", "AQAAAAEAACcQAAAAEIklQ5YW3+aKO3I+2dkqvBOz2dbnbBMH/V9tPnYH6RqKG+3pRgwWbYODSqb4SqrSWA==", "fa9ca1f5-9679-4638-8509-d030d5fdcc59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2abf6196-4085-4945-a36f-09ac6a262acb", "AQAAAAEAACcQAAAAEMYtv9CY6/r1Qv+ho0C6u6AIFBbF1WqTY3xI74fMU+FMun5Sz6RKAjZ3kA2ub7pMyw==", "403ca3e1-c5dd-451c-b040-699e068a38ce" });

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
                values: new object[] { "02794310-8df8-43ce-8e75-0a4e05a1e0fb", "AQAAAAEAACcQAAAAEANh6cktTz5SKjVN180iaESRGt3U5TrT6iYK1NlWjuS99xZDKR0+pRJ8MTYBEvnwYA==", "af701ec4-6303-444f-855d-a6350b40c151" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88772a38-39de-4759-9732-a59a9b94fe91", "AQAAAAEAACcQAAAAEOo52QbtFfeM4xn6W1114gExus/2+RhpvbP5duigdy4cjkGsgAQ8fkyEheP7dVtnKA==", "65d15d16-99e5-414b-8828-5ef8f821ca73" });
        }
    }
}
