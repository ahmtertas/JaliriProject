using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Genders = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductBarcodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Barcode = table.Column<string>(type: "text", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifierDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBarcodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BrandName = table.Column<string>(type: "text", nullable: false),
                    BrandCode = table.Column<string>(type: "text", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifierDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ColorName = table.Column<string>(type: "text", nullable: false),
                    ColorCode = table.Column<string>(type: "text", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifierDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Size = table.Column<string>(type: "text", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifierDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    ProductDescription = table.Column<string>(type: "text", nullable: true),
                    UnitsInStock = table.Column<int>(type: "integer", nullable: false),
                    QuantityPerUnit = table.Column<int>(type: "integer", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    BrandId = table.Column<int>(type: "integer", nullable: false),
                    GenderId = table.Column<int>(type: "integer", nullable: false),
                    ColorId = table.Column<int>(type: "integer", nullable: true),
                    BarcodeId = table.Column<int>(type: "integer", nullable: false),
                    SizeId = table.Column<int>(type: "integer", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifierDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductBarcodes_BarcodeId",
                        column: x => x.BarcodeId,
                        principalTable: "ProductBarcodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductBrands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "ProductBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductColors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "ProductColors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductSizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "ProductSizes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Genders" },
                values: new object[,]
                {
                    { 1, "Erkek" },
                    { 2, "Kadın" },
                    { 3, "Çocuk" }
                });

            migrationBuilder.InsertData(
                table: "ProductBarcodes",
                columns: new[] { "Id", "Barcode", "InsertDate", "LastModifierDate" },
                values: new object[,]
                {
                    { 1, "54698726110", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(830), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(830) },
                    { 2, "54698726111", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(837), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(837) },
                    { 3, "54698726112", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(840), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(841) },
                    { 4, "54698726114", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(843), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(843) },
                    { 5, "54698726115", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(846), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(847) },
                    { 6, "54698726116", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(850), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(851) },
                    { 7, "54698726117", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(854), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(854) },
                    { 8, "54698726118", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(857), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(857) },
                    { 9, "54698726119", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(860), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(860) },
                    { 10, "54698726121", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(863), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(863) },
                    { 11, "54698726122", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(866), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(866) },
                    { 12, "54698726123", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(869), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(869) }
                });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "BrandCode", "BrandName", "InsertDate", "LastModifierDate" },
                values: new object[,]
                {
                    { 1, "A001", "Adidas", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(742), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(744) },
                    { 2, "N001", "Nike", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(765), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(765) },
                    { 3, "SL01", "Slezenger", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(769), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(769) },
                    { 4, "NB01", "New Balance", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(772), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(772) },
                    { 5, "PM01", "Puma", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(775), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(775) },
                    { 6, "KX01", "Kinetix", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(779), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(779) },
                    { 7, "CL01", "Columbia", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(781), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(782) },
                    { 8, "CRS01", "Converse", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(784), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(784) },
                    { 9, "DK01", "Dockers", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(810), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(811) },
                    { 10, "CP01", "CaterPillar", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(815), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(815) }
                });

            migrationBuilder.InsertData(
                table: "ProductColors",
                columns: new[] { "Id", "ColorCode", "ColorName", "InsertDate", "LastModifierDate" },
                values: new object[,]
                {
                    { 1, "S001", "Siyah", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(966) },
                    { 2, "B001", "Beyaz", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(972) },
                    { 3, "K001", "Kırmızı", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(975) },
                    { 4, "SA01", "Sarı", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(978), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(978) },
                    { 5, "T001", "Turuncu", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1003), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1003) },
                    { 6, "ZY01", "Yeşil", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1007), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1007) },
                    { 7, "L001", "Mor", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1010) },
                    { 8, "MU01", "Lacivert", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1012), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1013) },
                    { 9, "PM01", "Mavi", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1016), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1016) },
                    { 10, "TP01", "Pembe", new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1019), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1019) }
                });

            migrationBuilder.InsertData(
                table: "ProductSizes",
                columns: new[] { "Id", "InsertDate", "LastModifierDate", "Size" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(884), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(884), "XXS" },
                    { 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(891), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(891), "XS" },
                    { 3, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(894), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(894), "XS/S" },
                    { 4, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(897), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(897), "S" },
                    { 5, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(900), "S/M" },
                    { 6, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(903), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(903), "M" },
                    { 7, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(906), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(906), "L" },
                    { 8, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(909), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(909), "L/XL" },
                    { 9, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(911), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(912), "XL" },
                    { 10, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(915), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(915), "34" },
                    { 11, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(918), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(918), "35" },
                    { 12, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(921), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(921), "36" },
                    { 13, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(923), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(924), "37" },
                    { 14, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(926), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(926), "38" },
                    { 15, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(928), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(929), "39" },
                    { 16, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(931), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(932), "40" },
                    { 17, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(934), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(934), "41" },
                    { 18, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(937), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(938), "42" },
                    { 19, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(940), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(940), "43" },
                    { 20, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(943), "44" },
                    { 21, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(946), "45" },
                    { 22, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(948), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(948), "46" },
                    { 23, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(951), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(951), "47" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarcodeId", "BrandId", "ColorId", "GenderId", "InsertDate", "LastModifierDate", "ProductDescription", "ProductName", "QuantityPerUnit", "SizeId", "UnitPrice", "UnitsInStock" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1070), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1070), "", "Run Falcon 3", 1, 19, 1803.95m, 10 },
                    { 2, 1, 1, 2, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1076), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1076), "", "Hoops 3 Low", 1, 17, 1819.90m, 10 },
                    { 3, 1, 1, 3, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1080), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1080), "", "Ground Court Base", 1, 11, 1689.95m, 10 },
                    { 4, 1, 1, 2, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1083), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1083), "", "Samoa Spor Ayakkabı", 1, 20, 2099.25m, 10 },
                    { 5, 1, 1, 1, 3, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1086), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1086), "", "Superstar Co Erkek Spor", 1, 10, 3179.90m, 10 },
                    { 6, 2, 2, 3, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1090), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1090), "", "Downshifter", 1, 19, 2417.85m, 10 },
                    { 7, 2, 2, 2, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1095), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1095), "", "Air Force", 1, 12, 1749m, 10 },
                    { 8, 2, 2, 5, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1098), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1098), "", "Halı Saha Legend 10", 1, 19, 2335.26m, 10 },
                    { 9, 2, 2, 4, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1101), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1102), "", "Air Max Alpha Trainer", 1, 15, 3299m, 10 },
                    { 10, 2, 2, 10, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1105), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1105), "", "Air Monarch Iv 415445-102 Spor Ayakkabı", 1, 12, 2417.85m, 10 },
                    { 11, 3, 3, 8, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1108), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1108), "", "Sneaker Spor Ayakkabı", 1, 20, 699.90m, 10 },
                    { 12, 3, 3, 5, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1111), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1111), "", "Abena Sneaker Spor Ayakkabı", 1, 21, 574.90m, 10 },
                    { 13, 3, 3, 6, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1116), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1116), "", "Thermo Outdoor", 1, 11, 899.90m, 10 },
                    { 14, 3, 3, 3, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1118), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1119), "", "Slezenger Maroon | Sneaker", 1, 13, 499.90m, 10 },
                    { 15, 3, 3, 7, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1121), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1122), "", "Slezenger Olivia | Sneaker", 1, 14, 889.90m, 10 },
                    { 16, 4, 4, 4, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1125), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1125), "", "New Balance 109", 1, 18, 2399m, 10 },
                    { 17, 4, 4, 1, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1128), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1128), "", "New Balance 530 Lifestyle", 1, 21, 7850m, 10 },
                    { 18, 4, 4, 2, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1132), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1132), "", "New Balance 408 Lifestyle", 1, 14, 2690.10m, 10 },
                    { 19, 4, 4, 7, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1134), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1135), "", "New Balance 9060 Grey Lilac", 1, 13, 14999.10m, 10 },
                    { 20, 4, 4, 2, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1138), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1138), "", "New Balance 9060 Castlerock", 1, 23, 13979.90m, 10 },
                    { 21, 5, 5, 1, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1141), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1141), "", "Anzarun Lite", 1, 19, 1785m, 10 },
                    { 22, 5, 5, 2, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1144), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1144), "", "Roma Basic", 1, 12, 1599m, 10 },
                    { 23, 5, 5, 2, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1146), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1147), "", "Tech-Light", 1, 12, 3263.88m, 10 },
                    { 24, 5, 5, 2, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1150), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1150), "", "Caracal Sneaker", 1, 12, 1875m, 10 },
                    { 25, 5, 5, 9, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1153), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1153), "", "Court Classic Vulc Retro-C", 1, 17, 1871.95m, 10 },
                    { 26, 6, 6, 2, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1156), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1156), "", "PORO 4FX", 1, 11, 1871.95m, 10 },
                    { 27, 6, 6, 1, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1160), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1160), "", "EYON 4FX", 1, 14, 749.99m, 10 },
                    { 28, 6, 6, 7, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1179), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1179), "", "CAYDE 2PR", 1, 11, 621m, 10 },
                    { 29, 6, 6, 1, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1182), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1182), "", "AXION TX", 1, 19, 1199.99m, 10 },
                    { 30, 6, 6, 10, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1185), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1185), "", "SOLIDA", 1, 13, 799.88m, 10 },
                    { 31, 7, 7, 10, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1189), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1189), "", "Hata Breatha Kadın", 1, 13, 7199.88m, 10 },
                    { 32, 7, 7, 9, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1192), "", "Max Outdry", 1, 17, 4299.88m, 10 },
                    { 33, 7, 7, 4, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1195), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1195), "", "Creastwood WaterProof", 1, 12, 4299.99m, 10 },
                    { 34, 7, 7, 1, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1200), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1200), "", "Firecamp Waterproof", 1, 19, 3679.98m, 10 },
                    { 35, 7, 7, 4, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1203), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1203), "", "Castback", 1, 13, 2999.99m, 10 },
                    { 36, 8, 8, 8, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1206), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1206), "", "Chuck Taylor All Star", 1, 12, 2469m, 10 },
                    { 37, 8, 8, 2, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1209), "", "Converse Soft White", 1, 11, 2367m, 10 },
                    { 38, 8, 8, 4, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1212), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1212), "", "Lift Platform", 1, 18, 3099m, 10 },
                    { 39, 8, 8, 4, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1215), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1215), "", "All Star Lift Boy", 1, 18, 2499m, 10 },
                    { 40, 8, 8, 4, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1218), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1219), "", "Chuck Taylor All Star", 1, 18, 1899m, 10 },
                    { 41, 9, 9, 1, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1221), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1222), "", "Dockers 3fx Outdoor", 1, 19, 1799m, 10 },
                    { 42, 9, 9, 1, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1224), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1225), "", "Dockers 2pr Outdoor Asfalt", 1, 20, 1255.79m, 10 },
                    { 43, 9, 9, 1, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1227), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1227), "", "Dockers Comfort Casual Deri", 1, 21, 2099.99m, 10 },
                    { 44, 9, 9, 8, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1230), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1230), "", "Dockers 1fx Outdoor Fit", 1, 12, 899.99m, 10 },
                    { 45, 9, 9, 1, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1233), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1233), "", "Dockers 3m Günlük", 1, 18, 599.99m, 10 },
                    { 46, 10, 10, 1, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1236), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1236), "", "Colaroda Black Deri", 1, 17, 1973.99m, 10 },
                    { 47, 10, 10, 4, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1238), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1239), "", "Toledo Vibram Kaymaz", 1, 19, 3599.99m, 10 },
                    { 48, 10, 10, 10, 2, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1241), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1241), "", "Riesco Sneaker", 1, 12, 2059.90m, 10 },
                    { 49, 10, 10, 4, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1244), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1245), "", "Colaroda Expedition", 1, 20, 4099.99m, 10 },
                    { 50, 10, 10, 1, 1, new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1248), new DateTime(2024, 4, 21, 18, 58, 29, 48, DateTimeKind.Utc).AddTicks(1248), "", "Bot PICTON", 1, 17, 2890.99m, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductBrands_BrandCode",
                table: "ProductBrands",
                column: "BrandCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ColorCode",
                table: "ProductColors",
                column: "ColorCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BarcodeId",
                table: "Products",
                column: "BarcodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenderId",
                table: "Products",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "ProductBarcodes");

            migrationBuilder.DropTable(
                name: "ProductBrands");

            migrationBuilder.DropTable(
                name: "ProductColors");

            migrationBuilder.DropTable(
                name: "ProductSizes");
        }
    }
}
