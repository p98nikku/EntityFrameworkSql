using Microsoft.EntityFrameworkCore.Migrations;

namespace DbStore.Data.Migrations
{
    public partial class inventoryadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inventories_products_ProductId",
                table: "inventories");

            migrationBuilder.DropIndex(
                name: "IX_inventories_ProductId",
                table: "inventories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_inventories_ProductId",
                table: "inventories",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_inventories_products_ProductId",
                table: "inventories",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
