using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
	public class ProductDal : EfEntityRepositoryBase<Product>, IProductDal
	{
		public ProductDal(JaliriContext jaliriContext) : base(jaliriContext) { }

		public async Task<IQueryable<Product>> GetWithNested(Expression<Func<Product, bool>> filter = null)
		{
			return filter == null ?
				  context.Set<Product>().AsQueryable()
				  .Include(p => p.Gender)
				  .Include(p => p.ProductSize)
				  .Include(p => p.ProductColor)
				  .Include(p => p.ProductBrand)
				  .Include(p => p.ProductBarcode) :
				  context.Set<Product>().Where(filter).AsQueryable()
				  .Include(p => p.Gender)
				  .Include(p => p.ProductSize)
				  .Include(p => p.ProductColor)
				  .Include(p => p.ProductBrand)
				  .Include(p => p.ProductBarcode);
		}
	}
}
