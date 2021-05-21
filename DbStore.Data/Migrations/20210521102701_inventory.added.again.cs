using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DbStore.Data.Migrations
{
    public partial class inventoryaddedagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inventories_products_ProductId1",
                table: "inventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_inventories",
                table: "inventories");

            migrationBuilder.DropIndex(
                name: "IX_inventories_ProductId1",
                table: "inventories");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "inventories");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "inventories",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inventories_products_ProductId",
                table: "inventories");

            migrationBuilder.DropIndex(
                name: "IX_inventories_ProductId",
                table: "inventories");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "inventories",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "inventories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_inventories",
                table: "inventories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_inventories_ProductId1",
                table: "inventories",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_inventories_products_ProductId1",
                table: "inventories",
                column: "ProductId1",
                principalTable: "products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
