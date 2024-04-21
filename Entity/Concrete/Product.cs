using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
	public class Product : BaseEntity
	{
		public String ProductName { get; set; }
		public String? ProductDescription { get; set; }
		public int UnitsInStock { get; set; }
		public int QuantityPerUnit { get; set; }
		public decimal UnitPrice { get; set; }


		[ForeignKey("ProductBrand")]
		public int BrandId { get; set; }


		[ForeignKey("Gender")]
		public int GenderId { get; set; }

		[ForeignKey("ProductColor")]
		public int? ColorId { get; set; }


		[ForeignKey("ProductBarcode")]
		public int BarcodeId { get; set; }


		[ForeignKey("ProductSize")]
		public int? SizeId { get; set; }


		public virtual ProductBrand? ProductBrand { get; set; }
		public virtual ProductColor? ProductColor { get; set; }
		public virtual ProductSize? ProductSize { get; set; }
		public virtual ProductBarcode? ProductBarcode { get; set; }
		public virtual Gender? Gender { get; set; }

	}
}
