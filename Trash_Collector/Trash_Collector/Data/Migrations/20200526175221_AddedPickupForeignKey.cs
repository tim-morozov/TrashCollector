using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class AddedPickupForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19add84b-56c7-4e5d-8424-b3841970b68c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0addfd3-bdac-44c9-a7dc-0ea2a1a216bb");

            migrationBuilder.AddColumn<bool>(
                name: "IsPickedUp",
                table: "Pickups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PickupId",
                table: "Customers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IsPickedUp",
                table: "Pickups");

            migrationBuilder.DropColumn(
                name: "PickupId",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19add84b-56c7-4e5d-8424-b3841970b68c", "d28d02fe-ac81-4d3d-86bb-248248552bd7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d0addfd3-bdac-44c9-a7dc-0ea2a1a216bb", "1de8dc2c-a373-4919-9c3d-59cb58fb6b05", "Employee", "EMPLOYEE" });
        }
    }
}
