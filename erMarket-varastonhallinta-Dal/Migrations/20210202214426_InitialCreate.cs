using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace erMarket_varastonhallinta_Dal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChangeLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAction = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    ProductsId = table.Column<int>(nullable: false),
                    ProductsName = table.Column<string>(nullable: true),
                    OldAmount = table.Column<int>(nullable: false),
                    NewAmount = table.Column<int>(nullable: false),
                    Timestamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategorysId = table.Column<int>(nullable: false),
                    CategorysName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

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
                name: "DaoProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategorysId = table.Column<int>(nullable: false),
                    CategorysName = table.Column<string>(nullable: true),
                    DaoProductId = table.Column<int>(nullable: true),
                    LogDataId = table.Column<int>(nullable: true),
                    LogDataId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaoProductCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DaoProductCategory_DaoProduct_DaoProductId",
                        column: x => x.DaoProductId,
                        principalTable: "DaoProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DaoProductCategory_ChangeLog_LogDataId",
                        column: x => x.LogDataId,
                        principalTable: "ChangeLog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DaoProductCategory_ChangeLog_LogDataId1",
                        column: x => x.LogDataId1,
                        principalTable: "ChangeLog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DaoProduct_DaoStoreId",
                table: "DaoProduct",
                column: "DaoStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_DaoProductCategory_DaoProductId",
                table: "DaoProductCategory",
                column: "DaoProductId");

            migrationBuilder.CreateIndex(
                name: "IX_DaoProductCategory_LogDataId",
                table: "DaoProductCategory",
                column: "LogDataId");

            migrationBuilder.CreateIndex(
                name: "IX_DaoProductCategory_LogDataId1",
                table: "DaoProductCategory",
                column: "LogDataId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaoProductCategory");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "DaoProduct");

            migrationBuilder.DropTable(
                name: "ChangeLog");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
