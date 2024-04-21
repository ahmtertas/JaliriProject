using Entity.Concrete;

namespace Services.Abstract
{
	public interface IProductSizeService
	{
		Task<IQueryable<ProductSize>> GetAllList();
		Task<ProductSize> GetById(int id);
		Task Insert(ProductSize product);
		Task Update(ProductSize product);
		Task Delete(ProductSize product);
	}
}
