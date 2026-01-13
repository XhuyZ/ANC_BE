using ANC.Infrastructure.Bases;
using ANC.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ANC.Infrastructure.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly ANCDbContext _context;
		private readonly DbSet<T> _dbSet;

		public GenericRepository(ANCDbContext context)
		{
			_context = context;
			_dbSet = context.Set<T>();
		}
		public IQueryable<T> Entities => _context.Set<T>();
		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<T?> GetByIdAsync(object id)
		{
			return await _dbSet.FindAsync(id);
		}

		public async Task AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
		}
		public async Task AddRangeAsync(List<T> entity)
		{
			await _dbSet.AddRangeAsync(entity);
		}

		public async Task UpdateAsync(T entity)
		{
			_dbSet.Update(entity);
		}
		public async Task DeleteAsync(params object[] keyValues)
		{
			var entity = await _dbSet.FindAsync(keyValues);
			if (entity != null)
			{
				_dbSet.Remove(entity);
			}
		}
		public async Task<List<T>> GetAllByPropertyAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, bool tracked = true)
		{
			IQueryable<T> query = _dbSet;
			if (!tracked)
			{
				query = query.AsNoTracking();
			}
			if (filter != null)
			{
				query = query.Where(filter);
			}
			if (includeProperties != null)
			{
				foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(includeProp.Trim());
				}
			}

			return await query.ToListAsync();
		}
		public IQueryable<T> GetQueryableByProperty(
				Expression<Func<T, bool>>? filter = null,
				string? includeProperties = null)
		{
			IQueryable<T> query = _dbSet;

			if (filter != null)
				query = query.Where(filter);

			if (includeProperties != null)
			{
				foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(includeProp.Trim());
				}
			}

			return query;
		}
		public async Task<T> GetByPropertyAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true, string? includeProperties = null)
		{
			IQueryable<T> query = _dbSet;
			if (!tracked)
			{
				query = query.AsNoTracking();
			}
			// query = query.AsNoTracking();
			if (includeProperties != null)
			{
				foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(includeProp.Trim());
				}
			}

			if (filter != null)
			{
				query = query.Where(filter);
			}
			return await query.FirstOrDefaultAsync();
		}
	}
}
