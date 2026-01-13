using System.Linq.Expressions;

namespace ANC.Infrastructure.Interfaces
{
	[AttributeUsage(AttributeTargets.All)]
	public class CustomName : Attribute
	{
		public string Name { get; set; }
		public CustomName(string name)
		{
			Name = name;
		}
	}
	public interface IGenericRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAllAsync();
		IQueryable<T> Entities { get; }
		IQueryable<T> GetQueryableByProperty(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
		Task<T?> GetByIdAsync(object id);
		Task AddAsync(T entity);
		Task AddRangeAsync(List<T> entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(params object[] keyValues);
		Task<List<T>> GetAllByPropertyAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, bool tracked = true);
		Task<T> GetByPropertyAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true, string? includeProperties = null);
	}
}
