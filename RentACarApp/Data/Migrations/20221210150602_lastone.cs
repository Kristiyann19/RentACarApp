using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarApp.Data.Migrations
{
    public partial class lastone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9676d65-ec89-4610-b4f5-7ebf8f502144", "AQAAAAEAACcQAAAAEB03Td+hHYDgIYvcQpjsYZMJlJ0idaWRGVFdIiiBjFsJ8U4v4WnP21jjhWcL25IaiQ==", "92aeec6a-7d8f-4273-941e-971d609c0397" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4868d6bf-9c56-4b5b-b659-fedea90e1c40", "AQAAAAEAACcQAAAAEH6zMnq+0NrEee2k89OnyEpBet+qlWqtY45W7dBlbrU8hW8+QPhEeF7lnxxW9D5NwA==", "e92a5038-641f-4232-8ca6-3d6f8b3fbc01" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
