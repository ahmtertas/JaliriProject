using System.Linq.Expressions;

namespace DataAccess.Abstract
{
	public interface IEntityRepository<T>
	{
		Task<IQueryable<T>> GetAll(Expression<Func<T, bool>> filter = null);
		Task<T> GetValue(Expression<Func<T, bool>> filter = null);
		Task Insert(T entity);
		Task Update(T entity);
		Task Delete(T entity);
	}
}
