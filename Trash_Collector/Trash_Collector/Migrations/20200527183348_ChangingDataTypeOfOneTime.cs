using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class ChangingDataTypeOfOneTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2363387f-c75d-43f0-9a0a-2057a35508a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "330f436a-fd46-4819-8776-5c01dd953256");

            migrationBuilder.AddColumn<string>(
                name: "OneTime",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2dd5a4b0-807f-465b-a6f2-a1e9c113fcbb", "96633291-5b73-437e-b90c-a3ccd5150077", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "417a1dfb-e861-4ce8-a790-e6a481a35feb", "afb96ca9-e884-438e-bdbb-1e32b6c1a996", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dd5a4b0-807f-465b-a6f2-a1e9c113fcbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "417a1dfb-e861-4ce8-a790-e6a481a35feb");

            migrationBuilder.DropColumn(
                name: "OneTime",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2363387f-c75d-43f0-9a0a-2057a35508a8", "7bae86c5-6899-4029-b88e-3a525d4a834a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "330f436a-fd46-4819-8776-5c01dd953256", "cde0b473-568a-4c82-9918-e6793b78a404", "Employee", "EMPLOYEE" });
        }
    }
}
