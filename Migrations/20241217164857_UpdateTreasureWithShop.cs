using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPNET.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTreasureWithShop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treasures_Shops_ShopId",
                table: "Treasures");

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "Treasures",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Treasures_Shops_ShopId",
                table: "Treasures",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treasures_Shops_ShopId",
                table: "Treasures");

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "Treasures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Treasures_Shops_ShopId",
                table: "Treasures",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id");
        }
    }
}
