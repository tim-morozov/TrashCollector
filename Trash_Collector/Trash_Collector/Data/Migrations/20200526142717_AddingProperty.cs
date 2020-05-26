using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class AddingProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2007f454-f159-43d5-9700-f35183d36a15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43f237cf-06ed-48e6-8b62-7ac9098d57c2");

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50a2af55-9c8f-4743-879a-ca3875b76fe1", "481ae76b-ec0b-49be-97d5-2e4dbb86bb1d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9dba68ff-3218-4b20-bf15-315f8f561a11", "ecf9f298-4b6b-4c1f-b0c1-e412c06e76a1", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50a2af55-9c8f-4743-879a-ca3875b76fe1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dba68ff-3218-4b20-bf15-315f8f561a11");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2007f454-f159-43d5-9700-f35183d36a15", "f4e69104-da92-42c6-ab88-4bc17b0cb337", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43f237cf-06ed-48e6-8b62-7ac9098d57c2", "4cda8f70-1522-4075-bbb6-942be91e3619", "Employee", "EMPLOYEE" });
        }
    }
}
