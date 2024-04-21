using Entity.Concrete;

namespace Services.Abstract
{
	public interface IProductBrandService
	{
		Task<IQueryable<ProductBrand>> GetAllList();
		Task<ProductBrand> GetById(int id);
		Task Insert(ProductBrand productBrand);
		Task Update(ProductBrand productBrand);
		Task Delete(ProductBrand productBrand);
	}
}
