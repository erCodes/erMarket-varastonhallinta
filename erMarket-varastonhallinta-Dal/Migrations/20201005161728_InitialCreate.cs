using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace erMarket_varastonhallinta_Dal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoresId = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Supervisor = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DaoProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    InStock = table.Column<int>(nullable: false),
                    QuantityChanged = table.Column<DateTime>(nullable: false),
                    DaoStoreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaoProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DaoProduct_Stores_DaoStoreId",
                        column: x => x.DaoStoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategorysId = table.Column<int>(nullable: false),
                    CategorysName = table.Column<string>(nullable: true),
                    DaoProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategories_DaoProduct_DaoProductId",
                        column: x => x.DaoProductId,
                        principalTable: "DaoProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DaoProduct_DaoStoreId",
                table: "DaoProduct",
                column: "DaoStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_DaoProductId",
                table: "ProductCategories",
                column: "DaoProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "DaoProduct");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
