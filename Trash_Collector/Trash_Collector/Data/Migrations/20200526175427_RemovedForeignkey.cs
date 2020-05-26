using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class RemovedForeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Pickups_PickupId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PickupId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af2d4263-7585-4ce7-a6a3-307fb70e9d3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef1a5dc6-a076-414f-8a8d-4d1d630852a4");

            migrationBuilder.DropColumn(
                name: "PickupId",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af8144e2-0dfb-4063-af1d-18d4e92bbf01", "239a7b48-158f-4979-926d-3ae8e9c23d6e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18829b75-9164-4f97-9411-3c92d96b0cc4", "8af12d08-e382-4235-a367-84e9817809d9", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18829b75-9164-4f97-9411-3c92d96b0cc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af8144e2-0dfb-4063-af1d-18d4e92bbf01");

            migrationBuilder.AddColumn<int>(
                name: "PickupId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef1a5dc6-a076-414f-8a8d-4d1d630852a4", "936a52ad-c737-4513-b957-1c3a1a5c8dca", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af2d4263-7585-4ce7-a6a3-307fb70e9d3f", "bba85949-fb97-4edf-a0ca-34373354f7b7", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PickupId",
                table: "Customers",
                column: "PickupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Pickups_PickupId",
                table: "Customers",
                column: "PickupId",
                principalTable: "Pickups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
