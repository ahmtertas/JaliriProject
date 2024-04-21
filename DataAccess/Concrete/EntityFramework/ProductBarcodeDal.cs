using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class ProductBarcodeDal : EfEntityRepositoryBase<ProductBarcode>, IProductBarcodeDal
	{
		public ProductBarcodeDal(JaliriContext jaliriContext) : base(jaliriContext) { }
	}
}
