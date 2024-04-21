using DataAccess.Abstract;
using Entity.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
	public class ProductSizeManager : IProductSizeService
	{
		private readonly IProductSizeDal _productSizeDal;
		public ProductSizeManager(IProductSizeDal productSizeDal)
		{
			_productSizeDal = productSizeDal;
		}

		public async Task Delete(ProductSize Product)
		{
			await _productSizeDal.Delete(Product);
		}

		public async Task<IQueryable<ProductSize>> GetAllList()
		{
			return await _productSizeDal.GetAll();
		}

		public async Task<ProductSize> GetById(int id)
		{
			return await _productSizeDal.GetValue(Product => Product.Id == id);
		}

		public async Task Insert(ProductSize Product)
		{
			await _productSizeDal.Insert(Product);
		}

		public async Task Update(ProductSize Product)
		{
			await _productSizeDal.Update(Product);
		}
	}
}
