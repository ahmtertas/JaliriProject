using DataAccess.Abstract;
using Entity.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
	public class ProductBarcodeManager : IProductBarcodeService
	{
		private readonly IProductBarcodeDal _ProductBarcodeDal;
		public ProductBarcodeManager(IProductBarcodeDal ProductBarcodeDal)
		{
			_ProductBarcodeDal = ProductBarcodeDal;
		}

		public async Task Delete(ProductBarcode Product)
		{
			await _ProductBarcodeDal.Delete(Product);
		}

		public async Task<IQueryable<ProductBarcode>> GetAllList()
		{
			return await _ProductBarcodeDal.GetAll();
		}

		public async Task<ProductBarcode> GetById(int id)
		{
			return await _ProductBarcodeDal.GetValue(Product => Product.Id == id);
		}

		public async Task Insert(ProductBarcode Product)
		{
			await _ProductBarcodeDal.Insert(Product);
		}

		public async Task Update(ProductBarcode Product)
		{
			await _ProductBarcodeDal.Update(Product);
		}
	}
}
