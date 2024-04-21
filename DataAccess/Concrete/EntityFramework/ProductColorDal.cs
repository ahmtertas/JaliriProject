using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class ProductColorDal : EfEntityRepositoryBase<ProductColor>, IProductColorDal
	{
		public ProductColorDal(JaliriContext jaliriContext) : base(jaliriContext) { }
	}
}
