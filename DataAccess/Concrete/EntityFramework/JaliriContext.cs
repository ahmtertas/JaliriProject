using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	public class JaliriContext : DbContext
	{
		public JaliriContext(DbContextOptions options) : base(options) { }




		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{


			//IsUnique
			modelBuilder.Entity<ProductColor>()
			.HasIndex(p => p.ColorCode)
			.IsUnique();

			modelBuilder.Entity<ProductBrand>()
			.HasIndex(p => p.BrandCode)
			.IsUnique();



			//Required
			modelBuilder.Entity<ProductColor>()
			.Property(p => p.ColorName)
			.IsRequired();

			modelBuilder.Entity<ProductBrand>()
			.Property(p => p.BrandName)
			.IsRequired();

			modelBuilder.Entity<ProductSize>()
			.Property(p => p.Size)
			.IsRequired();

			modelBuilder.Entity<ProductBarcode>()
			.Property(p => p.Barcode)
			.IsRequired();




			modelBuilder.Entity<ProductBrand>(
				productBrand =>
				{

					productBrand.HasData(new
					{
						Id = 1,
						BrandName = "Adidas",
						BrandCode = "A001",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productBrand.HasData(new
					{
						Id = 2,
						BrandName = "Nike",
						BrandCode = "N001",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productBrand.HasData(new
					{
						Id = 3,
						BrandName = "Slezenger",
						BrandCode = "SL01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});


					productBrand.HasData(new
					{
						Id = 4,
						BrandName = "New Balance",
						BrandCode = "NB01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});


					productBrand.HasData(new
					{
						Id = 5,
						BrandName = "Puma",
						BrandCode = "PM01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productBrand.HasData(new
					{
						Id = 6,
						BrandName = "Kinetix",
						BrandCode = "KX01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productBrand.HasData(new
					{
						Id = 7,
						BrandName = "Columbia",
						BrandCode = "CL01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productBrand.HasData(new
					{
						Id = 8,
						BrandName = "Converse",
						BrandCode = "CRS01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productBrand.HasData(new
					{
						Id = 9,
						BrandName = "Dockers",
						BrandCode = "DK01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productBrand.HasData(new
					{
						Id = 10,
						BrandName = "CaterPillar",
						BrandCode = "CP01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});
				}
				);

			modelBuilder.Entity<ProductBarcode>(
				productBarcode =>
				{
					productBarcode.HasData(new
					{
						Id = 1,
						Barcode = "54698726110",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productBarcode.HasData(new
					{
						Id = 2,
						Barcode = "54698726111",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					productBarcode.HasData(new
					{
						Id = 3,
						Barcode = "54698726112",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					productBarcode.HasData(new
					{
						Id = 4,
						Barcode = "54698726114",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productBarcode.HasData(new
					{
						Id = 5,
						Barcode = "54698726115",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productBarcode.HasData(new
					{
						Id = 6,
						Barcode = "54698726116",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productBarcode.HasData(new
					{
						Id = 7,
						Barcode = "54698726117",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productBarcode.HasData(new
					{
						Id = 8,
						Barcode = "54698726118",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});



					productBarcode.HasData(new
					{
						Id = 9,
						Barcode = "54698726119",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productBarcode.HasData(new
					{
						Id = 10,
						Barcode = "54698726121",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productBarcode.HasData(new
					{
						Id = 11,
						Barcode = "54698726122",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productBarcode.HasData(new
					{
						Id = 12,
						Barcode = "54698726123",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});
				}
				);


			modelBuilder.Entity<ProductSize>(
				productSize =>
				{
					productSize.HasData(new
					{
						Id = 1,
						Size = "XXS",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 2,
						Size = "XS",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 3,
						Size = "XS/S",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 4,
						Size = "S",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 5,
						Size = "S/M",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});


					productSize.HasData(new
					{
						Id = 6,
						Size = "M",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});


					productSize.HasData(new
					{
						Id = 7,
						Size = "L",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});


					productSize.HasData(new
					{
						Id = 8,
						Size = "L/XL",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});


					productSize.HasData(new
					{
						Id = 9,
						Size = "XL",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});


					productSize.HasData(new
					{
						Id = 10,
						Size = "34",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});


					productSize.HasData(new
					{
						Id = 11,
						Size = "35",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 12,
						Size = "36",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});


					productSize.HasData(new
					{
						Id = 13,
						Size = "37",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 14,
						Size = "38",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 15,
						Size = "39",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 16,
						Size = "40",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 17,
						Size = "41",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 18,
						Size = "42",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 19,
						Size = "43",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 20,
						Size = "44",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 21,
						Size = "45",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 22,
						Size = "46",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					productSize.HasData(new
					{
						Id = 23,
						Size = "47",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});
				}
				);


			modelBuilder.Entity<ProductColor>(
				productColor =>
				{


					productColor.HasData(new
					{
						Id = 1,
						ColorName = "Siyah",
						ColorCode = "S001",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productColor.HasData(new
					{
						Id = 2,
						ColorName = "Beyaz",
						ColorCode = "B001",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productColor.HasData(new
					{
						Id = 3,
						ColorName = "Kırmızı",
						ColorCode = "K001",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productColor.HasData(new
					{
						Id = 4,
						ColorName = "Sarı",
						ColorCode = "SA01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productColor.HasData(new
					{
						Id = 5,
						ColorName = "Turuncu",
						ColorCode = "T001",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productColor.HasData(new
					{
						Id = 6,
						ColorName = "Yeşil",
						ColorCode = "ZY01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productColor.HasData(new
					{
						Id = 7,
						ColorName = "Mor",
						ColorCode = "L001",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productColor.HasData(new
					{
						Id = 8,
						ColorName = "Lacivert",
						ColorCode = "MU01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					productColor.HasData(new
					{
						Id = 9,
						ColorName = "Mavi",
						ColorCode = "PM01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					productColor.HasData(new
					{
						Id = 10,
						ColorName = "Pembe",
						ColorCode = "TP01",
						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});
				}
				);

			modelBuilder.Entity<Gender>(
				gender =>
				{
					gender.HasData(new
					{
						Id = 1,
						Genders = "Erkek"
					});

					gender.HasData(new
					{
						Id = 2,
						Genders = "Kadın"
					});

					gender.HasData(new
					{
						Id = 3,
						Genders = "Çocuk"
					});
				}
				);

			modelBuilder.Entity<Product>(
				product =>
				{

					product.HasData(new
					{
						Id = 1,

						ProductName = "Run Falcon 3",
						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						UnitPrice = 1803.95m,
						BrandId = 1,
						ColorId = 1,
						BarcodeId = 1,
						SizeId = 19,
						GenderId = 1,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					product.HasData(new
					{
						Id = 2,

						ProductName = "Hoops 3 Low",
						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						UnitPrice = 1819.90m,
						BrandId = 1,
						ColorId = 2,
						BarcodeId = 1,
						SizeId = 17,
						GenderId = 1,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					product.HasData(new
					{
						Id = 3,

						ProductName = "Ground Court Base",
						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						UnitPrice = 1689.95m,
						BrandId = 1,
						ColorId = 3,
						BarcodeId = 1,
						SizeId = 11,
						GenderId = 2,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					product.HasData(new
					{
						Id = 4,

						ProductName = "Samoa Spor Ayakkabı",
						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						UnitPrice = 2099.25m,
						BrandId = 1,
						ColorId = 2,
						BarcodeId = 1,
						SizeId = 20,
						GenderId = 2,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow

					});

					product.HasData(new
					{
						Id = 5,

						ProductName = "Superstar Co Erkek Spor",
						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						UnitPrice = 3179.90m,
						BrandId = 1,
						ColorId = 1,
						BarcodeId = 1,
						SizeId = 10,
						GenderId = 3,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 6,

						ProductName = "Downshifter",
						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						UnitPrice = 2417.85m,
						BrandId = 2,
						ColorId = 3,
						BarcodeId = 2,
						SizeId = 19,
						GenderId = 1,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 7,

						ProductName = "Air Force",
						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						UnitPrice = 1749m,
						BrandId = 2,
						ColorId = 2,
						BarcodeId = 2,
						SizeId = 12,
						GenderId = 2,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 8,

						ProductName = "Halı Saha Legend 10",
						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						UnitPrice = 2335.26m,
						BrandId = 2,
						ColorId = 5,
						BarcodeId = 2,
						SizeId = 19,
						GenderId = 1,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 9,

						ProductName = "Air Max Alpha Trainer",
						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						UnitPrice = 3299m,
						BrandId = 2,
						ColorId = 4,
						BarcodeId = 2,
						SizeId = 15,
						GenderId = 1,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 10,

						ProductName = "Air Monarch Iv 415445-102 Spor Ayakkabı",
						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						UnitPrice = 2417.85m,
						BrandId = 2,
						ColorId = 10,
						BarcodeId = 2,
						SizeId = 12,
						GenderId = 2,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});



					product.HasData(new
					{
						Id = 11,

						ProductName = "Sneaker Spor Ayakkabı",
						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						UnitPrice = 699.90m,
						BrandId = 3,
						ColorId = 8,
						BarcodeId = 3,
						SizeId = 20,
						GenderId = 1,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 12,

						ProductName = "Abena Sneaker Spor Ayakkabı",
						UnitPrice = 574.90m,
						ColorId = 5,
						SizeId = 21,
						GenderId = 1,


						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 3,
						BarcodeId = 3,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});



					product.HasData(new
					{
						Id = 13,

						ProductName = "Thermo Outdoor",
						UnitPrice = 899.90m,
						ColorId = 6,
						SizeId = 11,
						GenderId = 2,


						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 3,
						BarcodeId = 3,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 14,

						ProductName = "Slezenger Maroon | Sneaker",
						UnitPrice = 499.90m,
						ColorId = 3,
						SizeId = 13,
						GenderId = 2,


						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 3,
						BarcodeId = 3,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 15,

						ProductName = "Slezenger Olivia | Sneaker",
						UnitPrice = 889.90m,
						ColorId = 7,
						SizeId = 14,
						GenderId = 2,


						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 3,
						BarcodeId = 3,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 16,

						ProductName = "New Balance 109",
						UnitPrice = 2399m,
						ColorId = 4,
						SizeId = 18,
						GenderId = 1,


						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 4,
						BarcodeId = 4,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 17,

						ProductName = "New Balance 530 Lifestyle",
						UnitPrice = 7850m,
						ColorId = 1,
						SizeId = 21,
						GenderId = 1,


						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 4,
						BarcodeId = 4,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 18,

						ProductName = "New Balance 408 Lifestyle",
						UnitPrice = 2690.10m,
						ColorId = 2,
						SizeId = 14,
						GenderId = 2,


						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 4,
						BarcodeId = 4,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 19,

						ProductName = "New Balance 9060 Grey Lilac",
						UnitPrice = 14999.10m,
						ColorId = 7,
						SizeId = 13,
						GenderId = 2,


						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 4,
						BarcodeId = 4,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 20,

						ProductName = "New Balance 9060 Castlerock",
						UnitPrice = 13979.90m,
						ColorId = 2,
						SizeId = 23,
						GenderId = 1,


						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 4,
						BarcodeId = 4,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});



					product.HasData(new
					{
						Id = 21,

						ProductName = "Anzarun Lite",
						UnitPrice = 1785m,
						ColorId = 1,
						SizeId = 19,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 5,
						BarcodeId = 5,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 22,

						ProductName = "Roma Basic",
						UnitPrice = 1599m,
						ColorId = 2,
						SizeId = 12,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 5,
						BarcodeId = 5,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 23,

						ProductName = "Tech-Light",
						UnitPrice = 3263.88m,
						ColorId = 2,
						SizeId = 12,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 5,
						BarcodeId = 5,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 24,

						ProductName = "Caracal Sneaker",
						UnitPrice = 1875m,
						ColorId = 2,
						SizeId = 12,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 5,
						BarcodeId = 5,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 25,

						ProductName = "Court Classic Vulc Retro-C",
						UnitPrice = 1871.95m,
						ColorId = 9,
						SizeId = 17,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 5,
						BarcodeId = 5,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});



					product.HasData(new
					{
						Id = 26,

						ProductName = "PORO 4FX",
						UnitPrice = 1871.95m,
						ColorId = 2,
						SizeId = 11,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 6,
						BarcodeId = 6,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					product.HasData(new
					{
						Id = 27,

						ProductName = "EYON 4FX",
						UnitPrice = 749.99m,
						ColorId = 1,
						SizeId = 14,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 6,
						BarcodeId = 6,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 28,

						ProductName = "CAYDE 2PR",
						UnitPrice = 621m,
						ColorId = 7,
						SizeId = 11,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 6,
						BarcodeId = 6,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 29,

						ProductName = "AXION TX",
						UnitPrice = 1199.99m,
						ColorId = 1,
						SizeId = 19,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 6,
						BarcodeId = 6,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					product.HasData(new
					{
						Id = 30,

						ProductName = "SOLIDA",
						UnitPrice = 799.88m,
						ColorId = 10,
						SizeId = 13,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 6,
						BarcodeId = 6,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});



					product.HasData(new
					{
						Id = 31,

						ProductName = "Hata Breatha Kadın",
						UnitPrice = 7199.88m,
						ColorId = 10,
						SizeId = 13,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 7,
						BarcodeId = 7,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					product.HasData(new
					{
						Id = 32,

						ProductName = "Max Outdry",
						UnitPrice = 4299.88m,
						ColorId = 9,
						SizeId = 17,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 7,
						BarcodeId = 7,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					product.HasData(new
					{
						Id = 33,

						ProductName = "Creastwood WaterProof",
						UnitPrice = 4299.99m,
						ColorId = 4,
						SizeId = 12,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 7,
						BarcodeId = 7,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					product.HasData(new
					{
						Id = 34,

						ProductName = "Firecamp Waterproof",
						UnitPrice = 3679.98m,
						ColorId = 1,
						SizeId = 19,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 7,
						BarcodeId = 7,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					product.HasData(new
					{
						Id = 35,

						ProductName = "Castback",
						UnitPrice = 2999.99m,
						ColorId = 4,
						SizeId = 13,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 7,
						BarcodeId = 7,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 36,

						ProductName = "Chuck Taylor All Star",
						UnitPrice = 2469m,
						ColorId = 8,
						SizeId = 12,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 8,
						BarcodeId = 8,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 37,

						ProductName = "Converse Soft White",
						UnitPrice = 2367m,
						ColorId = 2,
						SizeId = 11,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 8,
						BarcodeId = 8,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 38,

						ProductName = "Lift Platform",
						UnitPrice = 3099m,
						ColorId = 4,
						SizeId = 18,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 8,
						BarcodeId = 8,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 39,

						ProductName = "All Star Lift Boy",
						UnitPrice = 2499m,
						ColorId = 4,
						SizeId = 18,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 8,
						BarcodeId = 8,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 40,

						ProductName = "Chuck Taylor All Star",
						UnitPrice = 1899m,
						ColorId = 4,
						SizeId = 18,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 8,
						BarcodeId = 8,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 41,

						ProductName = "Dockers 3fx Outdoor",
						UnitPrice = 1799m,
						ColorId = 1,
						SizeId = 19,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 9,
						BarcodeId = 9,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					product.HasData(new
					{
						Id = 42,

						ProductName = "Dockers 2pr Outdoor Asfalt",
						UnitPrice = 1255.79m,
						ColorId = 1,
						SizeId = 20,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 9,
						BarcodeId = 9,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					product.HasData(new
					{
						Id = 43,

						ProductName = "Dockers Comfort Casual Deri",
						UnitPrice = 2099.99m,
						ColorId = 1,
						SizeId = 21,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 9,
						BarcodeId = 9,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 44,

						ProductName = "Dockers 1fx Outdoor Fit",
						UnitPrice = 899.99m,
						ColorId = 8,
						SizeId = 12,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 9,
						BarcodeId = 9,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 45,

						ProductName = "Dockers 3m Günlük",
						UnitPrice = 599.99m,
						ColorId = 1,
						SizeId = 18,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 9,
						BarcodeId = 9,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});



					product.HasData(new
					{
						Id = 46,

						ProductName = "Colaroda Black Deri",
						UnitPrice = 1973.99m,
						ColorId = 1,
						SizeId = 17,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 10,
						BarcodeId = 10,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});

					product.HasData(new
					{
						Id = 47,

						ProductName = "Toledo Vibram Kaymaz",
						UnitPrice = 3599.99m,
						ColorId = 4,
						SizeId = 19,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 10,
						BarcodeId = 10,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 48,

						ProductName = "Riesco Sneaker",
						UnitPrice = 2059.90m,
						ColorId = 10,
						SizeId = 12,
						GenderId = 2,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 10,
						BarcodeId = 10,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 49,

						ProductName = "Colaroda Expedition",
						UnitPrice = 4099.99m,
						ColorId = 4,
						SizeId = 20,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 10,
						BarcodeId = 10,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});


					product.HasData(new
					{
						Id = 50,

						ProductName = "Bot PICTON",
						UnitPrice = 2890.99m,
						ColorId = 1,
						SizeId = 17,
						GenderId = 1,

						ProductDescription = "",
						UnitsInStock = 10,
						QuantityPerUnit = 1,
						BrandId = 10,
						BarcodeId = 10,

						InsertDate = DateTime.UtcNow,
						LastModifierDate = DateTime.UtcNow
					});
				}
				);


		}



		public DbSet<Product> Products { get; set; }
		public DbSet<ProductColor> ProductColors { get; set; }
		public DbSet<ProductSize> ProductSizes { get; set; }
		public DbSet<ProductBrand> ProductBrands { get; set; }
		public DbSet<ProductBarcode> ProductBarcodes { get; set; }
		public DbSet<Gender> Genders { get; set; }
	}
}