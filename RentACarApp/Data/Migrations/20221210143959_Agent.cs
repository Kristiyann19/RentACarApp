using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarApp.Data.Migrations
{
    public partial class Agent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98df2da4-6d1d-492b-89fd-15374c5ffe1c", "AQAAAAEAACcQAAAAEGklmLfyB1oh2E2bdQMW2e40cSIZVHxrYNKeZRt/cOTkcav4Uzyvfems3OmuGgFCvw==", "86252f72-8668-48e8-9208-abebb79b6231" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ff24fd0-323b-4bdf-ae23-0469daea907b", "AQAAAAEAACcQAAAAEOCczl0Nlx6LkMyOtmw8T6OndFTTkIV8QJf9p+uyBAoK5f854NlRFZV8lhKpiTcUlw==", "2f940d6a-2f2a-4162-95a4-6e932afca56b" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "AgentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "AgentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "AgentId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_AgentId",
                table: "Cars",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Agents_AgentId",
                table: "Cars",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Agents_AgentId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_AgentId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "Cars");

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
    }
}
