using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarApp.Data.Migrations
{
    public partial class moreinfoforagents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Agents",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Agents",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Agent", "Agentov" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Agents");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
