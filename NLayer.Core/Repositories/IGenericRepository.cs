using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository <T> where T : class
    {
        Task<T> GetByIdAsync<T>(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
    }
}
