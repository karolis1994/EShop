using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.Infrastructure.Migrations
{
    public partial class EShop_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EShop");

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "EShop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISOCode = table.Column<string>(maxLength: 3, nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                schema: "EShop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PercentageOffPrice = table.Column<decimal>(nullable: false),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscountCoupon",
                schema: "EShop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(maxLength: 20, nullable: false),
                    PercentageOffPrice = table.Column<decimal>(nullable: false),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountCoupon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                schema: "EShop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(maxLength: 250, nullable: false),
                    Content = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                schema: "EShop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentCategoryId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategory_ProductCategory_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalSchema: "EShop",
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                schema: "EShop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Code = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderBillingInformation",
                schema: "EShop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<long>(nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Street = table.Column<string>(maxLength: 50, nullable: false),
                    HouseNumber = table.Column<string>(maxLength: 10, nullable: false),
                    FlatNumber = table.Column<string>(maxLength: 10, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderBillingInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderBillingInformation_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "EShop",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegularUserBillingInformation",
                schema: "EShop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<long>(nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Street = table.Column<string>(maxLength: 50, nullable: false),
                    HouseNumber = table.Column<string>(maxLength: 10, nullable: false),
                    FlatNumber = table.Column<string>(maxLength: 10, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegularUserBillingInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegularUserBillingInformation_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "EShop",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryDiscount",
                schema: "EShop",
                columns: table => new
                {
                    EntityId = table.Column<long>(nullable: false),
                    DiscountId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryDiscount", x => new { x.EntityId, x.DiscountId });
                    table.ForeignKey(
                        name: "FK_ProductCategoryDiscount_Discount_DiscountId",
                        column: x => x.DiscountId,
                        principalSchema: "EShop",
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategoryDiscount_ProductCategory_EntityId",
                        column: x => x.EntityId,
                        principalSchema: "EShop",
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "EShop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 250, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    IsEmailConfirmed = table.Column<bool>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Surname = table.Column<string>(maxLength: 30, nullable: true),
                    BillingInformationId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_RegularUserBillingInformation_BillingInformationId",
                        column: x => x.BillingInformationId,
                        principalSchema: "EShop",
                        principalTable: "RegularUserBillingInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "EShop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<long>(nullable: false),
                    OrderByUserId = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsPaidFor = table.Column<bool>(nullable: false),
                    BillingInformationId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_OrderBillingInformation_BillingInformationId",
                        column: x => x.BillingInformationId,
                        principalSchema: "EShop",
                        principalTable: "OrderBillingInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_User_OrderByUserId",
                        column: x => x.OrderByUserId,
                        principalSchema: "EShop",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDiscount",
                schema: "EShop",
                columns: table => new
                {
                    EntityId = table.Column<long>(nullable: false),
                    DiscountId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDiscount", x => new { x.EntityId, x.DiscountId });
                    table.ForeignKey(
                        name: "FK_ProductDiscount_Discount_DiscountId",
                        column: x => x.DiscountId,
                        principalSchema: "EShop",
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                schema: "EShop",
                columns: table => new
                {
                    ProductId = table.Column<long>(nullable: false),
                    ImageId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => new { x.ProductId, x.ImageId });
                    table.ForeignKey(
                        name: "FK_ProductImage_Image_ImageId",
                        column: x => x.ImageId,
                        principalSchema: "EShop",
                        principalTable: "Image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                schema: "EShop",
                columns: table => new
                {
                    OrderId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    ProductPriceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrderId, x.ProductId, x.SupplierId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Order_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "EShop",
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalSchema: "EShop",
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrice",
                schema: "EShop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityId = table.Column<long>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "EShop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    PriceId = table.Column<long>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "EShop",
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_ProductPrice_PriceId",
                        column: x => x.PriceId,
                        principalSchema: "EShop",
                        principalTable: "ProductPrice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierProduct",
                schema: "EShop",
                columns: table => new
                {
                    SupplierId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierProduct", x => new { x.ProductId, x.SupplierId });
                    table.ForeignKey(
                        name: "FK_SupplierProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "EShop",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierProduct_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalSchema: "EShop",
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCoupon_Code",
                schema: "EShop",
                table: "DiscountCoupon",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_BillingInformationId",
                schema: "EShop",
                table: "Order",
                column: "BillingInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderByUserId",
                schema: "EShop",
                table: "Order",
                column: "OrderByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBillingInformation_CountryId",
                schema: "EShop",
                table: "OrderBillingInformation",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                schema: "EShop",
                table: "OrderProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductPriceId",
                schema: "EShop",
                table: "OrderProduct",
                column: "ProductPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_SupplierId",
                schema: "EShop",
                table: "OrderProduct",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                schema: "EShop",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Code",
                schema: "EShop",
                table: "Product",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_PriceId",
                schema: "EShop",
                table: "Product",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_ParentCategoryId",
                schema: "EShop",
                table: "ProductCategory",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryDiscount_DiscountId",
                schema: "EShop",
                table: "ProductCategoryDiscount",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscount_DiscountId",
                schema: "EShop",
                table: "ProductDiscount",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ImageId",
                schema: "EShop",
                table: "ProductImage",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_EntityId",
                schema: "EShop",
                table: "ProductPrice",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_RegularUserBillingInformation_CountryId",
                schema: "EShop",
                table: "RegularUserBillingInformation",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierProduct_SupplierId",
                schema: "EShop",
                table: "SupplierProduct",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_User_BillingInformationId",
                schema: "EShop",
                table: "User",
                column: "BillingInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                schema: "EShop",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Username",
                schema: "EShop",
                table: "User",
                column: "Username",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDiscount_Product_EntityId",
                schema: "EShop",
                table: "ProductDiscount",
                column: "EntityId",
                principalSchema: "EShop",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Product_ProductId",
                schema: "EShop",
                table: "ProductImage",
                column: "ProductId",
                principalSchema: "EShop",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Product_ProductId",
                schema: "EShop",
                table: "OrderProduct",
                column: "ProductId",
                principalSchema: "EShop",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_ProductPrice_ProductPriceId",
                schema: "EShop",
                table: "OrderProduct",
                column: "ProductPriceId",
                principalSchema: "EShop",
                principalTable: "ProductPrice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrice_Product_EntityId",
                schema: "EShop",
                table: "ProductPrice",
                column: "EntityId",
                principalSchema: "EShop",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrice_Product_EntityId",
                schema: "EShop",
                table: "ProductPrice");

            migrationBuilder.DropTable(
                name: "DiscountCoupon",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "OrderProduct",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "ProductCategoryDiscount",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "ProductDiscount",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "ProductImage",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "SupplierProduct",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "Discount",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "Image",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "Supplier",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "OrderBillingInformation",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "User",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "RegularUserBillingInformation",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "ProductCategory",
                schema: "EShop");

            migrationBuilder.DropTable(
                name: "ProductPrice",
                schema: "EShop");
        }
    }
}
