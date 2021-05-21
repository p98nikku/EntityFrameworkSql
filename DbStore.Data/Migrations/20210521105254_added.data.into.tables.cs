using Microsoft.EntityFrameworkCore.Migrations;

namespace DbStore.Data.Migrations
{
    public partial class addeddataintotables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_inventories_ProductId",
                table: "inventories",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_inventories_products_ProductId",
                table: "inventories",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inventories_products_ProductId",
                table: "inventories");

            migrationBuilder.DropIndex(
                name: "IX_inventories_ProductId",
                table: "inventories");
        }
    }
}
