using Entity.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
	public interface IProductDal : IEntityRepository<Product>
	{
		Task<IQueryable<Product>> GetWithNested(Expression<Func<Product, bool>> filter = null);
	}
}
