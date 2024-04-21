using Entity.Concrete;
using Services.Utilities.Result;

namespace Services.Abstract
{
	public interface IProductService
	{
		Task<Result<IQueryable<Product>>> GetAllList();
		Task<Result<IQueryable<Product>>> GetWithNestedList();
		Task<Result<Product>> GetById(int id);
		Task<Result<bool>> Insert(Product product);
		Task<Result<bool>> Update(Product product);
		Task<Result<bool>> Delete(Product product);
		Task<IQueryable<Product>> GetAllWithOData();
	}
}
