using DataAccess.Abstract;
using Entity.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
	public class ProductColorManager : IProductColorService
	{
		private readonly IProductColorDal _productColorDal;
		public ProductColorManager(IProductColorDal productColorDal)
		{
			_productColorDal = productColorDal;
		}

		public async Task Delete(ProductColor Product)
		{
			await _productColorDal.Delete(Product);
		}

		public async Task<IQueryable<ProductColor>> GetAllList()
		{
			return await _productColorDal.GetAll();
		}

		public async Task<ProductColor> GetById(int id)
		{
			return await _productColorDal.GetValue(Product => Product.Id == id);
		}

		public async Task Insert(ProductColor Product)
		{
			await _productColorDal.Insert(Product);
		}

		public async Task Update(ProductColor Product)
		{
			await _productColorDal.Update(Product);
		}
	}
}
