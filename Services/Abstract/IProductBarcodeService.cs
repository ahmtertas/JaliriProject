using Entity.Concrete;

namespace Services.Abstract
{
	public interface IProductBarcodeService
	{
		Task<IQueryable<ProductBarcode>> GetAllList();
		Task<ProductBarcode> GetById(int id);
		Task Insert(ProductBarcode productBarcode);
		Task Update(ProductBarcode productBarcode);
		Task Delete(ProductBarcode productBarcode);

	}
}
