using DataAccess.Abstract;
using Entity.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
	public class ProductBrandManager : IProductBrandService
	{
		private readonly IProductBrandDal _productBrandDal;
		public ProductBrandManager(IProductBrandDal productBrandDal)
		{
			_productBrandDal = productBrandDal;
		}

		public async Task Delete(ProductBrand Product)
		{
			await _productBrandDal.Delete(Product);
		}

		public async Task<IQueryable<ProductBrand>> GetAllList()
		{
			return await _productBrandDal.GetAll();
		}

		public async Task<ProductBrand> GetById(int id)
		{
			return await _productBrandDal.GetValue(Product => Product.Id == id);
		}

		public async Task Insert(ProductBrand Product)
		{
			await _productBrandDal.Insert(Product);
		}

		public async Task Update(ProductBrand Product)
		{
			await _productBrandDal.Update(Product);
		}
	}
}
