using DataAccess.Abstract;
using Entity.Concrete;
using Services.Abstract;
using Services.Utilities.Result;

namespace Services.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;
		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public async Task<Result<bool>> Delete(Product Product)
		{
			await _productDal.Delete(Product);
			return new Result<bool>(true);
		}

		public async Task<Result<IQueryable<Product>>> GetAllList()
		{
			var result = await _productDal.GetAll();
			return new Result<IQueryable<Product>>(result);
		}

		public async Task<IQueryable<Product>> GetAllWithOData()
		{
			return await _productDal.GetWithNested();
		}

		public async Task<Result<Product>> GetById(int id)
		{
			var result = await _productDal.GetValue(Product => Product.Id == id);
			return new Result<Product>(result);
		}

		public async Task<Result<IQueryable<Product>>> GetWithNestedList()
		{
			var result = await _productDal.GetWithNested();
			return new Result<IQueryable<Product>>(result);
		}

		public async Task<Result<bool>> Insert(Product Product)
		{
			await _productDal.Insert(Product);
			return new Result<bool>(true);
		}

		public async Task<Result<bool>> Update(Product Product)
		{
			await _productDal.Update(Product);
			return new Result<bool>(true);
		}
	}
}
