using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class ChangingTypeOfOneTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dd5a4b0-807f-465b-a6f2-a1e9c113fcbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "417a1dfb-e861-4ce8-a790-e6a481a35feb");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OneTime",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7322ebd1-dd5c-49d0-97ac-f35c9bfdd5ad", "ff91dbbb-86b5-484f-96e1-04ecb4aa86cd", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a0a92e8-2a6f-4ac8-ae14-f7b89d702dd1", "61370115-fa8c-4156-b0e9-b00fc66e348f", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a0a92e8-2a6f-4ac8-ae14-f7b89d702dd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7322ebd1-dd5c-49d0-97ac-f35c9bfdd5ad");

            migrationBuilder.AlterColumn<string>(
                name: "OneTime",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2dd5a4b0-807f-465b-a6f2-a1e9c113fcbb", "96633291-5b73-437e-b90c-a3ccd5150077", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "417a1dfb-e861-4ce8-a790-e6a481a35feb", "afb96ca9-e884-438e-bdbb-1e32b6c1a996", "Employee", "EMPLOYEE" });
        }
    }
}
