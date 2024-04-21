using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class ProductSizeDal : EfEntityRepositoryBase<ProductSize>, IProductSizeDal
	{
		public ProductSizeDal(JaliriContext jaliriContext) : base(jaliriContext) { }
	}
}
