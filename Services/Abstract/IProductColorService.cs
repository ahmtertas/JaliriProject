using Entity.Concrete;

namespace Services.Abstract
{
	public interface IProductColorService
	{
		Task<IQueryable<ProductColor>> GetAllList();
		Task<ProductColor> GetById(int id);
		Task Insert(ProductColor product);
		Task Update(ProductColor product);
		Task Delete(ProductColor product);
	}
}
