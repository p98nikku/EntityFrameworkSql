using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DbStore.Data.Migrations
{
    public partial class addedsupplierPoandProductOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productOrders",
                columns: table => new
                {
                    ProductOrderId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderTime = table.Column<DateTime>(nullable: false),
                    Qunatity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productOrders", x => x.ProductOrderId);
                });

            migrationBuilder.CreateTable(
                name: "supplierProductOrders",
                columns: table => new
                {
                    ProductOrderId = table.Column<int>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplierProductOrders", x => new { x.ProductId, x.ProductOrderId, x.SupplierId });
                    table.ForeignKey(
                        name: "FK_supplierProductOrders_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_supplierProductOrders_productOrders_ProductOrderId",
                        column: x => x.ProductOrderId,
                        principalTable: "productOrders",
                        principalColumn: "ProductOrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_supplierProductOrders_suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_supplierProductOrders_ProductOrderId",
                table: "supplierProductOrders",
                column: "ProductOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_supplierProductOrders_SupplierId",
                table: "supplierProductOrders",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "supplierProductOrders");

            migrationBuilder.DropTable(
                name: "productOrders");
        }
    }
}
