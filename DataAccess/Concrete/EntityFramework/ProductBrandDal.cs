using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class ProductBrandDal : EfEntityRepositoryBase<ProductBrand>, IProductBrandDal
	{
		public ProductBrandDal(JaliriContext jaliriContext) : base(jaliriContext) { }
	}
}
