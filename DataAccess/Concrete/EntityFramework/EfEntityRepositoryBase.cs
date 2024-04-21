using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
	public abstract class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
		where TEntity : class, new()
	{
		protected readonly JaliriContext context;
		public EfEntityRepositoryBase(JaliriContext context)
		{
			this.context = context;
		}
		public async Task Insert(TEntity entity)
		{
			var addedEntity = context.Entry(entity);
			addedEntity.State = EntityState.Added;
			await context.SaveChangesAsync();
		}

		public async Task Delete(TEntity entity)
		{
			var deletedEntity = context.Entry(entity);
			deletedEntity.State = EntityState.Deleted;
			await context.SaveChangesAsync();
		}

		public async Task<IQueryable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
		{
			return filter == null ?
				 context.Set<TEntity>().AsQueryable() :
				 context.Set<TEntity>().Where(filter).AsQueryable();
		}

		public async Task<TEntity> GetValue(Expression<Func<TEntity, bool>> filter = null)
		{
			return filter == null ?
				context.Set<TEntity>().SingleOrDefault() :
				context.Set<TEntity>().Where(filter).SingleOrDefault();
		}

		public async Task Update(TEntity entity)
		{
			var upadetedEntity = context.Entry(entity);
			upadetedEntity.State = EntityState.Modified;
			await context.SaveChangesAsync();
		}
	}
}
